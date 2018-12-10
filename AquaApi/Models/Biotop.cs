using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Biotop
    {
        public Biotop()
        {
            Ryb2Biotop = new HashSet<Ryb2Biotop>();
        }

        public int Idbiotop { get; set; }
        public string Biotop1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Biotop> Ryb2Biotop { get; set; }
    }
}
