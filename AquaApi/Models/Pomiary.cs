using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Pomiary
    {
        public int Idpomiaru { get; set; }
        public int? Idakwarium { get; set; }
        public int? Idczujnika { get; set; }
        public DateTime? DataPomiaru { get; set; }
        public double? Wartosc { get; set; }

        public Akwaria IdakwariumNavigation { get; set; }
        public Czujniki IdczujnikaNavigation { get; set; }
    }
}
