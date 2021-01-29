<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimGuncelle.aspx.cs" Inherits="Cv_Blok.AdminEgitimGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="form1" runat="server">
        <div class="forum">
            <asp:Label ID="Label6" runat="server" CssClass="Lbl" Text="id:"></asp:Label>
            <asp:TextBox ID="Txtid" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label1" runat="server" CssClass="Lbl" Text="Başlik:"></asp:Label>
            <asp:TextBox ID="TxtBaslik" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label2" runat="server" CssClass="Lbl" Text="Alt Başlık:"></asp:Label>
            <asp:TextBox ID="TxtAltBaslik" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label3" runat="server" CssClass="Lbl" Text="Açıklama:"></asp:Label>
            <asp:TextBox ID="TxtAciklama" runat="server" CssClass="Txt" Height="100px" TextMode="MultiLine"></asp:TextBox><p></p>

            <asp:Label ID="Label4" runat="server" CssClass="Lbl" Text="Genel Not:"></asp:Label>
            <asp:TextBox ID="TxtGnot" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label5" runat="server" CssClass="Lbl" Text="Tarıh:"></asp:Label>
            <asp:TextBox ID="TxtTarih" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Button ID="BtnGuncelle" runat="server" CssClass="Btn" Text="Güncelle" OnClick="BtnGuncelle_Click" />
        </div>
    </form>

</asp:Content>
