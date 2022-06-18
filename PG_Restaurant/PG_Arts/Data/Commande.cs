using System.ComponentModel.DataAnnotations;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PG_Arts.Data
{
    public class Commande
    {
        [Key]
    
        public int num_cmd{ get; set; }
       
        public int num_tab { get; set; }
        public DateTime date_com { get; set; }
        public int nb_personnes { get; set; }
        public string heure_paiement { get; set; }
        public string mode_paiement { get; set; }
        //public IList<Contient> Contient { get; set; }

    }
}