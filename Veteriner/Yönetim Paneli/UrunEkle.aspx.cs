using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using PusulaVeterinerlik;
public partial class Yönetim_Paneli_Yetkili_Giriş_Paneli_UrunEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHata.Visible = false;
        lblOnay.Visible = false;
        if (Session["yetki"] != "Yönetici")
        {
            Response.Redirect("../Login Sayfası/login.aspx");
        }
        try
        {

            if (!IsPostBack)
            {
                drpUrunKategori.Items.Clear();
                Kategoriler kategoriler = new Kategoriler() { };
                List<Kategoriler> kategorilerList = new List<Kategoriler>();
                kategorilerList = db.kategorilerSelect(kategoriler);

                for (int i = 0; i <= kategorilerList.Count - 1; i++) //odatiplerinin bulunduğu dropdowna Tipleri yükler.
                {
                    kategoriler = kategorilerList[i];
                    drpUrunKategori.Items.Add((kategoriler.ad));

                }

            }


        }
        catch (Exception)
        {

        }
    }
    DbProcess db = new DbProcess();
    protected void btnUrunEkle_Click(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~/images/onizlemeResimleri/");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        if (fuFotograf.PostedFile.ContentType == "image/jpeg" || fuFotograf.PostedFile.ContentType == "image/png")
        {
            if (fuFotograf.PostedFile.ContentLength < 2048000 )//2mb'den büyük resimlerin engellemesi
            {
                Kategoriler kategoriler = new Kategoriler()
                {
                    ad = drpUrunKategori.Text
                };
                List<Kategoriler> list = new List<Kategoriler>();
                list = db.kategoriIdGetir(kategoriler);
                kategoriler = list[0];

                Urunler urunler = new Urunler(kategoriler)
                {
                    kategoriID = kategoriler.kategoriID,
                    ad = txtUrunAd.Text,
                    aciklama = txtUrunAciklama.Text,
                    ambalajSekli = txtUrunAmblajSekli.Text,
                    icerik = txtUrunİcerik.Text,
                    kullanimi = txtUrunKullanimi.Text,
                };
                db.UrunlerInsert(urunler, kategoriler);

                IList<HttpPostedFile> SecilenDosyalar = fuFotograf.PostedFiles;
                if (SecilenDosyalar.Count <= 3)
                {
                    for (int i = 0; i < SecilenDosyalar.Count; i++)
                    {
                        string isim = Guid.NewGuid().ToString();//benzersiz bir isim verir
                        fuFotograf.PostedFiles[i].SaveAs(Server.MapPath("~/images/onizlemeResimleri/") + isim + ".jpeg");

                        Urunler urunId = new Urunler(null)
                        {
                            ad = txtUrunAd.Text
                        };

                        List<Urunler> urunIdGetirr = new List<Urunler>();
                        urunIdGetirr = db.urunIdGetir(urunId);

                        Urunler urunIdAl = new Urunler(null) { };
                        urunIdAl = urunIdGetirr[0];

                        Resimler resimler = new Resimler(urunIdAl)
                        {
                            urunID = urunIdAl.urunID,
                            resimAd = "~/images/onizlemeResimleri/" + isim + ".jpeg",
                        };
                        db.ResimlerInsert(resimler, urunIdAl);
                    }
                    HtmlMeta meta = new HtmlMeta();
                    meta.HttpEquiv = "Refresh";
                    meta.Content = "2;url=UrunEkle.aspx";
                    this.Page.Controls.Add(meta);
                    lblOnay.Visible = true;
                    lblOnay.Text = "İşleminiz tamamlandı , 2 saniye sonra yönlendirileceksiniz.";
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.Text = "en fazla 3 veya daha az resim seçiniz.";
                }
                
            }
        }
    }
}