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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CommandeCrud commandeCrud = new CommandeCrud();
        Commande commande = new Commande();

        public static int num;
        PlatCrud platCrud = new PlatCrud();
        Plat plat = new Plat();
        public int code_plat;
        ContientCrud contientCrud = new ContientCrud();
        Contient contient= new Contient();
        private void ChargerPlat()
         {
             var lst = platCrud.Plats();
             grd2.DataSource = lst;
         }
        private void chargerDonnee()
        {
            List<string> Data = new List<string>();

            Data.Add("Carte Bancaire");
            Data.Add("Titre-Restaurante");
            Data.Add("espèces");
            Data.Add("chèque");

            foreach (var item in Data)
            {
                comboBox1.Items.Add(item);
            }

           
            }

        public void chargerContenu()
        {
            var lst = contientCrud.Contenu(num);
            //var lst = contientCrud.Contenu();
            grd1.DataSource = lst;
           // MessageBox.Show("hello numeo" +num);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
            ChargerPlat();
            chargerDonnee();
            chargerContenu();

            //Commande cmd = commandeCrud.GetCommande(num);
            //if (cmd.mode_paiement == null)
            //{
            //    paiementPanel.Show();
            //}
            //else
            //{
            //    paiementPanel.Hide();
            //    facturePanel.Show();
            //}

        }

        private void grd2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = contientCrud.Contenu();
            // MessageBox.Show("wach list null" + (lst == null));
            int p = 0;
            if (lst.Count != 0)
            {
                foreach (var item in lst)
                {
                    //MessageBox.Show("hello forech");
                    if (item.num_cmd == num && item.code_plat == contient.code_plat)
                    {
                        //MessageBox.Show("hello forif");
                        if (item.quantite >= 1)
                        {
                            contient.quantite = item.quantite + 1;
                            contientCrud.Modifier(contient);
                            p = 1;
                        }

                    }
                }
                if (p == 0)
                {

                    //MessageBox.Show("hello 2");
                    contient.quantite = 1;
                    contientCrud.CreerContient(contient);
                }
            }
            else
            {
                // MessageBox.Show("hello 2");
                contient.quantite = 1;
                contientCrud.CreerContient(contient);
            }

            //MessageBox.Show("hello3");
            chargerContenu();
        }

        private void grd2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("le Plat numero :" + Convert.ToInt32(grd2.CurrentRow.Cells["code_plat"].Value.ToString()) + "   est selectionné");
            contient.code_plat = Convert.ToInt32(grd2.CurrentRow.Cells["code_plat"].Value.ToString());
            contient.num_cmd = num;
            //contientCrud.CreerContient(contient);
        }

     

       

       /* private void Payer_Click(object sender, EventArgs e)
        {
            commande = commandeCrud.Commande(num);
            commande.mode_paiement = comboBox1.SelectedItem.ToString();
            commande.heure_paiement = DateTime.Now.ToLocalTime().ToString();
            commandeCrud.Modifier(commande);

            var ls = commandeCrud.Commande();
            //facturePanel.Show();
            supprimerPanel.Hide();
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.Show();
            //dataSource = ls;
            UserControl5.grd11.DataSource = ls;
            MessageBox.Show("Le payement a été bien effectué !");
        }*/

      /*  private void Supprimer_Click(object sender, EventArgs e)
        {
            commandeCrud.Delete(num);
            var ls = commandeCrud.Commande();
            UserControl5.grd11.DataSource = ls;
            this.Hide();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            commande = commandeCrud.Commande(num);
            commande.mode_paiement = comboBox1.SelectedItem.ToString();
            commande.heure_paiement = DateTime.Now.ToLocalTime().ToString();
            commandeCrud.Modifier(commande);

            var ls = commandeCrud.Commande();
            //facturePanel.Show();
            supprimerPanel.Hide();
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.Show();
            //dataSource = ls;
            UserControl5.grd11.DataSource = ls;
            MessageBox.Show("Le payement a été bien effectué !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            commandeCrud.Delete(num);
            var ls = commandeCrud.Commande();
            UserControl5.grd11.DataSource = ls;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lst = contientCrud.Contenu();
            // MessageBox.Show("wach list null" + (lst == null));
            int p = 0;
            if (lst.Count != 0)
            {
                foreach (var item in lst)
                {
                    //MessageBox.Show("hello forech");
                    if (item.num_cmd == num && item.code_plat == contient.code_plat)
                    {
                        //MessageBox.Show("hello forif");
                        if (item.quantite >= 1)
                        {
                            contient.quantite = item.quantite + 1;
                            contientCrud.Modifier(contient);
                            p = 1;
                        }

                    }
                }
                if (p == 0)
                {

                    //MessageBox.Show("hello 2");
                    contient.quantite = 1;
                    contientCrud.CreerContient(contient);
                }
            }
            else
            {
                // MessageBox.Show("hello 2");
                contient.quantite = 1;
                contientCrud.CreerContient(contient);
            }

            //MessageBox.Show("hello3");
            chargerContenu();
        }
    }
}
