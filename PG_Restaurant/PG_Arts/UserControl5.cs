using PG_Arts.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG_Arts
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
            ChargerCommande();
          
        }
        TableCrud tableCrud = new TableCrud();
        PlatCrud platCrud = new PlatCrud();
        Plat plat = new Plat();
        public  int code_plat;
       /* private void ChargerPlat()
        {
            var lst = platCrud.Plats();
            grd2.DataSource = lst;
        }*/

        CommandeCrud commandeCrud = new CommandeCrud();
        Commande commande = new Commande();
        public static int num_cmd;
        
        private  void ChargerCommande()
        {
            var ls = commandeCrud.Commande();

            grd11.DataSource = ls;
            //MessageBox.Show(ls.ToString());
        }
        private void chargerDonnee()
        {
           

            var lst2 = tableCrud.Tables();

            if (lst2 != null)
            {
                foreach (var item in lst2)
                {
                        comboBox1.Items.Add("N°: "+ item.num_tab +" Nombre de places:" +item.nb_place);
                }
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void heurePaiement_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            //ChargerPlat();
           ChargerCommande();
            chargerDonnee();
            //panel1.Hide();
        }

        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || nbP.Text == string.Empty)
            {
                MessageBox.Show("Veillez Remplir  toutes les Champs ");
            }
            else
            {
                char[] separators = new char[] { ' ' };
                string[] tab = comboBox1.SelectedItem.ToString().Split(separators);
               // MessageBox.Show("Veillez Remplir  toutes les Champs " + tab[1]);
                commande.num_tab = Convert.ToInt32(tab[1]);
                //commande.mode_paiement = comboBox2.SelectedItem.ToString();
                //commande.heure_paiement = DateTime.Now.ToLocalTime().ToString();
                commande.nb_personnes = Convert.ToInt32(nbP.Text.ToString());
                commande.date_com = DateTime.Now;
                commandeCrud.CreerCommande(commande);
                ChargerCommande();
            }
          
        }

  

        private void grd11_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            num_cmd = Convert.ToInt32(grd11.CurrentRow.Cells["num_cmd"].Value.ToString());
           // MessageBox.Show(""+num_cmd);
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Commande cmd = commandeCrud.GetCommande(num_cmd);
            if (cmd.mode_paiement == null)
            {
                Form2.num = num_cmd;
                Form3.num = num_cmd;
                f2.Show();
            }
            else
            {
                Form3.num = num_cmd;
                f3.Show();
              
            }
            
          



            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || nbP.Text == string.Empty)
            {
                MessageBox.Show("Veillez Remplir  toutes les Champs ");
            }
            else
            {
                char[] separators = new char[] { ' ' };
                string[] tab = comboBox1.SelectedItem.ToString().Split(separators);
                MessageBox.Show("Veillez Remplir  toutes les Champs " + tab[1]);
                commande.num_tab = Convert.ToInt32(tab[1]);
                //commande.mode_paiement = comboBox2.SelectedItem.ToString();
                //commande.heure_paiement = DateTime.Now.ToLocalTime().ToString();
                commande.nb_personnes = Convert.ToInt32(nbP.Text.ToString());
                commande.date_com = DateTime.Now;
                commandeCrud.CreerCommande(commande);
                ChargerCommande();
            }
        }
    }
}
