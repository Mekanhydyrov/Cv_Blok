<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenek.aspx.cs" Inherits="Cv_Blok.AdminYetenek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="tablo">
        <tr>
            <th>id</th>
            <th>Başlık</th>
            <th>Yetenekler</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><%#Eval("Baslik") %></td>
                        <td><%#Eval("Yetenek") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminYetenekSil.aspx?id="+Eval("id")%>' ID="HyperLink1" runat="server" CssClass="Btn-sil">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminYetenekGuncelle.aspx?id="+Eval("id")%>' ID="HyperLink2" runat="server" CssClass="Btn-Guncelle">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:HyperLink NavigateUrl="~/AdminYenetekEkle.aspx" ID="HyperLink3" CssClass="Btn-link" runat="server">Yetenek Ekle</asp:HyperLink>

</asp:Content>
