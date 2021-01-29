<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHobi.aspx.cs" Inherits="Cv_Blok.AdminHobi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <table class="tablo">
        <tr>
            <th>id</th>
            <th>Hobi</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><%#Eval("Hobi") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminHobiSil.aspx?id="+Eval("id")%>' ID="HyperLink1" runat="server" CssClass="Btn-sil">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminHobiGuncelle.aspx?id="+Eval("id")%>' ID="HyperLink2" runat="server" CssClass="Btn-Guncelle">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
                <asp:HyperLink NavigateUrl="~/AdminHobiEkle.aspx" ID="HyperLink3" CssClass="Btn-link" runat="server">Hobi Ekle</asp:HyperLink>


</asp:Content>
