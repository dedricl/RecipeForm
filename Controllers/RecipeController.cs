﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeForm.Data;
using RecipeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeForm.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ApplicationDBContext _db;

        public RecipeController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: RecipeController
        public ActionResult Index()
        {
            IEnumerable<RecipeModel> objList = _db.Recipes;
            return View(objList);
        }

        // GET: Chicken Noodle recipe
        public ActionResult ChickenNoodleDetails()
        {
            return View();
            
        }

        //GET: Apple pie recipe
        public ActionResult ApplePieDetails()
        {
            return View();

        }

        // GET: RecipeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecipeModel obj)
        {
            
            try
            {
                _db.Recipes.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecipeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecipeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
