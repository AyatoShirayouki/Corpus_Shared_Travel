using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Traveling.ActionFilters;
using Shared_Traveling.DataAccess;
using Shared_Traveling.Entities;
using Shared_Traveling.ViewModels.TravelPosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.Controllers
{
    [UserAuthenticationFilter]
    public class TravelPostController : Controller
    {
        public IActionResult Index(IndexVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            TravelPostsRepository repo = new TravelPostsRepository();
            UsersRepository Urepo = new UsersRepository();
            model.User = Urepo.GetById(loggedUserId);

            User item = Urepo.GetFirstOrDefault(u => u.Id == loggedUserId);
            model.PUFirstName = item.FirstName;
            model.PULastName = item.LastName;
            model.PUUsername = item.Username;

            model.Items = repo.GetAll(c => c.UserId == loggedUserId);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            TravelPostsRepository repo = new TravelPostsRepository();

            TravelPost item = new TravelPost();
            
            item.UserId = loggedUserId;
            item.AddressOfDeparture = model.AddressOfDeparture;
            item.AddressOfDestination = model.AddressOfDestination;
            item.CityOfDeparture = model.CityOfDeparture;
            item.CityOfDestination = model.CityOfDestination;
            item.HourOfDeparture = model.HourOfDeparture;
            item.HourOfDestination = model.HourOfDestination;
            item.Price = model.Price;
            item.AvailableSeats = model.AvailableSeats;

            repo.Save(item);
            return RedirectToAction("Index", "TravelPost");
        }

        public IActionResult Delete(int id)
        {
            TravelPostsRepository repo = new TravelPostsRepository();
            TravelPost item = new TravelPost();
            item.Id = id;

            AprovedRequestRepository ARrepo = new AprovedRequestRepository();
            List<AprovedRequest> list = ARrepo.GetAll(u => u.TravelPostId == id);
            if (list != null)
            {
                foreach (AprovedRequest u in list)
                {
                    ARrepo.Delete(u);
                }
            }

            repo.Delete(item);

            return RedirectToAction("Index", "TravelPost");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            TravelPostsRepository repo = new TravelPostsRepository();
            TravelPost item = repo.GetFirstOrDefault(u => u.Id == id);
            if (item == null)
            {
                return RedirectToAction("Index", "TravelPost");
            }
            EditVM model = new EditVM();

            model.Id = item.Id;
            model.UserId = item.UserId;
            model.CityOfDeparture = item.CityOfDeparture;
            model.CityOfDestination = item.CityOfDestination;
            model.AddressOfDeparture = item.AddressOfDeparture;
            model.AddressOfDestination = item.AddressOfDestination;
            model.AvailableSeats = item.AvailableSeats;
            model.HourOfDeparture = item.HourOfDeparture;
            model.HourOfDestination = item.HourOfDestination;
            model.Price = item.Price;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            TravelPostsRepository repo = new TravelPostsRepository();

            TravelPost item = new TravelPost();

            item.Id = model.Id;
            item.UserId = model.UserId;
            item.CityOfDeparture = model.CityOfDeparture;
            item.CityOfDestination = model.CityOfDestination;
            item.AddressOfDeparture = model.AddressOfDeparture;
            item.AddressOfDestination = model.AddressOfDestination;
            item.AvailableSeats = model.AvailableSeats;
            item.HourOfDeparture = model.HourOfDeparture;
            item.HourOfDestination = model.HourOfDestination;
            item.Price = model.Price;

            repo.Save(item);
            return RedirectToAction("Index", "TravelPost");
        }

        [HttpGet]
        public IActionResult Aplications(AplicationVM model)
        {
            TravelPostsRepository repo = new TravelPostsRepository();
            UsersRepository Urepo = new UsersRepository();
            RequestsRepository Rrepo = new RequestsRepository();

            string fName = this.HttpContext.Session.GetString("LoggedUserFirstName");
            string lName = this.HttpContext.Session.GetString("LoggedUserLastName");

            List<Request> reqs = Rrepo.GetAll(x => x.Content.Contains(fName + " " + lName));

            model.Users = Urepo.GetAll(c => c.Id != int.Parse(this.HttpContext.Session.GetString("loggedUserId")));

            List<TravelPost> first = repo.GetAll(c => c.UserId != int.Parse(this.HttpContext.Session.GetString("loggedUserId")));
            List<TravelPost> second = new List<TravelPost>();

            //model.Items = repo.GetAll(c => c.UserId != int.Parse(this.HttpContext.Session.GetString("loggedUserId")));

            if (reqs.Count != 0)
            {
                for (int j = 0; j < first.Count; j++)
                {
                    for (int i = 0; i < reqs.Count; i++)
                    {
                        //Console.WriteLine(first[j].Id + " " + reqs[i].TravelPostId + " - " + reqs[i].Content);
                        if (first[j].Id == reqs[i].TravelPostId)
                        {
                            second.Add(first[j]);
                        }
                    }
                }

                second = second.Distinct().ToList();

                model.Items = second;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Approve(int requestId)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.BeginTransaction();

                UsersRepository Urepo = new UsersRepository();
                RequestsRepository Rrepo = new RequestsRepository();
                TravelPostsRepository TPrepo = new TravelPostsRepository();
                AprovedRequestRepository repo = new AprovedRequestRepository(uow);

                Request req = Rrepo.GetFirstOrDefault(r => r.Id == requestId);
                string[] reqContent = req.Content.Split(" ");
                TravelPost post = TPrepo.GetFirstOrDefault(p => p.Id == req.TravelPostId);
                User user = Urepo.GetFirstOrDefault(u => u.FirstName == reqContent[0] && u.LastName == reqContent[1]);

                AprovedRequest approvedRequest = new AprovedRequest();

                approvedRequest.UserId = user.Id;
                approvedRequest.TravelPostId = post.Id;
                post.AvailableSeats--;//

                repo.Save(approvedRequest);
                TPrepo.Save(post);//
                uow.Commit();

                return RedirectToAction("Index", "Requests", new { ParentId = post.Id });
            } 
        }

        public IActionResult MyApprovedRequests(MyApprovedRequestsVM model)
        {
            int loggedUserId = int.Parse(this.HttpContext.Session.GetString("loggedUserId"));
            AprovedRequestRepository repo = new AprovedRequestRepository();
            UsersRepository Urepo = new UsersRepository();
            MyDbContext context = new MyDbContext();
            model.Items = context.AprovedRequests.Where(c => c.UserId == loggedUserId).Select(utp => utp.ParentPost).ToList();
            model.Users = Urepo.GetAll(u => u.Id != loggedUserId);
            
            return View(model);
        }
    }
}
