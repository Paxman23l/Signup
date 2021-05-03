using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnCallSignup.Models;
using OnCallSignup.Data;

namespace OnCallSignup
{
    public class SignupController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SignupController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: SignupController
        public ActionResult Index()
        {
            var signups = _db.Signups.OrderByDescending(c =>c.Date).ToList();
            return View(signups);
        }

        // GET: SignupController/Details/5
        public ActionResult Details(int id)
        {
            var item = _db.Signups.SingleOrDefault(x => x.Id == id);
            return View(item);
        }

        // GET: SignupController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SignupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Signup collection)
        {
            try
            {
                _db.Signups.Add(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SignupController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = _db.Signups.SingleOrDefault(x => x.Id == id);
            return View(item);
        }

        // POST: SignupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Signup collection)
        {
            try
            {
                _db.Signups.Update(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SignupController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = _db.Signups.SingleOrDefault(x => x.Id == id);
            return View(item);
        }

        // POST: SignupController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Signup collection)
        {
            try
            {
                _db.Signups.Remove(collection);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
