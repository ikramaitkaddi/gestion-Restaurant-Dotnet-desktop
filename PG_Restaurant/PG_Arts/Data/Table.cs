using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PG_Arts.Data
{
    public class Table
    {
        [Key]
        public int num_tab { get; set; }
        public int nb_place { get; set; }
        //public IList<Affecter> Affecter { get; set; }
    }
}