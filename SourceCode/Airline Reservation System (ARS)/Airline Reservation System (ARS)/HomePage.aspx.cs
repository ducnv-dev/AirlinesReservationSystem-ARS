using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class Default : System.Web.UI.Page
    {
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadListCity(db);
                loadAllFlight();
            }
        }

        private void loadAllFlight()
        {
            var flight = from f in db.FLIGHTs
                         join p in db.PLANEs on f.FLIGHT_PLANE_ID equals p.PLANE_ID
                         join a in db.AIRLINEs on f.FLIGHT_AIRLINE_ID equals a.AIRLINE_ID
                         select new { f.FLIGHT_CODE, p.PLANE_CODE, a.AIRLINE_CODE, f.FLIGHT_DATE_START, f.FLIGHT_DATE_STOP, f.FLIGHT_PRICE, f.FLIGHT_TOTALSEARTS };
            gv_show_Flight.DataSource = flight.ToList();
            gv_show_Flight.DataBind();
        }

        private void loadListCity(DB_ARSDataContext db)
        {
            var city = from c in db.CITies
                       select new { cityCode = c.CITY_CODE, cityName = c.CITY_NAME };
            listDiemDi.DataSource = city;
            listDiemDi.DataTextField = "cityName";
            listDiemDi.DataValueField = "cityCode";
            listDiemDi.DataBind();

            listDiemDen.DataSource = city;
            listDiemDen.DataTextField = "cityName";
            listDiemDen.DataValueField = "cityCode";
            listDiemDen.DataBind();

        }

        protected void btnChonNgayDi_Click(object sender, EventArgs e)
        {
            lichNgayDi.Visible = true;
        }

        protected void btnChonNgayVe_Click(object sender, EventArgs e)
        {
            lichNgayVe.Visible = true;
        }

        protected void lichNgayDi_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayDi.Text = lichNgayDi.SelectedDate.ToShortDateString();
            lichNgayDi.Visible = false;
        }

        protected void lichNgayVe_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayVe.Text = lichNgayVe.SelectedDate.ToShortDateString();
            lichNgayVe.Visible = false;
        }

        protected void searchFlight_Click(object sender, EventArgs e)
        {
            String CityCodeStart = listDiemDi.SelectedValue.ToString();
            String CityCodeStop = listDiemDen.SelectedValue.ToString();
            String flight_Code = "AIRLINE-" + CityCodeStart + "-" + CityCodeStop;
            String flight_Code_return = "AIRLINE-" + CityCodeStop + "-" + CityCodeStart;
            String dateStart = txtNgayDi.Text;
            String dateReturn = txtNgayVe.Text;
            int nguoilon = Convert.ToInt32(listNguoilon.SelectedValue.ToString());
            int treem = Convert.ToInt32(listTreem.SelectedValue.ToString());
            int embe = Convert.ToInt32(listEmbe.SelectedValue.ToString());
            int tongsokhach = nguoilon + treem + embe;
            

            if (rbt1Chieu.Checked)
            {
                var airline = db.AIRLINEs.SingleOrDefault(a => a.AIRLINE_CODE == flight_Code);
                if (airline != null)
                {
                    int airlineID = airline.AIRLINE_ID;
                    lbThongBaoTuyenDI.Text = "Flight from : " + CityCodeStart + " to " + CityCodeStop + " Date :" + dateStart;
                    var search_flight = from f in db.FLIGHTs
                                        join p in db.PLANEs on f.FLIGHT_PLANE_ID equals p.PLANE_ID
                                        join a in db.AIRLINEs on f.FLIGHT_AIRLINE_ID equals a.AIRLINE_ID
                                        where (f.FLIGHT_AIRLINE_ID == airlineID && f.FLIGHT_DATE_START == dateStart)
                                        select new { f.FLIGHT_CODE, p.PLANE_CODE, a.AIRLINE_CODE, f.FLIGHT_DATE_START, f.FLIGHT_DATE_STOP, f.FLIGHT_PRICE, f.FLIGHT_TOTALSEARTS };
                    gv_show_Flight.DataSource = search_flight.ToList();
                    gv_show_Flight.DataBind();
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
            if (rbt2Chieu.Checked)
            {
                var airline = db.AIRLINEs.SingleOrDefault(a => a.AIRLINE_CODE == flight_Code);
                if (airline != null)
                {
                    int airlineID = airline.AIRLINE_ID;
                    lbThongBaoTuyenDI.Text = "Flight from : " + CityCodeStart + " to " + CityCodeStop + " Date :" + dateStart;
                    var search_flight = from f in db.FLIGHTs
                                        join p in db.PLANEs on f.FLIGHT_PLANE_ID equals p.PLANE_ID
                                        join a in db.AIRLINEs on f.FLIGHT_AIRLINE_ID equals a.AIRLINE_ID
                                        where (f.FLIGHT_AIRLINE_ID == airlineID && f.FLIGHT_DATE_START == dateStart)
                                        select new { f.FLIGHT_CODE, p.PLANE_CODE, a.AIRLINE_CODE, f.FLIGHT_DATE_START, f.FLIGHT_DATE_STOP, f.FLIGHT_PRICE, f.FLIGHT_TOTALSEARTS };
                    gv_show_Flight.DataSource = search_flight.ToList();
                    gv_show_Flight.DataBind();
                    //gv_show_Return.DataSource = search_flight.ToList();
                    //gv_show_Return.DataBind();
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
                //RETURN
                var airline2 = db.AIRLINEs.SingleOrDefault(a => a.AIRLINE_CODE == flight_Code_return);
                if (airline2 != null)
                {
                    int airlineID = airline2.AIRLINE_ID;
                    lbThongBaoTuyenVe.Text = "Flight from : " + CityCodeStart + " to " + CityCodeStop + " Date :" + dateReturn;
                    var search_flight2 = from f in db.FLIGHTs
                                         join p in db.PLANEs on f.FLIGHT_PLANE_ID equals p.PLANE_ID
                                         join a in db.AIRLINEs on f.FLIGHT_AIRLINE_ID equals a.AIRLINE_ID
                                         where (f.FLIGHT_AIRLINE_ID == airlineID && f.FLIGHT_DATE_STOP == dateReturn)
                                         select new { f.FLIGHT_CODE, p.PLANE_CODE, a.AIRLINE_CODE, f.FLIGHT_DATE_START, f.FLIGHT_DATE_STOP, f.FLIGHT_PRICE, f.FLIGHT_TOTALSEARTS };
                    gv_show_Return.DataSource = search_flight2.ToList();
                    gv_show_Return.DataBind();
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }




        }

        protected void gv_show_Flight_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_show_Flight.PageIndex = e.NewPageIndex;
            loadAllFlight();
        }

        protected void gv_show_Flight_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String fCode = e.CommandArgument.ToString();
            int slNguoilon = Convert.ToInt32(listNguoilon.SelectedValue.ToString());
            int slTreem = Convert.ToInt32(listTreem.SelectedValue.ToString());
            int slEmbe = Convert.ToInt32(listEmbe.SelectedValue.ToString());
            if (e.CommandName=="btnDatVe")
            {
                Session["datve"] = fCode;
                Session["fCode"] = fCode;
                Session["slnguoilon"] = slNguoilon;
                Session["sltreem"] = slTreem;
                Session["slembe"] = slEmbe;
                

                //Response.Redirect("~/addTickets.aspx?fCode="+fCode);
                var url = String.Format("~/addTickets.aspx?fCode={0}&slNguoiLon={1}&slTreEm={2}&slEmBe={3}", fCode, slNguoilon, slTreem, slEmbe);
                Response.Redirect(url);
            }
        }

        protected void gv_show_Return_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_show_Return.PageIndex = e.NewPageIndex;
        }

        protected void gv_show_Return_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            String fCode = e.CommandArgument.ToString();
            int slNguoilon =Convert.ToInt32( listNguoilon.SelectedValue.ToString());
            int slTreem = Convert.ToInt32(listTreem.SelectedValue.ToString());
            int slEmbe = Convert.ToInt32(listEmbe.SelectedValue.ToString());
            if (e.CommandName == "btnDatVe")
            {
                Session["datve"] = fCode;
                //Response.Redirect("~/addTickets.aspx?fCode=" + fCode + "&slNguoiLon=" + slNguoilon + "&slTreEm=" + slTreem + "&slEmBe=" + slEmbe);
                //Response.Redirect("~/addTickets.aspx?fCode=" + fCode);
                var url = String.Format("~/addTickets.aspx?fCode={0}&slNguoiLon={1}&slTreEm={2}&slEmBe={3}",fCode,slNguoilon,slTreem,slEmbe);
                Response.Redirect(url);
            }
        }

    }
}