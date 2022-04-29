<%@ Page Title="" Language="C#" MasterPageFile="~/Yönetim Paneli/YetkiliGirisMaster.master" AutoEventWireup="true" CodeFile="KategoriEkle.aspx.cs" Inherits="Yönetim_Paneli_Yetkili_Giriş_Paneli_KategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div id="page-wrapper">
        <div class="main-page">
            <div class="forms">
                <div class=" form-grids row form-grids-right">
                    <div class="widget-shadow " data-example-id="basic-forms">
                        <div class="form-title">
                            <h4>Ürün Kategorisi Ekleme :</h4>
                        </div>

                        <div class="form-body">
                            <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Ad</asp:Label>
                                <div class="col-sm-9">
                                    <asp:TextBox runat="server" ID="txtKategoriAd" class="form-control" placeholder="Kategori Adı"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="txtKategoriAd" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtKategoriAd" ErrorMessage="Sadece harf giriniz." ValidationExpression="[a-zA-ZçÇğĞıİöÖşŞüÜ\s\-]+" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                                    <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Kategori Fotoğraf</asp:Label>
                                <div class="col-sm-9">
                                    <asp:FileUpload runat="server" ID="fuFotograf" BorderStyle="Solid" BorderWidth="1" BorderColor="#cccccc"/>
                                    <br />
                                    <asp:Button ID="btnResimOnYukle" class="btn btn-default" runat="server" Text="Yükle" Style="background-color: #F2B33F; color: #fff" OnClick="btnResimOnYukle_Click"/>
                                    <asp:Image ID="Image1" runat="server" Height="100" Width="100" />
                                    <asp:Label ID="lblResim" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                                </div>
                            </div><br />
                                        <div class="col-sm-offset-2">
                                            <asp:Button class="btn btn-default" Text="Onayla" runat="server" Style="background-color: #F2B33F; color: #fff" ID="btnKategoriEkle" OnClick="btnKategoriEkle_Click"  />&nbsp&nbsp<asp:Label runat="server" ID="lblOnay" Visible="False" ForeColor="#32C867"></asp:Label>
                                        </div>

                        </div>
                 
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

