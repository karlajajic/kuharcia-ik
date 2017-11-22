using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //da možemo javiti grešku kod registracije 

namespace kuharica_ikkj
{
    class Login
    {
        public string Username { get; set; }
        public string UserPassword { get; set; }

        public Login (string user, string pass)
        {
            this.Username = user;
            this.UserPassword = pass;
        }

        private void EmptyTextBox (string user, string pass) //čisti polja u kojima se piše
        {
            user = String.Empty;
            pass = String.Empty;
        }

        internal bool LoggedIn(string user, string pass)
        {
            if (string.IsNullOrEmpty(user)) //provjeravamo postojanost korisničkog imena
            {
                MessageBox.Show("Unesite korisničko ime!");
                return false;
            }
            else
            {
                if (Username != user)  //provjeravamo valjanost korisničkog imena
                {
                    MessageBox.Show("Neispravno korisničko ime!");
                    EmptyTextBox(user, pass);
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(pass)) //provjeravamo postojanost lozinke
                    {
                        MessageBox.Show("Unesite lozinku!");
                        return false;
                    }
                    else if (UserPassword !=pass)  //provjeravamo valjanost lozinke
                    {
                        MessageBox.Show("Neispravna lozinka!");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
