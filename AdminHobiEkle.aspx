<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobiEkle.aspx.cs" Inherits="Cv_Blok.AdminHobiEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="forum">
            <asp:Label ID="Label1" runat="server" CssClass="Lbl" Text="Hobi:"></asp:Label>
            <asp:TextBox ID="TxtHobi" runat="server" CssClass="Txt"></asp:TextBox><p></p>

            <asp:Button ID="BtnHobiEkle" runat="server" CssClass="Btn" Text="Kaydet" OnClick="BtnHobiEkle_Click"/>
        </div>
    </form>

</asp:Content>
