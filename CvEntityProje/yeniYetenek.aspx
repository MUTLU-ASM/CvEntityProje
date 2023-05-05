<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="yeniYetenek.aspx.cs" Inherits="CvEntityProje.yeniYetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 style="text-align:center; font-family:'Times New Roman', Times, serif";>Yeni Yetenek Ekleme Sayfası</h3>
    <br />
    <asp:TextBox ID="txtYetenek" runat="server" CssClass="form-control" placeHolder="Yeteneğinizi yazınız.."></asp:TextBox>
    <br />
    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="btnKaydet_Click" />
</asp:Content>
