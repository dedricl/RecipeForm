using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeForm.Models
{
    public class RecipeModel
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int RecipeId { get; set; }

        [DisplayName("Recipe Name")]
        public string RecipeName { get; set; }

        [DisplayName("Meal Type")]

        public string MealType { get; set; }

        [DisplayName("Main Ingredient")]
        public string Ingredient { get; set; }

        [DisplayName("Prep Time")]
        public string PrepTime { get; set; }
    }

   
}
