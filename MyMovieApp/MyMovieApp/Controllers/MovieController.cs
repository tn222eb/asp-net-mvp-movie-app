using MyMovieApp.Models;
using MyMovieApp.Models.Abstract;
using MyMovieApp.Models.Service;
using MyMovieApp.Models.Webservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMovieApp.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private IMovieService m_service;

        public MovieController()
            : this(new MovieService())
        {

        }

        public MovieController(IMovieService service)
        {
            m_service = service;
        }

        [AllowAnonymous]
        public ActionResult Index(MovieViewModel model)
        {
            try
            {
                model.Movies = m_service.GetMovies();
                return View(model);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Title")] MovieViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = m_service.AddMovie(model.Title);

                    if (result)
                    {
                        TempData["success"] = "Movie has succesfully been stored in the database";
                        return RedirectToAction("Index");
                    }
                }
                return View(model);
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException.Message);
            }
        }
    }
}
