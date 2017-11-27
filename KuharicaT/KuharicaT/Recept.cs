using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuharicaT
{
    class Recept
    {
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string PreparationTime { get; set; }
        public string Course { get; set; }
        public string Preparation { get; set; }

        public Recept(string name, string ingredient, string preptime, string cousre, string preparation) //konstruktor
        {
            this.Name = name;
            this.Ingredient = ingredient;
            this.PreparationTime = preptime;
            this.Course = cousre;
            this.Preparation = preparation;
        }

        internal bool UnosR(string name, string ingredient, string preptime, string preparation) //sluzi za provjeru unosa
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ingredient) || string.IsNullOrEmpty(preptime) || string.IsNullOrEmpty(preparation)) //provjeravamo postojanost
            {
                MessageBox.Show("Popunite sva polja!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()  //metoda
        {
            return Name + ", " + Course;
        }
    }
}
