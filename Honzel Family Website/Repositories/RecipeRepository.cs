using Honzel_Family_Website.Data;
using Honzel_Family_Website.Models.Recipe;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honzel_Family_Website.Repositories
{
    public class RecipeRepository
    {
        private readonly ApplicationDbContext _context;

        public RecipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /**
         * Returns the First Recipe that matches the given ID
         * 
         */
        public RecipeModel getRecipeModel(int ID)
        {
            return _context.RecipeModel.FirstOrDefault(R => R.ID == ID);

        }
    }
}
