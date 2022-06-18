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
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
            ChargerList();
        }
        ServeurCrud serveurCrud = new ServeurCrud();
        Serveur serveur= new Serveur();
        public int num_srv;
        private void ChargerList()
        {
            var lst = serveurCrud.Serveurs();
            grd1.DataSource = lst;
        }

        private void ajouter()
        {
            serveur.nom = nom.Text;
            serveur.prenom = Prenom.Text;
        }

        private void reset()
        {
            nom.Text = string.Empty;
            Prenom.Text = string.Empty;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            ChargerList();
        }


        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            num_srv = Convert.ToInt32(grd1.CurrentRow.Cells["num_srv"].Value.ToString());
            nom.Text = grd1.CurrentRow.Cells["nom"].Value.ToString();
            Prenom.Text = grd1.CurrentRow.Cells["Prenom"].Value.ToString();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            ajouter();
            serveurCrud.CreerServeur(serveur);
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.num_srv > 0)
            {
               
                serveurCrud.Delete(this.num_srv);
                reset();
                ChargerList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajouter();
            serveurCrud.CreerServeur(serveur);
            reset();
            ChargerList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.num_srv > 0)
            {
                serveur.num_srv = this.num_srv;
                serveur.nom = nom.Text;
                serveur.prenom = Prenom.Text;
                serveurCrud.Update(serveur);
                reset();
                ChargerList();
                MessageBox.Show(serveur.num_srv.ToString());
            }
        }

        private void chercher_Click(object sender, EventArgs e)
        {
            if (num.Text != string.Empty)
            {
                var lst = serveurCrud.ServeurNom(num.Text);
                grd1.DataSource = lst;
            }
            else
            {
                ChargerList();
            }
        }
    }
}
