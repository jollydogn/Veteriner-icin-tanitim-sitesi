using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PusulaVeterinerlik;

public partial class Kullanıcı_Sayfası_urunIcerik : System.Web.UI.Page
{
    DbProcess db = new DbProcess();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        DbProcess db = new DbProcess();
        string data = Request.QueryString["g"];
        if (data == null)
        {
            Response.Redirect("urunler.aspx");
        }
        string StrValue = "";
        while (data.Length > 0)//linkde gönderilen hex tipinde veriyi stringe çevirir
        {
            StrValue += System.Convert.ToChar(System.Convert.ToUInt32(data.Substring(0, 2), 16)).ToString();
            data = data.Substring(2, data.Length - 2);
        }
        string[] urunID = StrValue.Split('=');

        Urunler urunler = new Urunler(null)
        {
            urunID = int.Parse(urunID[1].ToString())
        };
        Resimler resimler = new Resimler(urunler)
        {
            urunID = urunler.urunID
        };

        List<Resimler> urunMiniResimGoster = new List<Resimler>();
        urunMiniResimGoster = db.miniUrunResimGetir(urunler);
        rptMiniUrunResimler.DataSource = urunMiniResimGoster;
        rptMiniUrunResimler.DataBind();

        Urunler urunAd = new Urunler(null)
        {
            urunID = int.Parse(urunID[1].ToString())
        };
        List<Urunler> urunKategoriAdUrunAdGetir = new List<Urunler>();
        urunKategoriAdUrunAdGetir = db.urunKategoriAdUrunAdGetir(urunAd);
        urunAd = urunKategoriAdUrunAdGetir[0];

        lblNav.Text = urunAd.kategoriler.ad + " / " + " "+urunAd.ad ;

        List<Resimler> urunIcerikAl = new List<Resimler>();
        urunIcerikAl = db.urunIcerikGetir(urunler);

        resimler = urunIcerikAl[0];
        if (urunIcerikAl.Count > 0)
        {
            lblUrunAd.Text = resimler.Urunler.ad;
            lblUrunIcerik.Text = resimler.Urunler.icerik;
            lblUrunKullanimi.Text = resimler.Urunler.kullanimi;
            lblUrunAciklama.Text = resimler.Urunler.aciklama;
            lblAmbalajSekli.Text = resimler.Urunler.ambalajSekli;
            imgResim.ImageUrl = resimler.resimAd;
        }
        else
        {
            Response.Redirect("urunler.aspx");
        }
    }

    protected void rptMiniUrunResimler_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if(e.CommandName== "resimBuyult")
        {
            Resimler resimler = new Resimler(null)
            {
                resimAd=Convert.ToString(e.CommandArgument)
            };

            imgResim.ImageUrl ="5f92c9bd-4c68-4415-9168- 6b98d5ba5d2b.jpeg";
        }
    }
}