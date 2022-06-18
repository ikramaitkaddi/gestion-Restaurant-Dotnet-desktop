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
    internal class PlatCrud
    {     
        DB db;
        public void CreerPlat(Plat plat) {
            try
            {
                using (db = new DB())
                {
                    db.Plats.Add(plat);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public List<Plat> Plats()
        {
            try
            {
                using (db = new DB())
                {
                    return db.Plats.OrderBy(x => x.code_plat).ToList();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Modifier(Plat plat)
        {
            try
            {
                using (db = new DB())
                {
                    db.Plats.Attach(plat);
                    db.Entry(plat).State = EntityState.Modified;
                    
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public void  Delete(int code_plat)
        {
            try
            {
                using (db = new DB())
                {
                    db.Plats.Remove(db.Plats.Single(p => p.code_plat == code_plat));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public List<Plat> Plats(int code_plat)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Plats.Where(p=> p.code_plat== code_plat).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Plat getPlat(String libelle)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Plats.Where(p => p.libelle == libelle).FirstOrDefault();
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
