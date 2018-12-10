using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Woda
    {
        public int Idrybka { get; set; }
        public int Idwoda { get; set; }

        public Rybki IdrybkaNavigation { get; set; }
        public Woda IdwodaNavigation { get; set; }
    }
}
