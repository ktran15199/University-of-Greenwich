﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University_of_Greenwich.Models;

namespace University_of_Greenwich.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext _context;
        public RoleController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Role
        public ActionResult Index()
        {
            var Roles = _context.Roles.ToList();
            return View(Roles);
        }
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            _context.Roles.Add(Role);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
    