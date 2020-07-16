using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Honzel_Family_Website.Models.Recipe
{
    public class QuisineModel
    {
        [DisplayName("ID")]
        [Key]
        public int ID { get; set; }

        //Name of the Quisine
        public String Name { get; set; }

        //Creates an Instance of a Quisine with the given name
        public QuisineModel(int ID, String Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        //Default Constructor for Database and Controller reasons
        public QuisineModel() { }
    }
}
