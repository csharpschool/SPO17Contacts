using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Entities;
using Contacts.Models;
using Contacts.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    public class ContactController : Controller
    {
        public ISqlService _db { get; set; }
        public ContactController(ISqlService db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var contacts = _db.Get<Contact>()
                //.Select(s => new ContactDTO {
                //    Id = s.Id,
                //    Email = s.Email,
                //    Name = s.Name
                //})
                .ToList();

            return View(contacts);
        }

        public IActionResult Details(int id)
        {
            var contact = _db.Get<Contact>()
                .FirstOrDefault(c => c.Id.Equals(id));
            return View(contact);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if(!ModelState.IsValid)
                return View(contact);

            try
            {
                _db.Add(contact);
                return RedirectToAction("Index");
            }
            catch
            {
                //ModelState.AddModelError("Id", "Could not ...");
                return View(contact);
            }
        }

        public IActionResult Edit(int id)
        {
            var contact = _db.Get<Contact>()
                .FirstOrDefault(c => c.Id.Equals(id));

            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (!ModelState.IsValid)
                return View(contact);

            try
            {
                _db.Update(contact);
                return RedirectToAction("Index");
            }
            catch
            {
                //ModelState.AddModelError("Id", "Could not ...");
                return View(contact);
            }
        }

        public IActionResult Delete(int id)
        {
            var contact = _db.Get<Contact>()
                .FirstOrDefault(c => c.Id.Equals(id));

            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            if (!ModelState.IsValid)
                return View(contact);

            try
            {
                _db.Delete(contact);
                return RedirectToAction("Index");
            }
            catch
            {
                //ModelState.AddModelError("Id", "Could not ...");
                return View(contact);
            }
        }

    }
}