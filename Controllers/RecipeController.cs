using Microsoft.AspNetCore.Http;
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

        public ActionResult ComingSoonDetails()
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
            
            
            
                if(ModelState.IsValid)
                {
                    _db.Recipes.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                      
            
                return View(obj);
            
        }

        // GET: RecipeController/Edit/5
        public ActionResult Update(int id)
        {
            var obj = _db.Recipes.Find(id);
            try
            {
                return View(obj);
            }
            catch 
            {

                return NotFound();
            }
           
            
        }

        // POST: RecipeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePost(RecipeModel obj)
        {
           
            try
            {
                _db.Recipes.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: RecipeController/Delete/5
        public ActionResult Delete(int id)
        {
            var obj = _db.Recipes.Find(id);
            try
            {
                return View(obj);
            }
            catch
            {

                return NotFound();
            }
        }

        // POST: RecipeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(RecipeModel obj)
        {
            try
            {
                _db.Recipes.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
