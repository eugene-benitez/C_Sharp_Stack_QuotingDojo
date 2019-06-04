using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using C_Sharp.Models;
using Microsoft.AspNetCore.Identity;

namespace C_Sharp.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }




        //!!!!!!!!!!!  GETS
        //!!!!!!!!!!!  GETS
        //!!!!!!!!!!!  GETS
        //!!!!!!!!!!!  GETS
        //!!!!!!!!!!!  GETS


        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Now = CurrentTime;
            HttpContext.Session.Clear();
            return View();
        }


        [HttpGet("login")]
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("LoggedUser") == null)
            {
                return RedirectToAction("Login");
            }

            HttpContext.Session.GetInt32("LoggedUser");
            int? id = HttpContext.Session.GetInt32("LoggedUser");
            @ViewBag.UserId = (int)id;


            var AllQuotes = dbContext.Quote
            .Include(u => u.Creator)
            .ToList();
            @ViewBag.AllQuotes = AllQuotes;


            var LikedQuotes = dbContext.Quote
            .Include(L => L.Likers)
            .ThenInclude(U => U.User)
            .ToList();
            @ViewBag.LikedQuotes = LikedQuotes;

            var LikeId = dbContext.Likes
            .ToList();
            @ViewBag.LikeId = LikeId;

            return View();
        }


        //!!!!!!!!!!!  ERRORS
        //!!!!!!!!!!!  ERRORS


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(User NewUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.User.Any(u => u.Email == NewUser.Email))
                {

                    ModelState.AddModelError("Email", "Email already in use!");

                    return View("Index");
                }

                // Initializing a PasswordHasher object, providing our User class as its
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                //Save your user object to the database
                dbContext.Add(NewUser);
                // OR dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                // Other code
                return RedirectToAction("Login");
            }
            return View("Index");
        }

        [HttpPost("log")]
        public IActionResult Log(LoginUser submission)
        {
            var userInDb = dbContext.User.FirstOrDefault(u => u.Email == submission.Email);
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(submission, userInDb.Password, submission.Password);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
            }
            HttpContext.Session.SetInt32("LoggedUser", userInDb.UserID);
            return RedirectToAction("Dashboard");
        }


        [HttpPost("create")]
        public IActionResult Create(Quote newQuote)
        {
            newQuote.CreatorID = (int)HttpContext.Session.GetInt32("LoggedUser");
            dbContext.Add(newQuote);
            dbContext.SaveChanges();


            return RedirectToAction("Dashboard");
        }


        [HttpPost("like")]
        public IActionResult Like(Likes newLike)
        {
            newLike.UserID = (int)HttpContext.Session.GetInt32("LoggedUser");
            dbContext.Add(newLike);
            dbContext.SaveChanges();


            return RedirectToAction("Dashboard");
        }


        [HttpGet("unlike/{qID}")]
        public IActionResult Unlike(int qID)
        {

            Likes currLike = dbContext.Likes
            .SingleOrDefault(u => u.UserID == HttpContext.Session.GetInt32("LoggedUser") && u.QuoteID == qID);


            dbContext.Remove(currLike);
            dbContext.SaveChanges();


            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{qID}")]
        public IActionResult Delete(int qID)
        {
            var x = (int)HttpContext.Session.GetInt32("LoggedUser");

            Quote currQuote = dbContext.Quote
            .SingleOrDefault(q => q.QuoteID == qID);



            dbContext.Remove(currQuote);
            dbContext.SaveChanges();


            return RedirectToAction("Dashboard");
        }
    }
}
