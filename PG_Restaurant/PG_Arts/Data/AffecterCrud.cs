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
    internal class AffecterCrud
    {     
        DB db;
        public void CreerAffectation(Affecter affecter) {
            try
            {
                using (db = new DB())
                {

                    var af = db.Affectation.Where(p =>p.num_tab == affecter.num_tab && p.num_srv == affecter.num_srv);
                    if(af.FirstOrDefault() == null)
                    {
                    db.Affectation.Add(affecter);
                        db.SaveChanges();
                   }
                   else
                   {
                       MessageBox.Show("Cette Affectation  existe déja" );
                   }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public List<Affecter> Affectations()
        {
            try
            {
                using (db = new DB())
                {
                    return db.Affectation.ToList();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Modifier(Table table)
        {
            try
            {
                using (db = new DB())
                {
                    db.Tables.Attach(table);
                    db.Entry(table).State = EntityState.Modified;
                    
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public void  Delete(int num_srv, int num_tab)
        {
            try
            {
                using (db = new DB())
                {
                    db.Affectation.Remove(db.Affectation.Single(p =>( p.num_tab == num_tab && p.num_srv == num_srv)));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public String getNomSRV(int num_tab)
        {
            try
            {
                using (db = new DB())
                {
                   Affecter af=  db.Affectation.Where(p => p.num_tab == num_tab).FirstOrDefault();
                   Serveur srv = db.Serveurs.Where(p => p.num_srv == af.num_srv).FirstOrDefault();
                    if (srv == null) return null;
                    return srv.nom;


                }
            }
            catch (Exception ex)
            {
                
                    return null;
            }
        }
        public String getPrenomSRV(int num_tab)
        {
            try
            {
                using (db = new DB())
                {
                  //Affecter af = db.Affectation.Where(p => p.num_tab == num_tab).FirstOrDefault();
                 // Serveur srv = db.Serveurs.Where(p => p.num_srv == af.num_srv).FirstOrDefault();


                    var srv =
                   (from a in db.Affectation
                    join s in db.Serveurs on a.num_srv equals s.num_srv
                    where a.num_tab == num_tab
                    select s).FirstOrDefault();
                    if (srv == null) return null;
                    return srv.prenom;


                }
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }
        


    }
}
