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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        PlatCrud platCrud = new PlatCrud();
        Plat plat = new Plat();
        public int code_plat;
        private void ChargerList()
        {

            var lst = platCrud.Plats(); ;
            if (lst != null)
            {


               grd1.DataSource = lst;
            }
        }

        private void chargerDonnee()
        {
            List<string> Data = new List<string>();

            Data.Add("Entrée");
            Data.Add("Boisson");
            Data.Add("Dessert");
            Data.Add("Viande");
            Data.Add("Poisson");
            Data.Add("Plat Principale");
            Data.Add("Sandwichs");
            Data.Add("Soupes");
            Data.Add("Déjeuner");
            Data.Add("Salade");

            foreach (var item in Data)
            {
                typePlat.Items.Add(item);
            }


        }

        private void reset()
        {
            libelle.Text = string.Empty;
            typePlat.Text = string.Empty;
            prix.Text = string.Empty;
        }
        private void ajouter()
        {
            plat.libelle = libelle.Text;
            plat.type_plat = typePlat.Text;
            plat.prix = Convert.ToDouble(prix.Text);
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {

            ajouter();
            platCrud.CreerPlat(plat);
            Plat p = platCrud.getPlat(plat.libelle);
            //string pathstring;
            if (pictureBox1 != null && pictureBox1.Image!= null)
            {
                //string fname = code + ".jpg";
                //string folder = ".\\PG_Arts\\Images";
                //pathstring = System.IO.Path.Combine(folder, fname);
                MessageBox.Show(""+p.code_plat);
                plat.path = "../../Images/" + p.code_plat + ".jpg";
                //Image a = pictureBox1.Image;
                //a.Save(pathstring);

                try
                {
                    using (Bitmap bmb = (Bitmap)pictureBox1.Image.Clone())
                    {
                        bmb.Save("../../Images/" + p.code_plat + ".jpg", bmb.RawFormat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veillez  choisir un format valide pour l'image !");
                }


            }
            else
            {
                MessageBox.Show("Choisir une Image pour le Plat");
            }
            platCrud.Modifier(plat);

            reset();
            ChargerList();
        }
       

        private void UserControl3_Load(object sender, EventArgs e)
        {
            ChargerList();
            chargerDonnee();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (this.code_plat > 0)
            {
                platCrud.Delete(this.code_plat);
                reset();
                ChargerList();
            }
        }

        private void grd1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            code_plat = Convert.ToInt32(grd1.CurrentRow.Cells["code_plat"].Value.ToString());
            typePlat.Text = grd1.CurrentRow.Cells["type_plat"].Value.ToString();
            libelle.Text = grd1.CurrentRow.Cells["libelle"].Value.ToString();
            prix.Text = grd1.CurrentRow.Cells["prix"].Value.ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (this.code_plat > 0)
            {
                if (pictureBox1 != null && pictureBox1.Image != null)
                {
                    //string fname = code + ".jpg";
                    //string folder = ".\\PG_Arts\\Images";
                    //pathstring = System.IO.Path.Combine(folder, fname);
                    MessageBox.Show("" +this.code_plat);
                    plat.path = "../../Images/" + this.code_plat + ".jpg";
                    //Image a = pictureBox1.Image;
                    //a.Save(pathstring);

                    try
                    {
                        using (Bitmap bmb = (Bitmap)pictureBox1.Image.Clone())
                        {
                            bmb.Save("../../Images/" + this.code_plat + ".jpg", bmb.RawFormat);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veillez  choisir un format valide pour l'image !");
                    }


                }
                else
                {
                    MessageBox.Show("Choisir une Image pour le Plat");
                }
                plat.code_plat = this.code_plat;
                //table.num_tab = Convert.ToInt32(num.Text);
                plat.type_plat = typePlat.Text;
                plat.libelle = libelle.Text;
                plat.prix = Convert.ToDouble(prix.Text);

                platCrud.Modifier(plat);
                reset();
                ChargerList();

            }
        }

        private void Chercher_Click(object sender, EventArgs e)
        {
            if (codePlat.Text != string.Empty)
            {
                var lst = platCrud.Plats(Convert.ToInt32(codePlat.Text));
                grd1.DataSource = lst;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.bmp;*.png;)| *.jpg; *.jpeg; *.bmp; *.png; ";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void libelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ajouter();
            platCrud.CreerPlat(plat);
            Plat p = platCrud.getPlat(plat.libelle);
            //string pathstring;
            if (pictureBox1 != null && pictureBox1.Image != null)
            {
                //string fname = code + ".jpg";
                //string folder = ".\\PG_Arts\\Images";
                //pathstring = System.IO.Path.Combine(folder, fname);
                MessageBox.Show("" + p.code_plat);
                plat.path = "../../Images/" + p.code_plat + ".jpg";
                //Image a = pictureBox1.Image;
                //a.Save(pathstring);

                try
                {
                    using (Bitmap bmb = (Bitmap)pictureBox1.Image.Clone())
                    {
                        bmb.Save("../../Images/" + p.code_plat + ".jpg", bmb.RawFormat);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veillez  choisir un format valide pour l'image !");
                }


            }
            else
            {
                MessageBox.Show("Choisir une Image pour le Plat");
            }
            platCrud.Modifier(plat);

            reset();
            ChargerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.code_plat > 0)
            {
                platCrud.Delete(this.code_plat);
                reset();
                ChargerList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.code_plat > 0)
            {
                if (pictureBox1 != null && pictureBox1.Image != null)
                {
                    //string fname = code + ".jpg";
                    //string folder = ".\\PG_Arts\\Images";
                    //pathstring = System.IO.Path.Combine(folder, fname);
                    MessageBox.Show("" + this.code_plat);
                    plat.path = "../../Images/" + this.code_plat + ".jpg";
                    //Image a = pictureBox1.Image;
                    //a.Save(pathstring);

                    try
                    {
                        using (Bitmap bmb = (Bitmap)pictureBox1.Image.Clone())
                        {
                            bmb.Save("../../Images/" + this.code_plat + ".jpg", bmb.RawFormat);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veillez  choisir un format valide pour l'image !");
                    }


                }
                else
                {
                    MessageBox.Show("Choisir une Image pour le Plat");
                }
                plat.code_plat = this.code_plat;
                //table.num_tab = Convert.ToInt32(num.Text);
                plat.type_plat = typePlat.Text;
                plat.libelle = libelle.Text;
                plat.prix = Convert.ToDouble(prix.Text);

                platCrud.Modifier(plat);
                reset();
                ChargerList();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (codePlat.Text != string.Empty)
            {
                var lst = platCrud.Plats(Convert.ToInt32(codePlat.Text));
                grd1.DataSource = lst;
            }
        }

        private void codePlat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void typePlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
