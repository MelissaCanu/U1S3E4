<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StampaPreventivo.aspx.cs" Inherits="U1S3E4.StampaPreventivo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stampa Preventivo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Dettagli Preventivo</h1>
            <hr />
            <div>
                <label>Modello Auto:</label>
                <asp:Label ID="lblAuto" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <label>Prezzo Base:</label>
                <asp:Label ID="lblPrezzoBase" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <label>Optional:</label>
                <asp:Label ID="lblOptional" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <label>Garanzia:</label>
                <asp:Label ID="lblGaranzia" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <label>Prezzo Finale:</label>
                <asp:Label ID="lblPrezzoFinale" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
