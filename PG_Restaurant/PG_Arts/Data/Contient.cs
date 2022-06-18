using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PG_Arts.Data
{
    public class Contient
    {
       
        [Key]
        [Column(Order =1)]
        public int num_cmd { get; set; }
        //public Commande Commande { get; set; }
        [Key]
        [Column(Order = 2)]
        public int code_plat { get; set; }
        //public Plat Plat { get; set; }
        public int quantite { get; set; }
        
    }
}