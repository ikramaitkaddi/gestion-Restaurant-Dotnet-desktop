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
    internal class TableCrud
    {     
        DB db;
        public void CreerTable(Table table) {
            try
            {
                using (db = new DB())
                {
                    db.Tables.Add(table);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public List<Table> Tables()
        {
            try
            {
                using (db = new DB())
                {
                    return db.Tables.OrderBy(x => x.num_tab).ToList();
                    
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
        public void  Delete(int num_tab)
        {
            try
            {
                using (db = new DB())
                {
                    db.Tables.Remove(db.Tables.Single(p => p.num_tab == num_tab));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public List<Table> Tables(int num_tab)
        {
            try
            {
                using (db = new DB())
                {
                    return db.Tables.Where(p=> p.num_tab== num_tab).ToList();
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
