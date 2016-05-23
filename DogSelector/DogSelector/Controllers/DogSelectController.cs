using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DogSelector.Models;

namespace DogSelector.Controllers
{   
    public class DogSelectController : Controller
    {
        private List<Dog> db;
        // GET: DogSelect
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult SelectedDog(EScale activityLevel, EScale sheddingLevel, EScale groomingLevel, EScale intelligenceLevel, ELength coatlength, ESize size, bool goodWithChildren, bool drools)
        {
            DatabaseManager dbm = new DatabaseManager();
            db = dbm.makeDatabase();

            Dog nDog = new Dog();
            nDog.ActivityLevel = activityLevel;
            nDog.SheddingLevel = sheddingLevel;
            nDog.GroomingLevel = groomingLevel;
            nDog.IntelligenceLevel = intelligenceLevel;
            nDog.Coatlength = coatlength;
            nDog.Size = size;
            nDog.GoodWithChildren = goodWithChildren;
            nDog.Drools = drools;

            nDog.BreedName = db[0].BreedName;
            nDog.ImageName = db[0].ImageName;
            nDog.DisplayName = db[0].DisplayName;

            Dog recommendation = dbm.FindRecommodation(db, nDog);

            return View(recommendation);
        }



    }
}