using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Klienci
    {
        public Klienci()
        {
            Akwaria = new HashSet<Akwaria>();
        }

        public int Idklienta { get; set; }
        public string Nazwa { get; set; }

        public ICollection<Akwaria> Akwaria { get; set; }
    }
}
