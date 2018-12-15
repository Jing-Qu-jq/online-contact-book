using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineContactBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            Models.Contact contact1 = new Models.Contact();
            contact1.Photo = "https://image.flaticon.com/icons/png/512/190/190676.png";
            contact1.Name = "Lily";
            contact1.Email = "b@c.com";
            contact1.Phone = "123-456-7890";
            contact1.Note = "From work";
            Models.Contact contact2 = new Models.Contact();
            contact2.Photo = "https://image.flaticon.com/icons/png/512/146/146022.png";
            contact2.Name = "Jackson";
            contact2.Email = "b@c.com";
            contact2.Phone = "123-456-7890";
            contact2.Note = "From work";
            Models.Contact contact3 = new Models.Contact();
            contact3.Photo = "https://cdn0.iconfinder.com/data/icons/user-pictures/100/maturewoman-3-512.png";
            contact3.Name = "Jessica Mill";
            contact3.Email = "b@c.com";
            contact3.Phone = "123-456-7890";
            contact3.Note = "From work";
            Models.Contact contact4 = new Models.Contact();
            contact4.Photo = "https://cdn.iconscout.com/icon/free/png-256/avatar-372-456324.png";
            contact4.Name = "Jackson";
            contact4.Email = "b@c.com";
            contact4.Phone = "123-456-7890";
            contact4.Note = "From work";
            Models.Contact contact5 = new Models.Contact();
            contact5.Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Creative-Tail-People-man-2.svg/1024px-Creative-Tail-People-man-2.svg.png";
            contact5.Name = "Justin Coffman";
            contact5.Email = "b@c.com";
            contact5.Phone = "123-456-7890";
            contact5.Note = "From work";
            Models.Contact contact6 = new Models.Contact();
            contact6.Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmbcHKPAR32DjkU4hV8FhVueYW5J_ALlvDs9_FfjBWpOTGDA9H";
            contact6.Name = "Lily";
            contact6.Email = "b@c.com";
            contact6.Phone = "123-456-7890";
            contact6.Note = "From work";
            Models.Contact contact7 = new Models.Contact();
            contact7.Photo = "https://image.flaticon.com/icons/png/512/146/146022.png";
            contact7.Name = "Jackson";
            contact7.Email = "b@c.com";
            contact7.Phone = "123-456-7890";
            contact7.Note = "From work";
            object[] Contacts = {
                contact1,
                contact2,
                contact3,
                contact4,
                contact5,
                contact6,
                contact7,
            };
            ViewBag.Contacts = Contacts;
            return View();
        }


        public ActionResult Login()
        {
            ViewBag.Message = "Login page.";

            return View();
        }
    }
}