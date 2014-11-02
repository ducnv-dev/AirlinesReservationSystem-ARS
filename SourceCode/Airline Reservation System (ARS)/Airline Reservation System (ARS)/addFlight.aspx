<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="addFlight.aspx.cs" Inherits="Airline_Reservation_System__ARS_.addFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 18px;
        }

        .auto-style2 {
            width: 161px;
        }

        .auto-style3 {
            height: 18px;
            width: 161px;
        }

        .auto-style4 {
            width: 332px;
        }

        .auto-style5 {
            height: 18px;
            width: 332px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <table class="table table-condensed" style="width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">FLIGHT CODE:</td>
                <td class="auto-style4">
                    <asp:TextBox CssClass="form-control" ID="txtFcode" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>

            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">PLANE:</td>
                <td class="auto-style4">
                    <asp:DropDownList CssClass="form-control" ID="listPlance" runat="server" AppendDataBoundItems="True" Width="100%" OnSelectedIndexChanged="listPlance_SelectedIndexChanged1" >
                        <asp:ListItem Value="-1">Please Choose!</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">AIRLINE CODE:</td>
                <td class="auto-style4">
                    <asp:DropDownList CssClass="form-control" ID="ListAirLineCode" runat="server" AppendDataBoundItems="True" Width="100%" OnSelectedIndexChanged="ListAirLineCode_SelectedIndexChanged">
                        <asp:ListItem Value="-1">Please Choose!</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">DEPARTURE DATE:</td>
                <td class="auto-style4">
                    <asp:TextBox CssClass="form-control" ID="txtdateStart" runat="server"></asp:TextBox>
                    <asp:Button CssClass="btn btn-danger" ID="btnChonLichDi" runat="server" Text="Choose" OnClick="btnChonLichDi_Click" />
                    <asp:Calendar ID="CalendarDi" runat="server" Visible="False" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="CalendarDi_SelectionChanged">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>

            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">RETURN DATE:</td>
                <td class="auto-style4">
                    <asp:TextBox CssClass="form-control" ID="txtdateEnd" runat="server"></asp:TextBox>
                    <asp:Button CssClass="btn btn-danger" ID="btnChonLichDen" runat="server" Text="Choose" OnClick="btnChonLichDen_Click" />
                    <asp:Calendar ID="CalendarDen" runat="server" Visible="False" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="CalendarDen_SelectionChanged1" >
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">PRICE/1 SEAT/VND</td>
                <td class="auto-style4">
                    <asp:TextBox CssClass="form-control" ID="txtFPrice" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style3">TOTALSEATS:</td>
                <td class="auto-style5">
                    <asp:TextBox CssClass="form-control" ID="txtTotalSeat" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>

            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:RadioButton ID="RadioActive" runat="server" Checked="True" GroupName="r" Text="Active" />
                    <asp:RadioButton ID="RadionotActive" runat="server" GroupName="r" Text="not Active" />
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>

            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button CssClass="btn btn-success" ID="btnLuu" runat="server" Text="Add" OnClick="btnLuu_Click" />
                    &nbsp;or
                <asp:Button CssClass="btn btn-danger" ID="btnHuy" runat="server" Text="Cancel" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="txtThongBaoAddFligt" runat="server" ForeColor="#0066FF"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
