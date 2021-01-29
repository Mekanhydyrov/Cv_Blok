<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimEkle.aspx.cs" Inherits="Cv_Blok.AdminDeneyimEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="form1" runat="server">
        <div class="forum">
            <asp:Label ID="Label1" runat="server" CssClass="Lbl" Text="Başlik:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label2" runat="server" CssClass="Lbl" Text="Alt Başlık:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label3" runat="server" CssClass="Lbl" Text="Açıklama:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="Txt" Height="100px" TextMode="MultiLine"></asp:TextBox><p></p>

            <asp:Label ID="Label4" runat="server" CssClass="Lbl" Text="Tarıh:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Button ID="Button1" runat="server" CssClass="Btn" Text="Kaydet" OnClick="Button1_Click1"/>
        </div>
    </form>

</asp:Content>
