<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="addAirline.aspx.cs" Inherits="Airline_Reservation_System__ARS_.addAirline" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 166px;
        }

        .auto-style2 {
            width: 306px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table table-condensed" style="width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">ADD AIRLINE</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>

            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">AIRLINE CODE:</td>
                <td class="auto-style2">
                    <asp:TextBox CssClass="form-control" ID="txtACode" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">DEPARTURE:</td>
                <td class="auto-style2">
                    <asp:DropDownList CssClass="form-control" ID="listAStart" runat="server" Width="200px" AppendDataBoundItems="True" >
                        <asp:ListItem Value="-1">Please Choose!</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">DESTINATION:</td>
                <td class="auto-style2">
                    <asp:DropDownList CssClass="form-control" ID="listAStop" runat="server" Width="200px" AppendDataBoundItems="True" OnSelectedIndexChanged="listAStop_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Please Choose!</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">DISTANCE:</td>
                <td class="auto-style2">
                    <asp:TextBox CssClass="form-control" ID="txtChieudai" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="rdoActive" runat="server"  Text="Active" GroupName="AirPort" Checked="True" />
                    <asp:RadioButton ID="rdoNoActive" runat="server" Text="not Active" GroupName="AirPort" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button CssClass="btn btn-success" ID="btnThem" runat="server" Text="Add" OnClick="btnThem_Click" />
                    &nbsp;hay
                <asp:Button CssClass="btn btn-danger" ID="btnHuy" runat="server" Text="Cancel" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="txtThongbao" runat="server" ForeColor="#3399FF"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
