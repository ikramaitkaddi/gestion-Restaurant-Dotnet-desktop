using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PG_Arts.Data
{
    public class Affecter
    {
       
       //public int Id { get; set; }
        [Key]
        [Column(Order =1)]
        public int num_srv { get; set; }
        //public Serveur Serveur{ get; set; }
        [Key]
        [Column(Order = 2)]
        public int num_tab { get; set; }
        //public Table Table { get; set; }
        public DateTime date_affect { get; set; }
         //public virtual Table table { get; set; }
         //public virtual Serveur serveur { get; set; }

    }
}