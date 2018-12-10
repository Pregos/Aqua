using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Pokarm
    {
        public int Idrybka { get; set; }
        public int Idpokarm { get; set; }

        public Pokarm IdpokarmNavigation { get; set; }
        public Rybki IdrybkaNavigation { get; set; }
    }
}
