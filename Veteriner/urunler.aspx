<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="ürünler" Debug="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/simple-sidebar.css" rel="stylesheet">
    <link href="css/StyleSheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section class="featured_services py-5">
	<div class="container py-3">
		<h3 class="heading text-center mb-5" style="font-size:30px">KATEGORİLER</h3>
		<div class="row agile_inner_info">
            <asp:Repeater runat="server" ID="RptKategori" OnItemCommand="RptKategori_ItemCommand">
                <ItemTemplate>
                    <div class="col-lg-4 col-md-6 w3_agile_services_grid">
                        <div class="agile_services_grid">
                            <div class="hover06 column">
                                <div>
                                    <figure>
                                        <asp:Image ImageUrl='<%#Eval("resimAd") %>' runat="server" class="img-responsive" Width="400" Height="200" />
                                </div>
                            </div>
                        </div>
                        <div style="vertical-align: middle; text-align: center">
                            <h4>
                                <asp:Button runat="server" Text='<%#Eval("ad")%>' BorderStyle="None" ForeColor="White" CssClass="btnUrun" CommandName="asd" CommandArgument='<%#Eval("kategoriID")+","+Eval("ad")%>' /></h4>
                        </div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>

		</div>
	</div>
</section>
	
	<div class="testimonials pt-lg-5 pb-lg-0 pb-4">
		
	</div>
</asp:Content>

