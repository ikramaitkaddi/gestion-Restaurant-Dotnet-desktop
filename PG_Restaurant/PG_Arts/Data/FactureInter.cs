using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG_Arts.Data
{
    internal class FactureInter
    {
        [Key]
        public int num_cmd { get; set; }
        public int num_tab { get; set; }
        public DateTime date_com { get; set; }
        public int nb_personnes { get; set; }
        public string heure_paiement { get; set; }
        public string mode_paiement { get; set; }
        public string nomServeur { get; set; }
        public string prenomServeur { get; set; }
        public string libelle { get; set; }
        public string type_plat { get; set; }
        public double prix { get; set; }
        public int quantite { get; set; }

    }
}


