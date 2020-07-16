using System;
using UnitsNet.Units;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Honzel_Family_Website.Models.Recipe
{
    public class IngredientModel
    {
        public String Name { get; set; }
        public double Quantity { get; set; }
        public VolumeUnit Unit { get; set; }

        public IngredientModel(String Name, double Quantity, VolumeUnit Unit)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Unit = Unit;
        }

        public IngredientModel() { }
    }
}
