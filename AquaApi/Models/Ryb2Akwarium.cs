using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Ryb2Akwarium
    {
        public int Idrybka { get; set; }
        public int Idakwarium { get; set; }

        public Rybki Idrybka1 { get; set; }
        public Akwarium IdrybkaNavigation { get; set; }
    }
}
