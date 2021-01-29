<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="Cv_Blok.Admin.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="forum">
            <asp:Label ID="Label1" runat="server" CssClass="Lbl" Text="Adınız:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label2" runat="server" CssClass="Lbl" Text="Soyadınız:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label3" runat="server" CssClass="Lbl" Text="Adres:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label4" runat="server" CssClass="Lbl" Text="Telefon:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label5" runat="server" CssClass="Lbl" Text="Mail:"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label6" runat="server" CssClass="Lbl" Text="Kısa Not:"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="Txt" Height="100px" TextMode="MultiLine"></asp:TextBox><p></p>

            <asp:Label ID="Label7" runat="server" CssClass="Lbl" Text="Fotograf:"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" CssClass="Txt"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" CssClass="Btn" Text="Güncelle" OnClick="Button1_Click1"/>
        </div>
    </form>



</asp:Content>
