using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Biotop
    {
        public int Idrybka { get; set; }
        public int Idbiotop { get; set; }

        public Biotop IdbiotopNavigation { get; set; }
        public Rybki IdrybkaNavigation { get; set; }
    }
}
