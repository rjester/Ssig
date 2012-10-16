using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ssig.Models;
using Ssig.Models.Abstract;
using Ssig.Models.Repositories;

namespace Ssig.Controllers.Admin
{
    public class AdminMeetingController : Controller
    {
      private IMeetingRepository repo;

      public AdminMeetingController() : this(new MeetingRepository()) { }

      public AdminMeetingController(IMeetingRepository repository) {
        this.repo = repository;
      }
      //
        // GET: /Meeting/

        public ActionResult Index()
        {
        var results = repo.GetAll().OrderByDescending(m => m.MeetingDate);  
          return View(results);
        }

        //
        // GET: /Meeting/Details/5

        public ActionResult Details(int id)
        {
          var result = repo.Get(id);  
          return View(result);
        }

        //
        // GET: /Meeting/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Meeting/Create

        [HttpPost]
        public ActionResult Create(Meeting meeting)
        {
            try
            {
              var result = repo.Add(meeting);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(meeting);
            }
        }

        //
        // GET: /Meeting/Edit/5

        public ActionResult Edit(int id)
        {
          var meeting = repo.Get(id);  
          return View(meeting);
        }

        //
        // POST: /Meeting/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Meeting meeting)
        {
            try
            {
                // TODO: Add update logic here
              var result = repo.Update(meeting);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(meeting);
            }
        }

        //
        // GET: /Meeting/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Meeting/Delete/5

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
