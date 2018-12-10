using System;
using System.Collections.Generic;

namespace AquaApi.Models
{
    public partial class Rybki
    {
        public Rybki()
        {
            Galeria = new HashSet<Galeria>();
            Ryb2Akwarium = new HashSet<Ryb2Akwarium>();
            Ryb2Biotop = new HashSet<Ryb2Biotop>();
            Ryb2Pokarm = new HashSet<Ryb2Pokarm>();
            Ryb2Rodzina = new HashSet<Ryb2Rodzina>();
            Ryb2Rozmiar = new HashSet<Ryb2Rozmiar>();
            Ryb2Rozmnazanie = new HashSet<Ryb2Rozmnazanie>();
            Ryb2Woda = new HashSet<Ryb2Woda>();
            Ryb2Zerowanie = new HashSet<Ryb2Zerowanie>();
        }

        public int Idrybka { get; set; }
        public string Nazwa { get; set; }
        public int? ObrazekMax { get; set; }
        public int? ObrazekMin { get; set; }
        public string Opis { get; set; }
        public string PochodzenieOpis { get; set; }
        public string CharakterystykaOpis { get; set; }
        public string OdzywianieOpis { get; set; }
        public string AkwariumOpis { get; set; }
        public string RozmnazanieOpis { get; set; }
        public int? Video { get; set; }
        public string NazwaLacinska { get; set; }
        public string Synonim { get; set; }
        public string RozmiarUwagi { get; set; }
        public int? DlugoscZyciaOd { get; set; }
        public int? DlugoscZyciaDo { get; set; }
        public int? MinPojemnoscAkwa { get; set; }
        public int? MinDlugoscAkwa { get; set; }
        public int? WodaTempOd { get; set; }
        public int? WodaTempDo { get; set; }
        public int? WodapHod { get; set; }
        public int? WodapHdo { get; set; }
        public int? TwardoscOd { get; set; }
        public int? TwardoscDo { get; set; }

        public ICollection<Galeria> Galeria { get; set; }
        public ICollection<Ryb2Akwarium> Ryb2Akwarium { get; set; }
        public ICollection<Ryb2Biotop> Ryb2Biotop { get; set; }
        public ICollection<Ryb2Pokarm> Ryb2Pokarm { get; set; }
        public ICollection<Ryb2Rodzina> Ryb2Rodzina { get; set; }
        public ICollection<Ryb2Rozmiar> Ryb2Rozmiar { get; set; }
        public ICollection<Ryb2Rozmnazanie> Ryb2Rozmnazanie { get; set; }
        public ICollection<Ryb2Woda> Ryb2Woda { get; set; }
        public ICollection<Ryb2Zerowanie> Ryb2Zerowanie { get; set; }
    }
}
