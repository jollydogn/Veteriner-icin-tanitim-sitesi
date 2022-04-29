using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PusulaVeterinerlik;

public partial class ürünler : System.Web.UI.Page
{
    DbProcess db = new DbProcess();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            List<Kategoriler> kategorileriListele = new List<Kategoriler>();
            Kategoriler kategoriler = new Kategoriler()
            {
            };
            kategorileriListele = db.urunKategorilerSelect(kategoriler);

            RptKategori.DataSource = kategorileriListele;
            RptKategori.DataBind();
        }
    }


    protected void RptKategori_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "asd")
        {
            string[] commandArgs = e.CommandArgument.ToString().Split(',');
            Kategoriler kategoriler = new Kategoriler()
            {
                kategoriID = Convert.ToInt32(commandArgs[0]),
            };
            string data = "KategoriID=" + kategoriler.kategoriID;
            string hex = "";
            foreach (char c in data)    //verileri hex'e çevirir
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            Response.Redirect("urunSecim.aspx?g=" + hex);//verileri 'D' olarak gönderir
        }
    }
}
