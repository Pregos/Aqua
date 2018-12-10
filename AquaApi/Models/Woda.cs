using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Woda
    {
        public Woda()
        {
            Ryb2Woda = new HashSet<Ryb2Woda>();
        }

        public int Idwoda { get; set; }
        public string Woda1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Woda> Ryb2Woda { get; set; }
    }
}
