using Microsoft.EntityFrameworkCore;
using RecipeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeForm.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {

        }
       
        
         public DbSet<RecipeModel> Recipes { get; set; }
        

    }
}
