using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Zerowanie
    {
        public Zerowanie()
        {
            Ryb2Zerowanie = new HashSet<Ryb2Zerowanie>();
        }

        public int Idzerowanie { get; set; }
        public string Zerowanie1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Zerowanie> Ryb2Zerowanie { get; set; }
    }
}
