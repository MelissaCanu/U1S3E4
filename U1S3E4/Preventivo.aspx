<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Preventivo.aspx.cs" Inherits="U1S3E4.Preventivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Creazione Preventivo</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <style type="text/css">
        .auto-image {
            width: 200px;
            height: 200px;
            object-fit: scale-down;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Creazione Preventivo</h1>
            <div>
                <label for="ddlAuto">Seleziona un'auto:</label>
                <!--quando l'utente seleziona un'auto diversa dal menu a tendina, il postback viene generato automaticamente-->
                <asp:DropDownList ID="ddlAuto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAuto_SelectedIndexChanged">

                    <asp:ListItem Text="Fiat 500" Value="500"></asp:ListItem>
                    <asp:ListItem Text="Fiat Panda" Value="Panda"></asp:ListItem>
                    <asp:ListItem Text="Fiat Punto" Value="Punto"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>

                <!--questo è il div che contiene l'immagine e il prezzo base dell'auto selezionata non visibile se non è stata selezionata un'auto-->
                <div class="card" id="cardAuto">
                    <asp:Image ID="imgAuto" runat="server" CssClass="card-img-top auto-image" ImageUrl="path_to_your_image.jpg" AlternateText="Auto Image" />
                    <div class="card-body">
                        <asp:Label ID="lblPrezzoBase" runat="server" CssClass="card-title"></asp:Label>
                    </div>
                </div>
            </div>

            <!--aggiungo checkbox per selezionare gli optional-->
            <div>
                <h2>Optional</h2>
                <asp:CheckBox ID="cbCerchi" runat="server" Text="Cerchi in lega" AutoPostBack="true" OnCheckedChanged="cbCerchi_CheckedChanged" />

                <asp:CheckBox ID="cbClima" runat="server" Text="Climatizzatore" AutoPostBack="true" OnCheckedChanged="cbClima_CheckedChanged" />
                <asp:CheckBox ID="cbRadio" runat="server" Text="Radio" AutoPostBack="true" OnCheckedChanged="cbRadio_CheckedChanged" />
            </div>

            <!--aggiungo dropdown con scelta tra 1 e 3 anni di garanzia-->
            <div>
                <h2>Garanzia</h2>
                <asp:DropDownList ID="ddlGaranzia" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlGaranzia_SelectedIndexChanged">

                    <asp:ListItem Text="1 anno" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2 anni" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3 anni" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </div>

           <!--aggiungo un bottone per calcolare il preventivo finale-->
                <div>
                    <asp:Button ID="btnStampa" runat="server" Text="Stampa Preventivo" OnClick="btnStampa_Click" />

                </div>
            <div>
    </form>
</body>
</html>
