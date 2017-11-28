using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuharica_finalno
{
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();
        }

        Recept[] recepti; //lista

        public void SviRecepti()
        {
            recepti = new Recept[6];

            recepti[0] = new Recept("Kajgana", "jaje, sol, ulje", "3 min", "Glavno jelo", "U posudu stavite tri jaja, razmutite ih i dodajte dvije žlice mlijeka ili vrhnja. Smjesu po želji možete posoliti i popapriti. Na prethodno ugrijano ulje ulijte mješavinu i miješajte. Pržite na laganoj vatri dok smjesa ne postane kremasta. Ako se kajgana predugo peče, previše će se stvrdnuti.", "kajgana");
            recepti[1] = new Recept("Francuska salata", "jaja, krastavci, vrhnje, majoneza, senf,sol, papar", "15 min", "Predjelo", "Skuhajte povrće za francusku(krumpir,grašak i mrkvu).Ohladite.Jaja skuhajte,pa ih narežite na kockice kao i kisele krastavce.Jaja i krastavce dodajte kuhanome povrću. Dodajte majonezu, vrhnje, senf i sok od limuna.Začinite sa soli i paprom.Promiješajte i spremite u frižider do posluživanja.Poslužite uz nareske,meso...", "francuska");
            recepti[2] = new Recept("Rafaelo loptice", "secer, maslo, kokosovo ulje, gustin, mlijeko", "30 min", "Desert", "Gustin razmutiti sa malo mlijeka, a ostatak mlijeka  kuhati sa šećerom i vanilin šećerom. Kada zakuha, umutiti gustin i pustiti da još malo lagano kuha. U ohlađenu smjesu dodati omekšani maslac i kokosovo brašno i sve dobro sjediniti mješajući. Staviti da se ohladi, a onda raditi kuglice i po želji ih puniti oljuštenim bademom.", "rafaelo_kuglice");
            recepti[3] = new Recept("Krem juha od batata i tikve", "batat, cesnjak, tikva, brasno, mlijeko", "20 min", "Predjelo", "Batat i tikvu očistiti i narezati na kockice. Na malo maslinovog ulja pržiti nasjeckan luk i češnjak dok se luk ne zastakli. Dodati tada brašno, promiješati i zaliti vodom uz miješanje pjenjačom. Dodati odmah tikvu i batat, posoliti i popapriti po ukusu, pa kuhati uz povremeno miješanje dok povrće ne omekša. Štapnim mikserom proći kroz juhu par minuta dok se povrće poptuno ne usitni. Dodati kurkumu i vrhnje, kušati i eventualno popraviti okus. Ako vam se juha u ovom trenu učini pregusta, slobodno dodajte vode koliko treba da postignete konzistenciju kakvu želite. Kratko još prokuhajte i poslužite uz krutone začinjene češnjakom i začinskim biljem.", "krem_juha");
            recepti[4] = new Recept("Makaroni sa sirom", "sir, maslac, brasno, mlijeko, makaroni, sir", "30 min", "Glavno jelo", "Makarone skuhati al dente i ocijediti. Za bechamel umak otopiti maslac, dodati brašno, promiješati pa odmah uz polagano miješanje pjenjačom doliti mlijeko. KUhati na laganoj vatri nekoliko minuta dok se umak ne zgusne. U vrući umak dodati kiesleo vrhnje i naribani sir, dobro promiješati kako bi se sir otopio. U tako napravljen bechamel sa sirom dodati prokuhane mkarone, dobro promiješati i premjsetiti u namašćenu vatrostalnu posudu. Po želji od gore možete posipati sa još malo sira, ali i bez toga će se makaroni lijepo zapeći i dobiti onu zlaćanu koricu. Peći u pećnici na 185ºC 20-25minuta.","makaroni");
            recepti[5] = new Recept("Zapečena piletina", "pileća prsa, mlijeko, brasno, sir, maslac, kiselo vrhnje", "3 min", "Glavno jelo", "Piletinu izrezati na kockice pa prepržiti na tavici na malo ulja. Zamrznuto povrće kratko blanširati u kipućoj vodi (5 min) Pomiješati piletinu i povrće i sve skupa izručiti u vatrostalnu posudu premazanu tankim slojem maslaca. Na ostatku maslaca pomiješati brašno, dodati mlijeko, pustiti da zavri pa dodati i vrhnje za kuhanje i kiselo vrhnje. Začiniti po ukusu. Pripremljenim bechamelom preliti piletinu pomiješanu s povrćem, od gore naribati sir, pa sve skupa zapeći u pećnici 30 minuta na 170ºC dok se ne vrhu ne napravi zlaćana korica. Poslužiti uz salatu po želji.", "piletina");
        }

        private void Lista()
        {
            lbPopisR.Items.Clear();

            for (int i = 0; i < recepti.Count(); i++)
            {
                lbPopisR.Items.Add(recepti[i].Name);
            }

        }
     

        private void Pregled_Load(object sender, EventArgs e)
        {
            SviRecepti();
            Lista();
        }

        private void btnDetalji_Click_1(object sender, EventArgs e)
        {
            if (lbPopisR.SelectedIndex >= 0)
            {
                for (int i = 0; i < recepti.Count(); i++)
                {
                    if (lbPopisR.SelectedIndex == i)
                    {
                        string name = recepti[i].Name;
                        string ingredient = recepti[i].Ingredient;
                        string course = recepti[i].Course;
                        string ptime = recepti[i].PreparationTime;
                        string preparation = recepti[i].Preparation;
                        string image = recepti[i].Image;

                        Detalji detaljnije = new Detalji(name, ptime, preparation, course, ingredient, image);
                        detaljnije.Show();
                        Visible = false;
                    }
                }

            }
            else
                MessageBox.Show("Odaberite recept!");
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Kuharica kuharica = new Kuharica();
            kuharica.Show();
            Visible = false;
        }
    }
}
