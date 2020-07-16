using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Honzel_Family_Website.Models.Recipe
{
    public class RecipeModel
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Quisine")]
        public List<String> Quisine { get; set; }

        [DisplayName("Ingredients")]
        public List<IngredientModel> Ingredients { get; set; }

        [DisplayName("Instructions")]
        public List<String> Steps { get; set; }

        [DisplayName("Prep Time")]
        public TimeSpan PrepTime { get; set; }

        [DisplayName("Cook Time")]
        public TimeSpan CookTime { get; set; }

        [DisplayName("Total Time")]
        public TimeSpan TotalTime { get; set; }

        [DisplayName("Servings")]
        public int Servings { get; set; }

        public RecipeModel(String Name, List<String> Quisine, 
                           List<IngredientModel> Ingredients, 
                           List<String> Steps, TimeSpan PrepTime, 
                           TimeSpan CookTime, TimeSpan TotalTime, 
                           int Servings)
        {
            this.Name = Name;
            this.Quisine = Quisine;
            this.Steps = Steps;
            this.Ingredients = Ingredients;
            this.PrepTime = PrepTime;
            this.CookTime = CookTime;
            this.TotalTime = TotalTime;
            this.Servings = Servings;
        }

        public RecipeModel() { }
    }
}
