<%@ Page Title="" Language="C#" MasterPageFile="~/Yönetim Paneli/YetkiliGirisMaster.master" AutoEventWireup="true" CodeFile="UrunEkle.aspx.cs" Inherits="Yönetim_Paneli_Yetkili_Giriş_Paneli_UrunEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-wrapper">
        <div class="main-page">
            <div class="forms">
                <div class=" form-grids row form-grids-right">
                    <div class="widget-shadow " data-example-id="basic-forms">
                        <div class="form-title">
                            <h4>Ürün Ekleme :</h4>
                        </div>

                        <div class="form-body">
                            <div class="form-group">
                             <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Ürün Kategorisi</asp:Label>
                             <div class="col-sm-9">
                                   <asp:DropDownList class="form-control" runat="server" ID="drpUrunKategori" AutoPostBack="false" ></asp:DropDownList>
                             </div>
							 </div> 
                            <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Ad</asp:Label>
                                <div class="col-sm-9">
                                    <asp:TextBox runat="server" ID="txtUrunAd" class="form-control" placeholder="Ürün Adı"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="txtUrunAd" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtUrunAd" ErrorMessage="Sadece harf giriniz." ValidationExpression="[a-zA-ZçÇğĞıİöÖşŞüÜ\s\-\,\.\;]+" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Açıklama</asp:Label>
                                <div class="col-sm-9">
                                    <asp:TextBox runat="server" ID="txtUrunAciklama" class="form-control" placeholder="Ürün Açıklama" Height="130px" TextMode="MultiLine" Width="100%" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="txtUrunAciklama" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUrunAciklama" ErrorMessage="Sadece harf giriniz." ValidationExpression="[a-zA-ZçÇğĞıİöÖşŞüÜ\s\-\,\.\;]+" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                                                          <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Kullanımı</asp:Label>
                                <div class="col-sm-9">
                                    <asp:TextBox runat="server" ID="txtUrunKullanimi" class="form-control" placeholder="Ürün Kullanımı" Height="130px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="txtUrunKullanimi" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtUrunKullanimi" ErrorMessage="Sadece harf giriniz." ValidationExpression="[a-zA-ZçÇğĞıİöÖşŞüÜ\s\-\,\.\;\d]+" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                             <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">İçerik</asp:Label>
                                <div class="col-sm-9">
                                    <asp:TextBox runat="server" ID="txtUrunİcerik" class="form-control" placeholder="Ürün İçeriği"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="txtUrunİcerik" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtUrunİcerik" ErrorMessage="Sadece harf giriniz." ValidationExpression="[a-zA-ZçÇğĞıİöÖşŞüÜ\s\-\,\.\;]+" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                              <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Ambalaj Şekli</asp:Label>
                                <div class="col-sm-9">
                                    <asp:TextBox runat="server" ID="txtUrunAmblajSekli" class="form-control" placeholder="Ürün Ambalaj Şekli"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="txtUrunAmblajSekli" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtUrunAmblajSekli" ErrorMessage="Sadece harf giriniz." ValidationExpression="[a-zA-ZçÇğĞıİöÖşŞüÜ\s\-\,\.\;\d]+" ForeColor="Red"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" for="inputEmail3" class="col-sm-2 control-label">Ürün Fotoğraf</asp:Label>
                                <div class="col-sm-9">
                                    <asp:FileUpload runat="server" ID="fuFotograf" BorderStyle="Solid" BorderWidth="1" BorderColor="#cccccc" AllowMultiple="True"/>&nbsp&nbsp<asp:Label runat="server" ID="lblHata" Visible="False" ForeColor="Red"></asp:Label>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Lütfen bu alanı boş bırakmayınız." ControlToValidate="fuFotograf" ForeColor="Red"></asp:RequiredFieldValidator>
                                </div>
                            </div><br />
                                        <div class="col-sm-offset-2">
                                            <asp:Button class="btn btn-default" Text="Onayla" runat="server" Style="background-color: #F2B33F; color: #fff" ID="btnUrunEkle" OnClick="btnUrunEkle_Click" />&nbsp&nbsp<asp:Label runat="server" ID="lblOnay" Visible="False" ForeColor="#32C867"></asp:Label>
                                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

