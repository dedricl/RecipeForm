using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace RecipeForm.Models
{
    public class RecipeModel
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int RecipeId { get; set; }

        [DisplayName("Recipe Name")]
        [Required]
        public string RecipeName { get; set; }

        [DisplayName("Meal Type")]
        [Required]
        public string MealType { get; set; }

        [DisplayName("Main Ingredient")]
        [Required]
        public string Ingredient { get; set; }

        [DisplayName("Prep Time")]
        [Required]
        public string PrepTime { get; set; }
    }

   
}
