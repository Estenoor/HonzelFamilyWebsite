using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Honzel_Family_Website.Models.Recipe
{
    public class RecipeModel
    {
        [DisplayName("ID")]
        [Key]
        public int ID { get; set; }
        
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Quisine")]
        public List<QuisineModel> Quisine { get; set; }

        [DisplayName("Ingredients")]
        public List<IngredientModel> Ingredients { get; set; }

        [DisplayName("Instructions")]
        public List<InstructionModel> Instructions { get; set; }

        [DisplayName("Prep Time")]
        public TimeSpan PrepTime { get; set; }

        [DisplayName("Cook Time")]
        public TimeSpan CookTime { get; set; }

        [DisplayName("Total Time")]
        public TimeSpan TotalTime { get; set; }

        [DisplayName("Servings")]
        public int Servings { get; set; }

        public RecipeModel(int ID, string Name, List<QuisineModel> Quisine, 
                           List<IngredientModel> Ingredients, 
                           List<InstructionModel> Instructions, TimeSpan PrepTime, 
                           TimeSpan CookTime, TimeSpan TotalTime, 
                           int Servings)
        {
            this.ID = ID;
            this.Name = Name;
            this.Quisine = Quisine;
            this.Instructions = Instructions;
            this.Ingredients = Ingredients;
            this.PrepTime = PrepTime;
            this.CookTime = CookTime;
            this.TotalTime = TotalTime;
            this.Servings = Servings;
        }

        public RecipeModel() { }
    }
}
