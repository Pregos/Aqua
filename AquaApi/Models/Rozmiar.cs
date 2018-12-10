using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Rozmiar
    {
        public Rozmiar()
        {
            Ryb2Rozmiar = new HashSet<Ryb2Rozmiar>();
        }

        public int Idrozmiar { get; set; }
        public string Rozmiar1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Rozmiar> Ryb2Rozmiar { get; set; }
    }
}
