using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Akwarium
    {
        public Akwarium()
        {
            Ryb2Akwarium = new HashSet<Ryb2Akwarium>();
        }

        public int Idakwarium { get; set; }
        public string Akwarium1 { get; set; }
        public string Opis { get; set; }

        public ICollection<Ryb2Akwarium> Ryb2Akwarium { get; set; }
    }
}
