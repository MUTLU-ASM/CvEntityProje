<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="iletisimAdmin.aspx.cs" Inherits="CvEntityProje.iletisimAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table class="table table-bordered" style="margin-left: 20px;">
        <tr>
            <th class="auto-style1">ID</th>
            <th class="auto-style1">Ad Soyad</th>
            <th class="auto-style1">Mail</th>
            <th class="auto-style1">Konu</th>
            <th class="auto-style1">Mesajı gör</th>
        </tr>
        <tr>
            <asp:Repeater ID="rptId" runat="server">
                <itemtemplate>
                    <tr>
                        <td><%# Eval("id")%> </td>
                        <td><%# Eval("adsoyad")%> </td>
                        <td><%# Eval("mail")%> </td>
                        <td><%# Eval("konu")%> </td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"mesajDetay.aspx?id="+Eval("id") %>' CssClass="btn btn-warning">Mesajı gör</asp:HyperLink>
                        </td>
                    </tr>
                </itemtemplate>
            </asp:Repeater>
        </tr>
    </table>
</asp:Content>
