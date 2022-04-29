using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using PusulaVeterinerlik;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    DbProcess db = new DbProcess();
    protected void btn_Click(object sender, EventArgs e)
    {
        List<Kullanicilar> kullaniciGetir = new List<Kullanicilar>();
        Kullanicilar kullanicilar = new Kullanicilar()
        {
            kAd = txtad.Text,
            kSifre = txtsifre.Text
        };
        kullaniciGetir = db.KullanicilarSelect(kullanicilar);

        if (kullaniciGetir.Count > 0)
        {
            kullanicilar = kullaniciGetir[0];

            if (kullanicilar.yetki == true)
            {
                Session["yetki"] = "Yönetici";
                Session["Kad"] = kullanicilar.ad;
                Session["Ksoyad"] = kullanicilar.soyad;
                Response.Redirect("../Yönetim Paneli/Default.aspx");
            }


        }
    }
}
