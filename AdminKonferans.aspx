<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminKonferans.aspx.cs" Inherits="Cv_Blok.AdminKonferans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <table class="tablo">
        <tr>
            <th>id</th>
            <th>Konferans</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><%#Eval("Konferans") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminKonferansSil.aspx?id="+Eval("id")%>' ID="HyperLink1" runat="server" CssClass="Btn-sil">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminKonferansGuncelle.aspx?id="+Eval("id")%>' ID="HyperLink2" runat="server" CssClass="Btn-Guncelle">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
                <asp:HyperLink NavigateUrl="~/AdminKonferansEkle.aspx" ID="HyperLink3" CssClass="Btn-link" runat="server">Konferans Ekle</asp:HyperLink>



</asp:Content>
