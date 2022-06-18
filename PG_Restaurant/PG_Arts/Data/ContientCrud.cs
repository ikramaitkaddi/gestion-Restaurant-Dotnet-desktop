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
    internal class ContientCrud
    {     
        DB db;
        public void CreerContient(Contient contient) {
            try
            {
                using (db = new DB())
                {
                    db.Contenu.Add(contient);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public List<Contient> Contenu()
        {
            try
            {
                using (db = new DB())
                {
                    return db.Contenu.ToList();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Contient> Contenu(int num_cmd)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Contenu.Where(p => p.num_cmd == num_cmd).ToList();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Modifier(Contient contient)
        {
            try
            {
                using (db = new DB())
                {
                    db.Contenu.Attach(contient);
                    db.Entry(contient).State = EntityState.Modified;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public Plat getPlat(int code_plat)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Plats.Where(p => p.code_plat == code_plat).FirstOrDefault();
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
