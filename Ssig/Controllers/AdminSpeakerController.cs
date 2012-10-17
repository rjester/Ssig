using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ssig.Models;
using Ssig.Models.Abstract;
using Ssig.Models.Repositories;

namespace Ssig.Controllers
{
    public class AdminSpeakerController : Controller
    {
      private ISpeakerRepository repo;

      public AdminSpeakerController() : this(new SpeakerRepository()) {}

      public AdminSpeakerController(ISpeakerRepository repository) {
        this.repo = repository;
      }

      //
        // GET: /AdminSpeaker/

        public ActionResult Index()
        {
          var results = repo.GetAll().OrderByDescending(m => m.LastName);
        return View(results);
        }

        //
        // GET: /AdminSpeaker/Details/5

        public ActionResult Details(int id)
        {
          var result = repo.Get(id);
          return View(result);
        }

        //
        // GET: /AdminSpeaker/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AdminSpeaker/Create

        [HttpPost]
        public ActionResult Create(Speaker speaker)
        {
          try {
            var result = repo.Add(speaker);

            return RedirectToAction("Index");
          } catch {
            return View(speaker);
          }
        }

        //
        // GET: /AdminSpeaker/Edit/5

        public ActionResult Edit(int id)
        {
          var speaker = repo.Get(id);
          return View(speaker);
        }

        //
        // POST: /AdminSpeaker/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Speaker speaker)
        {
          try {
            // TODO: Add update logic here
            var result = repo.Update(speaker);
            return RedirectToAction("Index");
          } catch {
            return View(speaker);
          }
        }

        //
        // GET: /AdminSpeaker/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /AdminSpeaker/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
