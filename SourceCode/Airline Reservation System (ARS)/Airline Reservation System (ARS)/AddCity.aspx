﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="AddCity.aspx.cs" Inherits="Airline_Reservation_System__ARS_.AddCity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 138px;
        }

        .auto-style2 {
            width: 280px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table table-condensed" style="width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">City Code :</td>
                <td class="auto-style2">
                    <asp:TextBox CssClass="form-control" ID="txtCityCode" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">City:</td>
                <td class="auto-style2">
                    <asp:TextBox CssClass="form-control" ID="txtCityName" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="rdoactive" runat="server" Checked="True" GroupName="active" Text="Active" />
                    <asp:RadioButton ID="rdonotactive" runat="server" GroupName="active" Text="Not Active" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button CssClass="btn btn-success" ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
                    &nbsp;hay
                <asp:Button CssClass="btn btn-danger" ID="btnHuy" runat="server" Text="Hủy" OnClick="btnHuy_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="txtThongbaothemcity" runat="server" ForeColor="#0099FF"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
        </table>
    </div>
</asp:Content>
