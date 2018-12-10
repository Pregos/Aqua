using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Rodzina
    {
        public Rodzina()
        {
            Ryb2Rodzina = new HashSet<Ryb2Rodzina>();
        }

        public int Idrodzina { get; set; }
        public string Rodzina1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Rodzina> Ryb2Rodzina { get; set; }
    }
}
