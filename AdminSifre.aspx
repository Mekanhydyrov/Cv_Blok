<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSifre.aspx.cs" Inherits="Cv_Blok.AdminSifre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <form id="form1" runat="server">
        <div class="forum">

            <asp:Label ID="Label2" runat="server" CssClass="Lbl" Text="Kullanıcı:"></asp:Label>
            <asp:TextBox ID="TxtKullanici" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label3" runat="server" CssClass="Lbl" Text="Şifre:"></asp:Label>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="Txt"></asp:TextBox><p></p>
          
            <asp:Button ID="Btn" runat="server" CssClass="Btn" Text="Güncelle" OnClick="Btn_Click"/>
        </div>
    </form>

</asp:Content>
