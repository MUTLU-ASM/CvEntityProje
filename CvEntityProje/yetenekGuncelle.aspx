<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="yetenekGuncelle.aspx.cs" Inherits="CvEntityProje.yetenekGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h3 style="text-align:center; font-family:'Times New Roman', Times, serif";>Yetenek Güncelleme Sayfası</h3>
    <br />
    <asp:TextBox ID="txtGuncelle" runat="server" CssClass="form-control" placeHolder="Yeteneğinizi güncelleyin.."></asp:TextBox>
    <br />
    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-group" OnClick="btnKaydet_Click" />
</asp:Content>
