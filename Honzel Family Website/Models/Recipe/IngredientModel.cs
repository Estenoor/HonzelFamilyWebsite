using System;
using UnitsNet.Units;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Honzel_Family_Website.Models.Recipe
{
    public class IngredientModel
    {
        [DisplayName("ID")]
        [Key]
        public int ID { get; set; }
        
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Quantity")]
        public double Quantity { get; set; }
        
        [DisplayName("Unit")]
        public VolumeUnit Unit { get; set; }

        public IngredientModel(int ID, string Name, double Quantity, VolumeUnit Unit)
        {
            this.ID = ID;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Unit = Unit;
        }

        public IngredientModel() { }
    }
}
