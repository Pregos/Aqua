using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Rodzina
    {
        public int Idrybka { get; set; }
        public int Idrodzina { get; set; }

        public Rodzina IdrodzinaNavigation { get; set; }
        public Rybki IdrybkaNavigation { get; set; }
    }
}
