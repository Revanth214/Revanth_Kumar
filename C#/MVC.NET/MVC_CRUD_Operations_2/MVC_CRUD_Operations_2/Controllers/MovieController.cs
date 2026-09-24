using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieAccessLayer;

namespace MVC_CRUD_Operations_2.Controllers
{
    public class MovieController : Controller
    {
        MovieDetails details = new MovieDetails();
        // GET: Movie
        public ActionResult Index()
        {
            List<MovieModel> lst = details.GetMovieDetails();
            return View(lst);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            List<MovieModel> lst = details.GetMovieDetails();
            var results = lst.Where(x => x.MovieID == id).FirstOrDefault();
            return View(results);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(MovieModel model)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    details.InsertMovie(model);
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            List<MovieModel> lst = details.GetMovieDetails();
            var results = lst.Where(dt => dt.MovieID == id).FirstOrDefault();
            return View(results);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(MovieModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    details.UpdateMovie(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            List<MovieModel> lst = details.GetMovieDetails();
            var results = lst.Where(data => data.MovieID == id).FirstOrDefault();
            return View(results);
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(MovieModel model)
        {
            try
            {
                // TODO: Add delete logic here
                if(ModelState.IsValid)
                {
                    details.DeleteMovie(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
