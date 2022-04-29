using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PusulaVeterinerlik;

public partial class Kullanıcı_Sayfası_urunSecim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lblHata.Visible = false;
            lblhata1.Visible = false;
            DbProcess db = new DbProcess();
            string data = Request.QueryString["g"];
            if (data == null)
            {
                Response.Redirect("urunler.aspx");
            }
            else
            {
                string StrValue = "";
                while (data.Length > 0)//linkde gönderilen hex tipinde veriyi stringe çevirir
                {
                    StrValue += System.Convert.ToChar(System.Convert.ToUInt32(data.Substring(0, 2), 16)).ToString();
                    data = data.Substring(2, data.Length - 2);
                }
                string[] kategoriID = StrValue.Split('=');

                Kategoriler kategoriler = new Kategoriler()
                {
                    kategoriID = int.Parse(kategoriID[1].ToString())
                };
                List<Kategoriler> kategoriAdAl = new List<Kategoriler>();
                kategoriAdAl = db.kategoriAdGetir(kategoriler);

                kategoriler = kategoriAdAl[0];
                lblNav.Text = kategoriler.ad.ToString();

                Urunler urunler = new Urunler(null)
                {
                    kategoriID = Convert.ToInt32(kategoriID[1]),
                };
                Resimler resimler = new Resimler(urunler)
                {
                    urunID = urunler.urunID
                };
                List<Resimler> urunMiniGosterme = new List<Resimler>();
                urunMiniGosterme = db.miniUrunGetirSelect(urunler);

                if (urunMiniGosterme.Count > 0)
                {
                    rptUrunSecim.DataSource = urunMiniGosterme;
                    rptUrunSecim.DataBind();
                }
                else
                {
                    lblhata1.Visible = true;
                    lblhata1.Text = kategoriler.ad.ToString();
                    lblHata.Visible = true;
                }
            }
        }
    }


    protected void rptUrunSecim_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "UrunDetay")
        {
            Urunler urunler = new Urunler(null)
            {
                urunID = Convert.ToInt32(e.CommandArgument),
            };
            string data = "urunID=" + urunler.urunID;
            string hex = "";
            foreach (char c in data)    //verileri hex'e çevirir
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            Response.Redirect("urunIcerik.aspx?g=" + hex);//verileri 'D' olarak gönderir
        }
    }
}