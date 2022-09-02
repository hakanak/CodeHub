using CodeHub.Models;
using CodeHub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeHub.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        CategoryRepository cat = new CategoryRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return PartialView("Menu", cat.GetCategoryMenu(User.Identity.Name));
        }


        public ActionResult CategoryAdd()
        {
        

            return View();
        }

        [HttpPost]
        public ActionResult CategoryAdd(Category mdl)
        {
            cat.SetCategory(mdl.CategoryName, mdl.Description, mdl.RowOrder, User.Identity.Name);
            return Redirect("/Home/CategoryList");
        }

        public ActionResult CategoryList()
        {
            return View(cat.GetCategoryList(User.Identity.Name));
        }








        public ActionResult Repo(string id)
        {
            var catDetail = cat.GetCategoryGuid(User.Identity.Name, id);

            ViewBag.CatName = catDetail.CategoryName;
            ViewBag.CatDetail = catDetail.Description;

            return View();
        }



        public ActionResult SnippetAdd()
        {



            ViewBag.Message = "Your ahakana page.";

            return View();
        }









        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
