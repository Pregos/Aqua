using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Czujniki
    {
        public Czujniki()
        {
            Pomiary = new HashSet<Pomiary>();
        }

        public int Idczujnika { get; set; }
        public int? Idakwarium { get; set; }
        public string TypHardware { get; set; }
        public string CoMierzy { get; set; }
        public string Opis { get; set; }

        public ICollection<Pomiary> Pomiary { get; set; }
    }
}
