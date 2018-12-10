using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Akwaria
    {
        public Akwaria()
        {
            Pomiary = new HashSet<Pomiary>();
        }

        public int Idakwarium { get; set; }
        public int? Idklienta { get; set; }
        public string Opis { get; set; }

        public Klienci IdklientaNavigation { get; set; }
        public ICollection<Pomiary> Pomiary { get; set; }
    }
}
