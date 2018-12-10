using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Rozmnazanie
    {
        public int Idrybka { get; set; }
        public int Idrozmnazanie { get; set; }

        public Rozmnazanie IdrozmnazanieNavigation { get; set; }
        public Rybki IdrybkaNavigation { get; set; }
    }
}
