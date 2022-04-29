using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing;
using PusulaVeterinerlik;
using System.IO;

public partial class Yönetim_Paneli_Yetkili_Giriş_Paneli_KategoriEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

        }
        if (Session["yetki"] != "Yönetici")
        {
            Response.Redirect("../Login Sayfası/login.aspx");
        }
    }
    DbProcess db = new DbProcess();


    protected void btnKategoriEkle_Click(object sender, EventArgs e)
    {
        Kategoriler kategori = new Kategoriler()
        {
          ad=txtKategoriAd.Text,
          resimAd=Image1.ImageUrl
        };
        db.KategorilerInsert(kategori);

        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "2;url=KategoriEkle.aspx";
        this.Page.Controls.Add(meta);
        lblOnay.Visible = true;
        lblOnay.Text = "İşleminiz tamamlandı , 2 saniye sonra yönlendirileceksiniz.";
    }

    protected void btnResimOnYukle_Click(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~/images/onizlemeResimleri/");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        if (fuFotograf.PostedFile.ContentType == "image/jpeg" || fuFotograf.PostedFile.ContentType == "image/png")
        {
            if (fuFotograf.PostedFile.ContentLength < 2048000)//2mb'den büyük resimlerin engellemesi
            {
                lblResim.Visible = false;
                string isim = Guid.NewGuid().ToString();//benzersiz bir isim verir
                fuFotograf.SaveAs(Server.MapPath("~/images/onizlemeResimleri/") + isim + ".jpeg");
                Image1.ImageUrl = "~/images/onizlemeResimleri/" + isim + ".jpeg";
            }
        }
    }
}