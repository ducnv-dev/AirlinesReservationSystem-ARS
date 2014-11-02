<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="addTickets.aspx.cs" Inherits="Airline_Reservation_System__ARS_.addTickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 270px;
        }

        .auto-style2 {
            width: 212px;
        }

        .auto-style3 {
            width: 175px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!--Thong tin ve dat-->
        <div class="row">
            <div class="col-md-4">
                <div class="wapper-search-home">
                    <table class="table table-condensed" style="width: 100%;">
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td class="auto-style1">Tickets Infomation</td>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style2">TICKETS CODE:</td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtTCode" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style2">USER CODE:</td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtTUserCOde" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>

                        <tr>
                            <td class="auto-style2">FLIGHT :</td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtTFlightCode" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style2">TICKETS PRICE:</td>
                            <td class="auto-style1">
                                <asp:Label ID="Label2" runat="server" Text="Adults"></asp:Label>
                                <asp:TextBox ID="txtTPriceAdult" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td class="auto-style1">
                                <asp:Label ID="Label1" runat="server" Text="Children"></asp:Label>
                                <asp:TextBox ID="txtTPriceChilren" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td class="auto-style1">
                                <asp:Label ID="Label3" runat="server" Text="Infant"></asp:Label>
                                <asp:TextBox ID="txtTPriceInfan" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style2">TOTAL PRICE:</td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtTTotalPrice" runat="server" Width="100%" ReadOnly="True"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>

                        </tr>

                    </table>
                    <div class="row">
                        <asp:Button CssClass="btn btn-success btn btn-default btn-search btn-search-home col-md-12 col-xs-12" ID="btnConfim" runat="server" Text="Comfim" OnClick="btnConfim_Click" />
                        <asp:Label ID="txtThongBaoConfim" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
            <!--Thong tin ngươi dat ve-->
            <div class="col-md-8">
                <div class="wapper-search-home">
                    <asp:Table CssClass="table table-condensed" ID="tableInforCustomer" runat="server" Width="100%">
                        <asp:TableHeaderRow runat="server">
                            <asp:TableHeaderCell runat="server">INFORMATION</asp:TableHeaderCell>
                        </asp:TableHeaderRow>

                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #1 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow1" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow2" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone1" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table1" runat="server" Width="100%" Visible="False">
                        

                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #2 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow3" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow4" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone2" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table2" runat="server" Width="100%" Visible="False">
                        

                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #3 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow5" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow6" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAddress3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone3" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table3" runat="server" Width="100%" Visible="False">
                        
                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #4 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow7" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow8" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone4" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table4" runat="server" Width="100%" Visible="False">
                        
                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #5 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow9" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow10" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone5" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table5" runat="server" Width="100%" Visible="False">
                        
                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #6 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow11" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow12" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone6" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table6" runat="server" Width="100%" Visible="False">
                        
                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #7 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow13" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow14" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtpPhone7" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table7" runat="server" Width="100%" Visible="False">
                        
                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #8 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow15" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow16" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAddress8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone8" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table8" runat="server" Width="100%" Visible="False">
                       
                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #9 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow17" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow18" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone9" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Table CssClass="table table-condensed" ID="table9" runat="server" Width="100%" Visible="False">
                       

                        <asp:TableRow runat="server">
                            <asp:TableHeaderCell runat="server" Text="Additional Passenger #10 Information"></asp:TableHeaderCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                            <asp:TableCell></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow19" runat="server" ForeColor="Teal">
                            <asp:TableCell>FullName :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtFullName10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Passport Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPass10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow ID="TableRow20" runat="server" ForeColor="Teal">
                            <asp:TableCell>Address :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtAdress10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell>Mobile Number :</asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtPhone10" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    
                    <div class="row">
                        <asp:Button CssClass="btn btn-success btn btn-default btn-search btn-search-home col-md-12 col-xs-12" ID="btnConfim2" runat="server" Text="Comfim" OnClick="btnConfim_Click" />
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Button CssClass="btn btn-success btn btn-default btn-search btn-search-home col-md-12 col-xs-12" ID="btnBack" runat="server" Text="Back" OnClick="Button2_Click"/>
                        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
