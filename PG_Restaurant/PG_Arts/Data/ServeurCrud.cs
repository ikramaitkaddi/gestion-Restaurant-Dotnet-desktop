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
    internal class ServeurCrud
    {     
        DB db;
        public void CreerServeur(Serveur serveur) {
            try
            {
                using (db = new DB())
                {
                    db.Serveurs.Add(serveur);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public List<Serveur> Serveurs()
        {
            try
            {
                using (db = new DB())
                {
                    return db.Serveurs.OrderBy(x => x.num_srv).ToList();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Update(Serveur serveur)
        {
            try
            {
                using (db = new DB())
                {
                    db.Serveurs.Attach(serveur);
                    db.Entry(serveur).State = EntityState.Modified;
                    //db.Serveurs.AddOrUpdate(serveur);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public void  Delete(int num_srv)
        {
            try
            {
                using (db = new DB())
                {
                    db.Serveurs.Remove(db.Serveurs.Single(p => p.num_srv == num_srv));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public List<Serveur> Serveurs(int num_srv)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Serveurs.Where(p=> p.num_srv== num_srv).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Serveur> ServeurNom(String nom)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Serveurs.Where(p => p.nom.Contains(nom)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public int ServNom(String nom)
        {
            try
            {
                using (db = new DB())
                {
                  Serveur srv = db.Serveurs.Where(p => p.nom.Contains(nom)).FirstOrDefault();
                    if( srv !=null) {
                        return srv.num_srv;
                    }
                    
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}
