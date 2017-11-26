using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuharica_ikkj
{
    class Recept
    {
        public string Name { get; set;}
        public string Ingredient { get; set;}
        public string PreparationTime { get; set;}
        public string Course { get; set;}

        public Recept (string name, string ingredient, string preptime, string course)
        {
            this.Name = name;
            this.Ingredient = ingredient;
            this.PreparationTime = preptime;
            this.Course = course;
        }

        private void EmptyTextBox1 (string name, string ingredient, string preptime, string course)
        {
            name = string.Empty;
            ingredient = string.Empty;
            preptime = string.Empty;
            course = string.Empty;
        }


    }
}
