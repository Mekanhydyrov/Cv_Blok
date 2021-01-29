<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyim.aspx.cs" Inherits="Cv_Blok.AdminDeneyim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="tablo">
        <tr>
            <th>id</th>
            <th>Başlık</th>
            <th>Alt Başlık</th>
            <th>Açıklama</th>
            <th>Tarıh</th>
            <th>İşlemler</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><%#Eval("Baslik") %></td>
                        <td><%#Eval("AltBaslik") %></td>
                        <td><%#Eval("Aciklama") %></td>
                        <td><%#Eval("Tarih") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"AdminDeneyimSil.aspx?id="+Eval("id")%>' ID="HyperLink1" runat="server" CssClass="Btn-sil">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#"AdminDeneyimGuncelle.aspx?id="+Eval("id")%>' ID="HyperLink2" runat="server" CssClass="Btn-Guncelle">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
                <asp:HyperLink NavigateUrl="~/AdminDeneyimEkle.aspx" ID="HyperLink3" CssClass="Btn-link" runat="server">Deneme Ekle</asp:HyperLink>

</asp:Content>
