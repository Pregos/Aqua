using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class ObrazkiOpis
    {
        public ObrazkiOpis()
        {
            Galeria = new HashSet<Galeria>();
        }

        public int Idobrazek { get; set; }
        public string Title { get; set; }
        public string Alt { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Plik { get; set; }

        public ICollection<Galeria> Galeria { get; set; }
    }
}
