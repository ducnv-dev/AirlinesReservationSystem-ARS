<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Airline_Reservation_System__ARS_.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4">
                <div class="wapper-search-home">
                    <div class="wapper-search2">
                        <div class="row">
                            <div class="col-md-12">
                                <h1 class="title-search">Booking here</h1>
                            </div>
                        </div>
                        <!--Chọn loại vé-->
                        <div class="row">
                            <div class="col-md-6 height-radio col-xs-6">
                                <div class="radio text-chon ">
                                    <asp:RadioButton ID="rbt2Chieu" runat="server" Text="Round trip" GroupName="loaive" Checked="True" />
                                </div>
                            </div>
                            <div class="col-md-6 height-radio col-xs-6">
                                <div class="radio text-chon">
                                    <asp:RadioButton ID="rbt1Chieu" runat="server" Text="One-way" GroupName="loaive" />

                                </div>
                            </div>
                        </div>
                        <!--Chọn điểm đi -điểm đến-->
                        <div class="row margin-top-form">
                            <div class="col-md-6">
                                <span class="title-search-mini">Departure</span>
                                <div class="">
                                    <asp:DropDownList CssClass="form-control" ID="listDiemDi" runat="server" Width="142px" AppendDataBoundItems="True">
                                        <asp:ListItem Value="-1">Please Choose!</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <span class="title-search-mini">Destination</span>
                                <div class="">
                                    <asp:DropDownList CssClass="form-control" ID="listDiemDen" runat="server" Width="142px" AppendDataBoundItems="True">
                                        <asp:ListItem Value="-1">Please Choose!</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <!--Chon ngay đi,ngày về-->
                        <div class="row margin-top-form">
                            <div class="col-md-6">
                                <span class="title-search-mini">Departure date</span>
                                <div class="">
                                    <asp:TextBox CssClass="form-control" ID="txtNgayDi" runat="server" Width="142px" Enabled="False"></asp:TextBox><br />
                                    <asp:Button CssClass="btn btn-success" ID="btnChonNgayDi" runat="server" Text="Choose!" OnClick="btnChonNgayDi_Click" />
                                    <asp:Calendar ID="lichNgayDi" runat="server" Visible="False" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="lichNgayDi_SelectionChanged" ShowGridLines="True" Width="220px">
                                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                        <OtherMonthDayStyle ForeColor="#CC9966" />
                                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                        <SelectorStyle BackColor="#FFCC66" />
                                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                    </asp:Calendar>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <span class="title-search-mini">Return date</span>
                                <div class="">
                                    <asp:TextBox CssClass="form-control" ID="txtNgayVe" runat="server" Width="142px" Enabled="False"></asp:TextBox><br />
                                    <asp:Button CssClass="btn btn-success" ID="btnChonNgayVe" runat="server" Text="Choose!" OnClick="btnChonNgayVe_Click" />
                                    <asp:Calendar ID="lichNgayVe" runat="server" Visible="False" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="lichNgayVe_SelectionChanged" ShowGridLines="True" Width="220px">
                                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                        <OtherMonthDayStyle ForeColor="#CC9966" />
                                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                        <SelectorStyle BackColor="#FFCC66" />
                                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                    </asp:Calendar>
                                </div>
                            </div>
                        </div>
                        <!--Chọn so luong khach-->
                        <div class="row margin-top-form">
                            <div class="col-md-4">
                                <span class="title-search-mini">Adults</span><br />
                                <asp:DropDownList CssClass="form-control" ID="listNguoilon" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-4">
                                <span class="title-search-mini">Children</span><br />
                                <asp:DropDownList CssClass="form-control" ID="listTreem" runat="server">
                                    <asp:ListItem>0</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-4">
                                <span class="title-search-mini">Infant </span>
                                <br />
                                <asp:DropDownList CssClass="form-control" ID="listEmbe" runat="server">
                                    <asp:ListItem>0</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <asp:Button CssClass="btn btn-danger btn btn-default btn-search btn-search-home col-md-12 col-xs-12" ID="searchFlight" runat="server" Text="Search Flights" OnClick="searchFlight_Click"/>
                        </div>
                    </div>
                    <div class="clear"></div>

                </div>


            </div>
            <div class="col-md-8 col-xs-12 nopadding visible-md visible-lg">
                <div class="banner">
                    <div data-ride="carousel" class="home-banner slide" id="home-banner">
                        <!-- Indicators -->
                        <ol class="carousel-indicators">
                            <li class="active" data-slide-to="0" data-target="#home-banner"></li>
                            <li data-slide-to="1" data-target="#home-banner" class=""></li>
                            <li data-slide-to="2" data-target="#home-banner" class=""></li>
                        </ol>

                        <!-- Wrapper for slides -->
                        <div class="carousel-inner">
                            <div class="item active">
                                <a href="#">
                                    <img src="Images/banners/banner-home-f663684be874c981024a219ee3a96175.jpg" class="img-responsive" alt="mytour">
                                </a>
                                &nbsp;
                            </div>
                            <div class="item">
                                <a href="#">
                                    <img src="Images/banners/banner_mytour-35c6ef4f654e03aa2ff793ca50f5fc96.jpg" class="img-responsive" alt="">
                                </a>
                                &nbsp;
                            </div>
                            <div class="item">
                                <a href="#">
                                    <img src="Images/banners/banner-10k-6ffe51bcd002564cfd0c0f8042b9ad64.jpg" class="img-responsive" alt="">
                                </a>
                                &nbsp;
                            </div>

                        </div>

                        <!-- Controls -->
                        <a data-slide="prev" href="#home-banner" class="left carousel-control bo-bg">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </a>
                        <a data-slide="next" href="#home-banner" class="right carousel-control bo-bg">
                            <span class="glyphicon glyphicon-chevron-right"></span>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        
    </div>
    <div class="container">
        <asp:Label ID="lbThongBaoTuyenDI" runat="server" Text=""></asp:Label>
    </div>
    <div class="container">

            <!--Dang sach chuyen bay-->
            <asp:GridView CssClass="table table-bordered" ID="gv_show_Flight" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%" AllowPaging="True" PageSize="5" OnPageIndexChanging="gv_show_Flight_PageIndexChanging" OnRowCommand="gv_show_Flight_RowCommand">
                <AlternatingRowStyle BackColor="Gainsboro" />
                <Columns>
                    <asp:BoundField DataField="FLIGHT_CODE" HeaderText="FLIGHT CODE" />
                    <asp:BoundField DataField="PLANE_CODE" HeaderText="PLANE CODE" />
                    <asp:BoundField DataField="AIRLINE_CODE" HeaderText="AIRLINE CODE" />
                    <asp:BoundField DataField="FLIGHT_DATE_START" HeaderText="DEPARTURE DATE" />
                    <asp:BoundField DataField="FLIGHT_DATE_STOP" HeaderText="RETURN DATE" />
                    <asp:BoundField DataField="FLIGHT_PRICE" HeaderText="PRICE (VND)" />
                    <asp:BoundField DataField="FLIGHT_TOTALSEARTS" HeaderText="TOTALSEATS" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-success" ID="btnDatVe" runat="server" CommandArgument='<%# Bind("FLIGHT_CODE") %>' CommandName="btnDatVe" Text="Booking" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="Black" />
                <HeaderStyle BackColor="#FF3300" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
    <div class="container">
        <asp:Label ID="lbThongBaoTuyenVe" runat="server" Text=""></asp:Label>
    </div>
    <div class="container">

            <!--Dang sach chuyen bay-->
            <asp:GridView CssClass="table table-bordered" ID="gv_show_Return" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%" PageSize="5" AllowPaging="True" OnPageIndexChanging="gv_show_Return_PageIndexChanging" OnRowCommand="gv_show_Return_RowCommand">
                <AlternatingRowStyle BackColor="Gainsboro" />
                <Columns>
                    <asp:BoundField DataField="FLIGHT_CODE" HeaderText="FLIGHT CODE" />
                    <asp:BoundField DataField="PLANE_CODE" HeaderText="PLANE CODE" />
                    <asp:BoundField DataField="AIRLINE_CODE" HeaderText="AIRLINE CODE" />
                    <asp:BoundField DataField="FLIGHT_DATE_START" HeaderText="DEPARTURE DATE" />
                    <asp:BoundField DataField="FLIGHT_DATE_STOP" HeaderText="RETURN DATE" />
                    <asp:BoundField DataField="FLIGHT_PRICE" HeaderText="PRICE (VND)" />
                    <asp:BoundField DataField="FLIGHT_TOTALSEARTS" HeaderText="TOTALSEATS" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="btn btn-success" ID="btnDatVe" runat="server" CommandArgument='<%# Bind("FLIGHT_CODE") %>' CommandName="btnDatVe" Text="Booking" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
</asp:Content>
