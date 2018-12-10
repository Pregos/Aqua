using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Galeria
    {
        public int Idrybka { get; set; }
        public int Idobrazek { get; set; }

        public Rybki Idobrazek1 { get; set; }
        public ObrazkiOpis IdobrazekNavigation { get; set; }
    }
}
