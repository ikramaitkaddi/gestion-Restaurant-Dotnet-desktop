using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PG_Arts.Data
{
    public class Serveur
    {
        [Key]
        public int num_srv { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        //public IList<Affecter> Affecter { get; set; }

    }
}