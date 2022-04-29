using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PusulaVeterinerlik
{
    public class DbProcess
    {

        SqlConnection con = new SqlConnection("Server = localhost; Database=PusulaVeterinerlik; Trusted_Connection = True;");

        #region Kategoriler
        public void KategorilerInsert(Kategoriler kategorilerDegisken)
        {
            SqlCommand insert = new SqlCommand("insert into Kategoriler(ad,resimAd) values(@ad,@resimAd)", con);
            insert.Parameters.AddWithValue("@ad", kategorilerDegisken.ad);
            insert.Parameters.AddWithValue("@resimAd", kategorilerDegisken.resimAd);
            KomutCalistir(insert);
        }

        public void KategorilerUpdate(Kategoriler kategorilerDegisken)
        {
            SqlCommand update = new SqlCommand("update Kategoriler set kategoriID=@kategoriID,ad=@ad,resimAd=@resimAd where kategoriID=@kategoriID", con);
            update.Parameters.AddWithValue("@kategoriID", kategorilerDegisken.kategoriID);
            update.Parameters.AddWithValue("@ad", kategorilerDegisken.ad);
            update.Parameters.AddWithValue("@resimAd", kategorilerDegisken.resimAd);
            KomutCalistir(update);
        }

        public void KategorilerDelete(Kategoriler kategorilerDegisken)
        {
            SqlCommand delete = new SqlCommand("delete from Kategoriler where kategoriID=@kategoriID", con);
            delete.Parameters.AddWithValue("@kategoriID", kategorilerDegisken.kategoriID);
            KomutCalistir(delete);
        }

        public List<Kategoriler> kategoriIdGetir(Kategoriler kategorilerDegisken)
        {
            List<Kategoriler> result = new List<Kategoriler>();
            con.Open();
            SqlCommand komut = new SqlCommand("select kategoriID from Kategoriler where ad=@ad", con);
            komut.Parameters.AddWithValue("@ad", kategorilerDegisken.ad);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kategoriler kategoriler = new Kategoriler()
                {

                    kategoriID = Convert.ToInt32(dr[0]),
                };
                result.Add(kategoriler);
            }
            con.Close();
            return result;
        }
        public List<Kategoriler> kategoriAdGetir(Kategoriler kategorilerDegisken)
        {
            List<Kategoriler> result = new List<Kategoriler>();
            con.Open();
            SqlCommand komut = new SqlCommand("select ad from Kategoriler where kategoriID=@kategoriID", con);
            komut.Parameters.AddWithValue("@kategoriID", kategorilerDegisken.kategoriID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kategoriler kategoriler = new Kategoriler()
                {
                    ad = Convert.ToString(dr[0]),
                };
                result.Add(kategoriler);
            }
            con.Close();
            return result;
        }
        public List<Kategoriler> kategorilerSelect(Kategoriler kategorilerDegiskenn)
        {
            List<Kategoriler> result = new List<Kategoriler>();
            con.Open();
            SqlCommand komut = new SqlCommand("select ad from Kategoriler", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kategoriler kategoriler = new Kategoriler()
                {

                    ad = Convert.ToString(dr[0]),
                };
                result.Add(kategoriler);
            }
            con.Close();
            return result;
        }
        public List<Kategoriler> urunKategorilerSelect(Kategoriler kategorilerDegiskenn)
        {
            List<Kategoriler> result = new List<Kategoriler>();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Kategoriler", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kategoriler kategoriler = new Kategoriler()
                {
                    kategoriID= Convert.ToInt32(dr[0]),
                    ad = Convert.ToString(dr[1]),
                    resimAd= Convert.ToString(dr[2])
                };
                result.Add(kategoriler);
            }
            con.Close();
            return result;
        }
        #endregion
        #region Kullanýcýlar
        public void KullanicilarInsert(Kullanicilar kullanicilarDegisken)
        {
            SqlCommand insert = new SqlCommand("insert into Kullanicilar(userID,ad,soyad,kAd,kSifre,yetki,isActive) values(@userID,@ad,@soyad,@kAd,@kSifre,@yetki,@isActive)", con);
            insert.Parameters.AddWithValue("@userID", kullanicilarDegisken.userID);
            insert.Parameters.AddWithValue("@ad", kullanicilarDegisken.ad);
            insert.Parameters.AddWithValue("@soyad", kullanicilarDegisken.soyad);
            insert.Parameters.AddWithValue("@kAd", kullanicilarDegisken.kAd);
            insert.Parameters.AddWithValue("@kSifre", kullanicilarDegisken.kSifre);
            insert.Parameters.AddWithValue("@yetki", kullanicilarDegisken.yetki);
            insert.Parameters.AddWithValue("@isActive", kullanicilarDegisken.isActive);
            KomutCalistir(insert);
        }

        public void KullanicilarUpdate(Kullanicilar kullanicilarDegisken)
        {
            SqlCommand update = new SqlCommand("update Kullanicilar set userID=@userID,ad=@ad,soyad=@soyad,kAd=@kAd,kSifre=@kSifre,yetki=@yetki,isActive=@isActive where userID=@userID", con);
            update.Parameters.AddWithValue("@userID", kullanicilarDegisken.userID);
            update.Parameters.AddWithValue("@ad", kullanicilarDegisken.ad);
            update.Parameters.AddWithValue("@soyad", kullanicilarDegisken.soyad);
            update.Parameters.AddWithValue("@kAd", kullanicilarDegisken.kAd);
            update.Parameters.AddWithValue("@kSifre", kullanicilarDegisken.kSifre);
            update.Parameters.AddWithValue("@yetki", kullanicilarDegisken.yetki);
            update.Parameters.AddWithValue("@isActive", kullanicilarDegisken.isActive);
            KomutCalistir(update);
        }

        public void KullanicilarDelete(Kullanicilar kullanicilarDegisken)
        {
            SqlCommand delete = new SqlCommand("delete from Kullanicilar where userID=@userID", con);
            delete.Parameters.AddWithValue("@userID", kullanicilarDegisken.userID);
            KomutCalistir(delete);
        }

        public List<Kullanicilar> KullanicilarSelect(Kullanicilar kullanicilarDegisken)
        {
            List<Kullanicilar> result = new List<Kullanicilar>();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanicilar where kAd=@kAd and kSifre=@kSifre", con);
            komut.Parameters.AddWithValue("@kAd",kullanicilarDegisken.kAd);
            komut.Parameters.AddWithValue("@kSifre", kullanicilarDegisken.kSifre);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kullanicilar kullanicilar = new Kullanicilar()
                {

                    userID = Convert.ToInt32(dr[0]),
                    ad = Convert.ToString(dr[1]),
                    soyad = Convert.ToString(dr[2]),
                    kAd = Convert.ToString(dr[3]),
                    kSifre = Convert.ToString(dr[4]),
                    yetki = Convert.ToBoolean(dr[5]),
                    isActive = Convert.ToBoolean(dr[6])
                };
                result.Add(kullanicilar);
            }
            con.Close();
            return result;
        }
        #endregion
        #region Ürünler
        public void UrunlerInsert(Urunler urunlerDegisken,Kategoriler kategoriler)
        {
            SqlCommand insert = new SqlCommand("insert into Urunler(ad,aciklama,kullanimi,icerik,ambalajSekli,kategoriID) values(@ad,@aciklama,@kullanimi,@icerik,@ambalajSekli,@kategoriID)", con);
            insert.Parameters.AddWithValue("@ad", urunlerDegisken.ad);
            insert.Parameters.AddWithValue("@aciklama", urunlerDegisken.aciklama);
            insert.Parameters.AddWithValue("@kullanimi", urunlerDegisken.kullanimi);
            insert.Parameters.AddWithValue("@icerik", urunlerDegisken.icerik);
            insert.Parameters.AddWithValue("@ambalajSekli", urunlerDegisken.ambalajSekli);
            insert.Parameters.AddWithValue("@kategoriID", kategoriler.kategoriID);
            KomutCalistir(insert);
        }

        public void UrunlerUpdate(Urunler urunlerDegisken)
        {
            SqlCommand update = new SqlCommand("update Urunler set urunID=@urunID,ad=@ad,aciklama=@aciklama,kullanimi=@kullanimi,icerik=@icerik,ambalajSekli=@ambalajSekli,resimAd=@resimAd where urunID=@urunID", con);
            update.Parameters.AddWithValue("@urunID", urunlerDegisken.urunID);
            update.Parameters.AddWithValue("@ad", urunlerDegisken.ad);
            update.Parameters.AddWithValue("@aciklama", urunlerDegisken.aciklama);
            update.Parameters.AddWithValue("@kullanimi", urunlerDegisken.kullanimi);
            update.Parameters.AddWithValue("@icerik", urunlerDegisken.icerik);
            update.Parameters.AddWithValue("@ambalajSekli", urunlerDegisken.ambalajSekli);
            KomutCalistir(update);
        }

        public void UrunlerDelete(Urunler urunlerDegisken)
        {
            SqlCommand delete = new SqlCommand("delete from Urunler where urunID=@urunID", con);
            delete.Parameters.AddWithValue("@urunID", urunlerDegisken.urunID);
            KomutCalistir(delete);
        }

        public List<Urunler> urunIdGetir(Urunler urunDegisken)
        {
            Urunler oteller = new Urunler(null);
            List<Urunler> result = new List<Urunler>();
            SqlCommand cmd = new SqlCommand("select urunID from Urunler where ad=@urunAd", con);
            cmd.Parameters.AddWithValue("@urunAd", urunDegisken.ad);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Urunler urunler = new Urunler(null)
                {
                    urunID = int.Parse(dr[0].ToString())

                };

                result.Add(urunler);
            }
            con.Close();
            return result;

        }
        public List<Urunler> UrunlerSelect()
        {
            List<Urunler> result = new List<Urunler>();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Urunler", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Urunler urunler = new Urunler(null)
                {

                    urunID = Convert.ToInt32(dr[0]),
                    aciklama = Convert.ToString(dr[1]),
                    kullanimi = Convert.ToString(dr[2]),
                    icerik = Convert.ToString(dr[3]),
                    ambalajSekli = Convert.ToString(dr[4]),
                };
                result.Add(urunler);
            }
            con.Close();
            return result;
        }
        public List<Resimler> miniUrunGetirSelect(Urunler urunlerDegisken)
        {
            List<Resimler> result = new List<Resimler>();
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT max(dbo.Resimler.urunID),max(dbo.Urunler.ad),max(dbo.Resimler.resimAd) FROM dbo.Resimler INNER JOIN  dbo.Urunler ON dbo.Resimler.urunID = dbo.Urunler.urunID where Urunler.kategoriID = @kategoriID group by Resimler.urunID", con);
            komut.Parameters.AddWithValue("@kategoriID", urunlerDegisken.kategoriID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Urunler urunler = new Urunler(null)
                {
                    ad = Convert.ToString(dr[1]),
                    urunID= Convert.ToInt32(dr[0]),

                };
                Resimler resimler = new Resimler(urunler)
                {
                    resimAd = Convert.ToString(dr[2])
                };
                result.Add(resimler);
            }
            con.Close();
            return result;
        }
        public List<Resimler> urunIcerikGetir(Urunler urunlerDegisken)
        {
            List<Resimler> result = new List<Resimler>();
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT dbo.Resimler.resimAd, dbo.Urunler.ad, dbo.Urunler.aciklama, dbo.Urunler.kullanimi, dbo.Urunler.icerik, dbo.Urunler.ambalajSekli FROM dbo.Resimler INNER JOIN dbo.Urunler ON dbo.Resimler.urunID = dbo.Urunler.urunID where dbo.Urunler.urunID = @urunID", con);
            komut.Parameters.AddWithValue("@urunID", urunlerDegisken.urunID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Urunler urunler = new Urunler(null)
                {
                    ad = Convert.ToString(dr[1]),
                    aciklama= Convert.ToString(dr[2]),
                    kullanimi= Convert.ToString(dr[3]),
                    icerik= Convert.ToString(dr[4]),
                    ambalajSekli= Convert.ToString(dr[5])

                };
                Resimler resimler = new Resimler(urunler)
                {
                    resimAd = Convert.ToString(dr[0])
                };
                result.Add(resimler);
            }
            con.Close();
            return result;
        }
        public List<Urunler> urunKategoriAdUrunAdGetir(Urunler urunDegisken)
        {
            Urunler oteller = new Urunler(null);
            List<Urunler> result = new List<Urunler>();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Kategoriler.ad, dbo.Urunler.ad AS ad FROM dbo.Kategoriler INNER JOIN dbo.Urunler ON dbo.Kategoriler.kategoriID = dbo.Urunler.kategoriID where  dbo.Urunler.urunID = @urunID", con);
            cmd.Parameters.AddWithValue("@urunID", urunDegisken.urunID);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Kategoriler kategoriler = new Kategoriler()
                {
                    ad = Convert.ToString(dr[0])
                };
                Urunler urunler = new Urunler(kategoriler)
                {
                    ad = Convert.ToString( dr[1])

                };

                result.Add(urunler);
            }
            con.Close();
            return result;

        }
        public List<Resimler> miniUrunResimGetir(Urunler urunlerDegisken)
        {
            List<Resimler> result = new List<Resimler>();
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT dbo.Resimler.resimAd FROM dbo.Resimler INNER JOIN dbo.Urunler ON dbo.Resimler.urunID = dbo.Urunler.urunID where Urunler.urunID = @urunID", con);
            komut.Parameters.AddWithValue("@urunID", urunlerDegisken.urunID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Urunler urunler = new Urunler(null)
                {

                };
                Resimler resimler = new Resimler(urunler)
                {
                    resimAd = Convert.ToString(dr[0])
                };
                result.Add(resimler);
            }
            con.Close();
            return result;
        }
        #endregion
        #region Resimler
        public void ResimlerInsert(Resimler resimlerDegisken,Urunler urunler)
        {
            SqlCommand insert = new SqlCommand("insert into Resimler(resimAd,urunID) values(@resimAd,@urunID)", con);
            insert.Parameters.AddWithValue("@resimAd", resimlerDegisken.resimAd);
            insert.Parameters.AddWithValue("@urunID", urunler.urunID);
            KomutCalistir(insert);
        }

        public void ResimlerUpdate(Resimler resimlerDegisken,Urunler urunler)
        {
            SqlCommand update = new SqlCommand("update Resimler set resimAd=@resimAd,urunID=@urunID where resimID=@resimID", con);
            update.Parameters.AddWithValue("@resimID", resimlerDegisken.resimID);
            update.Parameters.AddWithValue("@resimAd", resimlerDegisken.resimAd);
            update.Parameters.AddWithValue("@urunID", urunler.urunID);
            KomutCalistir(update);
        }

        public void ResimlerDelete(Resimler resimlerDegisken)
        {
            SqlCommand delete = new SqlCommand("delete from Resimler where resimID=@resimID", con);
            delete.Parameters.AddWithValue("@resimID", resimlerDegisken.resimID);
            KomutCalistir(delete);
        }

        public List<Resimler> ResimlerSelect()
        {
            List<Resimler> result = new List<Resimler>();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Resimler", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Resimler resimler = new Resimler(null)
                {
                    resimID = Convert.ToInt32(dr[0]),
                    resimAd = Convert.ToString(dr[1]),
                    urunID = Convert.ToInt32(dr[2])
                };
                result.Add(resimler);
            }
            con.Close();
            return result;
        }
        public List<Resimler> urunResimIcerik(Resimler resimlerDegisken)
        {
            List<Resimler> result = new List<Resimler>();
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT resimAd from Resimler where resimAd=@resimAd", con);
            komut.Parameters.AddWithValue("@resimAd", resimlerDegisken.resimAd);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Resimler resimler = new Resimler(null)
                {
                    resimAd = Convert.ToString(dr[0])
                };
                result.Add(resimler);
            }
            con.Close();
            return result;
        }

        #endregion
        public Boolean KomutCalistir(SqlCommand komut)
        {
            con.Open();
            komut.ExecuteNonQuery();
            komut.Dispose();
            con.Close();
            return true;
        }

    }
}
