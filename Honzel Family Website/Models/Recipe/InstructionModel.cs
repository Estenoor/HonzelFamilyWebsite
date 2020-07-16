using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Honzel_Family_Website.Models.Recipe
{
    public class InstructionModel {
        [DisplayName("ID")]
        [Key]
        public int ID { get; set; }

        [DisplayName("Instruction")]
        public string Instruction { get; set; }

        public InstructionModel(string Instruction)
        {
            this.Instruction = Instruction;
        }

        public InstructionModel() { }
    }
}
