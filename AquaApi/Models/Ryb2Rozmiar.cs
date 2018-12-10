using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Rozmiar
    {
        public int Idrybka { get; set; }
        public int Idrozmiar { get; set; }

        public Rozmiar IdrozmiarNavigation { get; set; }
        public Rybki IdrybkaNavigation { get; set; }
    }
}
