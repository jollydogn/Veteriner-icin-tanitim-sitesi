<%@ Page Language="C#" AutoEventWireup="true" CodeFile="urunIcerik.aspx.cs" Inherits="Kullanıcı_Sayfası_urunIcerik" Debug="true" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pusula Veterinerlik</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta charset="utf-8" />
    <meta name="keywords" content="In Travel Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
	Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript">
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
    </script>
    <link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />

    <link rel="stylesheet" href="css/jquery.desoslide.css" />


    <link rel="stylesheet" href="css/bootstrap.css" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <link rel="stylesheet" href="css/font-awesome.css" />
    <link rel="stylesheet" href="css/jquery-ui.css" />

    <link href="//fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=latin-ext" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Super Market Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->

    <link href="urunlerCss/css/bootstrap.css" rel="stylesheet" />
    <link href="urunlerCss/css/style.css" rel="stylesheet" />
    <!-- font-awesome icons -->
    <link href="urunlerCss/css/font-awesome.css" rel="stylesheet" />
    <!-- //font-awesome icons -->
    <!-- js -->
    <script src="urunlerCss/js/jquery-1.11.1.min.js"></script>
    <!-- //js -->
    <link href='//fonts.googleapis.com/css?family=Raleway:400,100,100italic,200,200italic,300,400italic,500,500italic,600,600italic,700,700italic,800,800italic,900,900italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    <!-- start-smoth-scrolling -->
    <script src="urunlerCss/js/move-top.js"></script>
    <script src="urunlerCss/js/easing.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            $(".scroll").click(function (event) {
                event.preventDefault();
                $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1000);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="container agile-banner_nav">
            </div>
            <div class="container agile-banner_nav">
                <nav class="navbar navbar-expand-lg navbar-light bg-light">

                    <h1><a class="navbar-brand" href="default.aspx" style="font: 20px bold 'Centruy Gothic'; margin-top: 20px;">PUSULA VETERİNERLİK</a></h1>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse justify-content-center" id="navbarSupportedContent" style="margin-left: 20px;">
                        <ul class="navbar-nav ml-auto" style="margin-top: -20px;">
                            <li class="nav-item">
                                <a class="nav-link" href="default.aspx">Anasayfa</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="hakkimizda.aspx">Hakkımızda</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="urunler.aspx">Ürünlerimiz</a>
                            </li>
                            <li class="nav-item pr-lg-0">
                                <a class="nav-link pr-lg-0" href="iletisim.aspx">İletişim</a>
                            </li>
                        </ul>
                    </div>

                </nav>
            </div>

        </header>
        <div class="innerpage-banner">
            <div class="layer1">
            </div>
        </div>

        <div class="breadcrumbs">
            <div class="container">
                <ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
                    <li><a href="urunler.aspx"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Ürünlerimiz</a></li>

                    <li class="active">
                        <asp:Label runat="server" ID="lblNav"></asp:Label></li>
                </ol>
            </div>
        </div>

        <div class="products">
            <div class="container">
                <div class="agileinfo_single">
                    <div style="width:300px;float:left" >
                    <div class="col-md-12 agileinfo_single_left">
                        <asp:Image runat="server" ID="imgResim" Width="310" Height="320" class="img-responsive" />
                    </div><div class="clearfix"></div><br />
                    <asp:Repeater runat="server" ID="rptMiniUrunResimler" OnItemCommand="rptMiniUrunResimler_ItemCommand">
                        <ItemTemplate>
                            <div class="col-md-3 agileinfo_single_left" style="padding:5px">
                                <asp:ImageButton ImageUrl='<%#Eval("resimAd") %>' runat="server"  Width="70" Height="100" class="img-responsive" CommandName="resimBuyult" CommandArgument='<%#Eval("resimAd") %>'/>     
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    </div>
                    <div class="col-md-8 agileinfo_single_right">
                        <h2>
                            <asp:Label runat="server" ID="lblUrunAd" /></h2>
                        <div class="w3agile_description">
                            <h4>AÇIKLAMA :</h4>
                            <asp:Label Text="text" runat="server" ID="lblUrunAciklama" /><br />
                            <h4>KULLANIMI :</h4>
                            <asp:Label Text="text" runat="server" ID="lblUrunKullanimi" /><br />
                            <h4>İÇERİK :</h4>
                            <asp:Label Text="text" runat="server" ID="lblUrunIcerik" /><br />
                            <h4>AMBALAJ ŞEKLİ :</h4>
                            <asp:Label Text="text" runat="server" ID="lblAmbalajSekli" />
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>
        <div style="margin-top: 20px"></div>
        <footer class="py-5">

            <div class="subscribe-grid text-center">
                <h5 style="font: 20px bold 'Centruy Gothic'">PUSULA VETERİNERLİK</h5>
            </div>
                    <script type="text/javascript" src="js/jquery-2.2.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<script src="js/jquery.desoslide.js"></script>
	<script src="js/responsiveslides.min.js"></script>

	<script src="js/jquery.magnific-popup.js"></script>

	<script src="js/SmoothScroll.min.js"></script>
	<script type="text/javascript" src="js/move-top.js"></script>
	<script type="text/javascript" src="js/easing.js"></script>
        </footer>
    </form>
</body>
</html>
