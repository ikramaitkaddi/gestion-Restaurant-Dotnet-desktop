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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        TableCrud tableCrud = new TableCrud();
        Table table = new Table();
        public int num_tab;
        private void ChargerList()
        {
            var lst = tableCrud.Tables();
            grd1.DataSource = lst;
        }
       
       

    private void reset()
    {
        num.Text = string.Empty;
        place.Text = string.Empty;
    }
        private void ajouter()
        {
            table.num_tab = Convert.ToInt32(num.Text);
            table.nb_place = Convert.ToInt32(place.Text);
        }
    private void button1_Click(object sender, EventArgs e)
        {
            
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.num_tab > 0)
            {
                
                tableCrud.Delete(this.num_tab);
                reset();
                ChargerList();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.num_tab > 0)
            {
               
                table.num_tab = Convert.ToInt32(num.Text);
                table.nb_place = Convert.ToInt32(place.Text);
              
                tableCrud.Modifier(table);
                reset();
                ChargerList();
                
            }
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            ChargerList();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            num_tab = Convert.ToInt32(grd1.CurrentRow.Cells["num_tab"].Value.ToString());
            num.Text = grd1.CurrentRow.Cells["num_tab"].Value.ToString();
            place.Text = grd1.CurrentRow.Cells["nb_place"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numChercher.Text != string.Empty)
            {
                var lst = tableCrud.Tables(Convert.ToInt32(numChercher.Text));
                grd1.DataSource = lst;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ajouter();
            tableCrud.CreerTable(table);
            reset();
            ChargerList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.num_tab > 0)
            {

                tableCrud.Delete(this.num_tab);
                reset();
                ChargerList();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.num_tab > 0)
            {

                table.num_tab = Convert.ToInt32(num.Text);
                table.nb_place = Convert.ToInt32(place.Text);

                tableCrud.Modifier(table);
                reset();
                ChargerList();

            }
        }

        private void chercher_Click(object sender, EventArgs e)
        {
            if (numChercher.Text != string.Empty)
            {
                var lst = tableCrud.Tables(Convert.ToInt32(numChercher.Text));
                grd1.DataSource = lst;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
