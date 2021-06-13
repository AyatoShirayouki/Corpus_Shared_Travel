using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared_Traveling.DataAccess;
using Shared_Traveling.Entities;
using Shared_Traveling.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(GetPostsVM model)
        {
            if(this.HttpContext.Session.GetString("loggedUser") != null)
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

                model.Items = repo.GetAll(c => c.UserId != int.Parse(this.HttpContext.Session.GetString("loggedUserId")));

                if (reqs.Count != 0)
                {
                    for (int j = 0; j < first.Count; j++) 
                    {
                        for (int i = 0; i < reqs.Count; i++)
                        {
                            Console.WriteLine(first[j].Id + " " + reqs[i].TravelPostId + " - " + reqs[i].Content);
                            if (first[j].Id == reqs[i].TravelPostId)
                            {
                                second.Add(first[j]);
                            }
                        }
                    }

                    second = second.Distinct().ToList();

                    model.Items = first.Except(second).ToList();
                }
                return View(model);
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.HttpContext.Session.GetString("loggedUser") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (this.HttpContext.Session.GetString("loggedUser") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UsersRepository repo = new UsersRepository();
            User item = repo.GetFirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

            if (item == null)
            {
                ModelState.AddModelError("AuthenticationFailed", "Wrong username or password");
                return View(model);
            }

            this.HttpContext.Session.SetString("loggedUser", model.Username);
            this.HttpContext.Session.SetString("loggedUserId", item.Id.ToString());
            this.HttpContext.Session.SetString("LoggedUserUsername", item.Username);
            this.HttpContext.Session.SetString("LoggedUserFirstName", item.FirstName);
            this.HttpContext.Session.SetString("LoggedUserLastName", item.LastName);


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            if (this.HttpContext.Session.GetString("loggedUser") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            this.HttpContext.Session.Remove("loggedUser");
            this.HttpContext.Session.Remove("loggedUserId");
            this.HttpContext.Session.Remove("LoggedUserUsername");
            this.HttpContext.Session.Remove("LoggedUserFirstName");
            this.HttpContext.Session.Remove("LoggedUserLastName");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            MyDbContext context = new MyDbContext();

            User item = new User();

            item.Username = model.Username;
            item.Password = model.Password;
            item.FirstName = model.FirstName;
            item.LastName = model.LastName;

            context.Users.Add(item);
            context.SaveChanges();
            return RedirectToAction("Login", "Home");
        }
    }
}
