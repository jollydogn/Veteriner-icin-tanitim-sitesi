using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PusulaVeterinerlik
{
    public class Urunler
    {
        public int urunID { get; set; }
        public string ad { get; set; }
        public string aciklama { get; set; }
        public string kullanimi { get; set; }
        public string icerik { get; set; }
        public string ambalajSekli { get; set; }
        public int kategoriID { get; set; }
        public Kategoriler kategoriler { get; set; }
        public Urunler(Kategoriler inKategoriler)
        {
            kategoriler = inKategoriler;
        }

    }
}
