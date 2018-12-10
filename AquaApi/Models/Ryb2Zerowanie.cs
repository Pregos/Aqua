using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Zerowanie
    {
        public int Idrybka { get; set; }
        public int Idzerowanie { get; set; }

        public Rybki IdrybkaNavigation { get; set; }
        public Zerowanie IdzerowanieNavigation { get; set; }
    }
}
