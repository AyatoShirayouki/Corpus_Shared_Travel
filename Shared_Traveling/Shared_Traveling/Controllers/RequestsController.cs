using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Traveling.DataAccess;
using Shared_Traveling.Entities;
using Shared_Traveling.ViewModels.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.Controllers
{
    public class RequestsController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            TravelPostsRepository Prepo = new TravelPostsRepository();
            RequestsRepository Crepo = new RequestsRepository();
            UsersRepository Urepo = new UsersRepository();
            AprovedRequestRepository ARrepo = new AprovedRequestRepository();

            model.User = Urepo.GetById(loggedUserId);
            model.Post = Prepo.GetById(model.ParentId);

            List<Request> reqs = Crepo.GetAll(c => c.TravelPostId == model.ParentId);
            List<User> users = Urepo.GetAll();
            List<AprovedRequest> appReqs = ARrepo.GetAll();

            List<User> reqUsers = new List<User>();
            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < reqs.Count; j++)
                {
                    string[] names = reqs[j].Content.Split(" ");
                    if (users[i].FirstName == names[0] && users[i].LastName == names[1])
                    {
                        reqUsers.Add(users[i]);
                    }
                }
            }

            List<Request> filteredReqs = new List<Request>();

            for (int i = 0; i < appReqs.Count; i++)
            {
                for (int j = 0; j < reqs.Count; j++)
                {
                    if (appReqs[i].TravelPostId == reqs[j].TravelPostId && appReqs[i].UserId == reqUsers[j].Id)
                    {
                        filteredReqs.Add(reqs[j]);
                    }
                }
            }

            model.Items = reqs.Except(filteredReqs).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateRequest(int parentId)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            UsersRepository Urepo = new UsersRepository();
            User user = Urepo.GetFirstOrDefault(u => u.Id == loggedUserId);
            RequestsRepository repo = new RequestsRepository();
            TravelPostsRepository TPRepo = new TravelPostsRepository();

            Request item = new Request();
  
            item.TravelPostId = parentId;
            item.Content = user.FirstName.ToString() + " " + user.LastName.ToString();
            //TravelPost post = TPRepo.GetFirstOrDefault(p => p.Id == parentId);

            //post.AvailableSeats--;

            repo.Save(item);
            //TPRepo.Save(post);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            RequestsRepository repo = new RequestsRepository();
            Request item = repo.GetById(id);

            if (item == null)
            {
                return RedirectToAction("Index", "TravelPost");
            }

            int postId = item.TravelPostId;

            repo.Delete(item);

            return RedirectToAction("Index", "Requests", new { ParentId = postId });
        }
    }
}
