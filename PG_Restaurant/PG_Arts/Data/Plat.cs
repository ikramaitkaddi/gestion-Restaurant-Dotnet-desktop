using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;

namespace PG_Arts.Data
{
    public class Plat
    {
        [Key]
        public int code_plat { get; set; }
        public string libelle { get; set; }
        public string type_plat { get; set; }
        public double prix { get; set; }
     
        //public IList<Contient> Contient { get; set; }
        [NotMapped]
        public Image Picture
        {
            get
            {
                if(!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                        return Image.FromFile(path);
                }
                return null;
            }
        }
      
        public string path { get; set; }

    }
}