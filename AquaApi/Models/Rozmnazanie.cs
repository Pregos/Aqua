using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Rozmnazanie
    {
        public Rozmnazanie()
        {
            Ryb2Rozmnazanie = new HashSet<Ryb2Rozmnazanie>();
        }

        public int Idrozmnazanie { get; set; }
        public string Rozmnazanie1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Rozmnazanie> Ryb2Rozmnazanie { get; set; }
    }
}
