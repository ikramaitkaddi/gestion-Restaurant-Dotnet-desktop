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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
            chargerDonnee();
        }
        ServeurCrud serveurCrud = new ServeurCrud();
        Serveur serveur = new Serveur();
        TableCrud tableCrud = new TableCrud();
        Table table = new Table();

        AffecterCrud affecterCrud = new AffecterCrud();
        Affecter affecter = new Affecter();

        private void UserControl4_Load(object sender, EventArgs e)
        {
           

            // suprimer si plus de 1 jour 
           var lst = affecterCrud.Affectations();

               if(  lst != null){
               foreach (var item in lst)
               {
                  //MessageBox.Show("la date de cette affectation est :" + DateTime.Compare(item.date_affect.Date, DateTime.Now.Date));
                   if (DateTime.Compare(item.date_affect.Date, DateTime.Now.Date) < 0)
                   {
                       affecterCrud.Delete(item.num_srv, item.num_tab);
                   }
               }}
            Charger();
        }



        private void chargerDonnee()
        {
            var lst = serveurCrud.Serveurs();
            if (lst != null)
            {
                foreach (var item in lst)
                {
                    comboBox2.Items.Add(item.nom + " " + item.prenom);
                }
            }
            var lst2 = tableCrud.Tables();
            if (lst2 != null)
            {
               

                foreach (var item in lst2)
                {
                    comboBox1.Items.Add(item.num_tab);
                }
            }

            
        }

        private void Charger()
        {
            var af = affecterCrud.Affectations();
            if (af != null)
            {

                DataTable table = new DataTable();

                table.Columns.Add("Nom", Type.GetType("System.String"));
                table.Columns.Add("Prénom", Type.GetType("System.String"));
                table.Columns.Add("num Table", Type.GetType("System.String"));
                table.Columns.Add("Date affect", Type.GetType("System.DateTime"));

                DataRow Row;

                foreach (var item in af)
                {
                    String nomSrv = affecterCrud.getNomSRV(item.num_tab);
                    String prenomSrv = affecterCrud.getPrenomSRV(item.num_tab);
                    Row = table.NewRow();

                    Row["Nom"] = nomSrv;
                    Row["Prénom"] = prenomSrv;
                    Row["num Table"] = item.num_tab;
                    Row["Date affect"] = item.date_affect;


                    table.Rows.Add(Row);

                }
                grd1.DataSource = table;


            }
        }
      

        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Affecter_Click_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null) { 
            char[] separators = new char[] { ' ' };
            string[] tab = comboBox2.SelectedItem.ToString().Split(separators);
            //MessageBox.Show(tab[0] + "......." + tab[1]);

            //MessageBox.Show("srv" + affecter.num_srv);
            int p = 0;
            var lst = affecterCrud.Affectations();
            foreach (var item in lst)
            {
                if (item.num_tab == Convert.ToInt32(comboBox1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Un serveur est déja affecter à cette table");
                    p = 1;
                }

            }
                if (p == 0)
                {
                    affecter.num_srv = serveurCrud.ServNom(tab[0]);
                    affecter.num_tab = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    affecter.date_affect = DateTime.Now.Date;
                    MessageBox.Show("la date de cette affectation est :" + affecter.date_affect.ToShortDateString());
                    affecterCrud.CreerAffectation(affecter);
                    Charger();
                }
               
            }
            else
            {
                MessageBox.Show("Veillier remplir toutes les champs !");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
           
            char[] separators = new char[] { ' ' };
            string[] tab = comboBox2.SelectedItem.ToString().Split(separators);
           int  num_srv = serveurCrud.ServNom(tab[0]);
            affecterCrud.Delete(num_srv, Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            Charger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                char[] separators = new char[] { ' ' };
                string[] tab = comboBox2.SelectedItem.ToString().Split(separators);
                //MessageBox.Show(tab[0] + "......." + tab[1]);

                //MessageBox.Show("srv" + affecter.num_srv);
                int p = 0;
                var lst = affecterCrud.Affectations();
                foreach (var item in lst)
                {
                    if (item.num_tab == Convert.ToInt32(comboBox1.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Un serveur est déja affecter à cette table");
                        p = 1;
                    }

                }
                if (p == 0)
                {
                    affecter.num_srv = serveurCrud.ServNom(tab[0]);
                    affecter.num_tab = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                    affecter.date_affect = DateTime.Now.Date;
                    MessageBox.Show("la date de cette affectation est :" + affecter.date_affect.ToShortDateString());
                    affecterCrud.CreerAffectation(affecter);
                    Charger();
                }

            }
            else
            {
                MessageBox.Show("Veillier remplir toutes les champs !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] separators = new char[] { ' ' };
            string[] tab = comboBox2.SelectedItem.ToString().Split(separators);
            int num_srv = serveurCrud.ServNom(tab[0]);
            affecterCrud.Delete(num_srv, Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            Charger();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
