<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="yeteneklerim.aspx.cs" Inherits="CvEntityProje.hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left: 20px;">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <tr>
            <asp:Repeater ID="rptId" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("id")%> </td>
                        <td><%# Eval("yetenek")%> </td>
                        <td><a href="#" class="btn btn-danger">Sil</a></td>
                        <td><a href="#" class="btn btn-success">Güncelle</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tr>
    </table>
    <a href="yeniYetenek.aspx" class="btn btn-primary" style="margin-left: 20px;">Yeni Yetenek Ekle</a>


</asp:Content>
