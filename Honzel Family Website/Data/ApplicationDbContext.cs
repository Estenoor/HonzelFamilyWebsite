using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Honzel_Family_Website.Models.Recipe;

namespace Honzel_Family_Website.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Honzel_Family_Website.Models.Recipe.RecipeModel> RecipeModel { get; set; }
    }
}
