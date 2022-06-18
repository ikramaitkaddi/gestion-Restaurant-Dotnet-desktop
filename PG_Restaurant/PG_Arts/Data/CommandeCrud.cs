using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace PG_Arts.Data
{
    internal class CommandeCrud
    {
        DB db;
        public void CreerCommande(Commande commande)
        {
            try
            {
                using (db = new DB())
                {
                    db.Commandes.Add(commande);
                    db.SaveChanges();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public List<Commande> Commande()
        {
            try
            {
                using (db = new DB())
                {
                    //MessageBox.Show("hello" + db.Commandes.ToList());
                    return db.Commandes.OrderBy(x => x.num_cmd).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hello in list cmd" +ex.Message);
                return null;
            }
        }

        public Commande Commande(int num_cmd)
        {
            try
            {
                using (db = new DB())
                {
                    //MessageBox.Show("hello" + db.Commandes.ToList());
                    return db.Commandes.Where(p => p.num_cmd == num_cmd).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hello in list cmd" + ex.Message);
                return null;
            }
        }
        public void Modifier(Commande commande)
        {
            try
            {
                using (db = new DB())
                {
                    db.Commandes.Attach(commande);
                    db.Entry(commande).State = EntityState.Modified;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void Delete(int num_cmd)
        {
            try
            {
                using (db = new DB())
                {
                    db.Commandes.Remove(db.Commandes.Single(p => p.num_cmd == num_cmd));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public Commande GetCommande(int num_cmd)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Commandes.Where(p => p.num_cmd == num_cmd).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }

        }


    }
}
