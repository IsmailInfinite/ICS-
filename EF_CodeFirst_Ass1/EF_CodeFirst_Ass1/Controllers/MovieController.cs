using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_CodeFirst_Ass1.Models;

namespace EF_CodeFirst_Ass1.Controllers
{
    public class MovieController : Controller
    {
        MovieType mm = new MovieType();

        // GET: Movie
        public ActionResult Index()
        {
            return View(mm.Movie.ToList());
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movies movies)
        {
            mm.Movie.Add(movies);
            mm.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public ActionResult Edit(Movies movies)
        //{

        //    return View();
        //}



        //EDIT & DELETE


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Movies mv = mm.Movie.Find(id);
            return View(mv);
        }
        [HttpPost]
        public ActionResult Edit(Movies movies)
        {
            Movies me = mm.Movie.Find(movies.MId);
            me.Moviename = movies.Moviename;
            me.DateOfRelease = movies.DateOfRelease;
            mm.SaveChanges();
            return RedirectToAction("Index");
        }


        
        public ActionResult Delete(int id)
        {
            Movies ms = mm.Movie.Find(id);
            mm.Movie.Remove(ms);
            mm.SaveChanges();
            return RedirectToAction("index");
        }






        //[HttpPost]
        //public ActionResult Delete(int MId)
        //{
        //    Movies ms = mm.Movie.Find(MId);
        //    ms.Moviename.Remove(ms);
        //    mm.SaveChanges();
        //    return RedirectToAction("index");
        //}
    }
}


//        //[HttpPost]
//        //public ActionResult Edit(Movies movies)
//        //{
//        //    mm.Movie.Edit(movies);
//        //    mm.SaveChanges();
//        //    return RedirectToAction("Index");
//        //}


//        [HttpPost]
//        public ActionResult Delete(string Mname)
//        {

//            mm.SaveChanges();
//            return RedirectToAction("index");
//        }

//    }

//}