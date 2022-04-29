using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PusulaVeterinerlik
{
    public class Resimler
    {
        public int resimID { get; set; }
        public string resimAd { get; set; }
        public int urunID { get; set; }
        public Urunler Urunler { get; set; }
        public Resimler(Urunler inUrunler)
        {
            Urunler = inUrunler;
        }
    }
}