<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="mesajDetay.aspx.cs" Inherits="CvEntityProje.mesajDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h4>Mesaj Detay</h4>
    <asp:TextBox ID="txtAdSoyad" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtMail" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtKonu" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
    <br />    
    <asp:TextBox ID="txtMesaj" runat="server" CssClass="form-control" TextMode="MultiLine" Enabled="False"></asp:TextBox>
    <br />




</asp:Content>
