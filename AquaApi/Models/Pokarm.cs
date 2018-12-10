using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Pokarm
    {
        public Pokarm()
        {
            Ryb2Pokarm = new HashSet<Ryb2Pokarm>();
        }

        public int Idpokarm { get; set; }
        public string Pokarm1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Pokarm> Ryb2Pokarm { get; set; }
    }
}
