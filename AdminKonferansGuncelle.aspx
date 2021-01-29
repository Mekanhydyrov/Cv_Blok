<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminKonferansGuncelle.aspx.cs" Inherits="Cv_Blok.AdminKonferansGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form id="form1" runat="server">
        <div class="forum">
            <asp:Label ID="Label5" runat="server" CssClass="Lbl" Text="id:"></asp:Label>
            <asp:TextBox ID="Txtid" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Label ID="Label1" runat="server" CssClass="Lbl" Text="Konferans:"></asp:Label>
            <asp:TextBox ID="TxtKonferans" runat="server" CssClass="Txt"></asp:TextBox><p></p>

             <asp:Button ID="Button1" runat="server" CssClass="Btn" Text="Güncelle" OnClick="Button1_Click"/>
        </div>
    </form>

</asp:Content>
