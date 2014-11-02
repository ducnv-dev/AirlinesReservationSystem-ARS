using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class addFlight : System.Web.UI.Page
    {
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showListPlane(db);
                showListAirline(db);
            }
        }

        private void showListAirline(DB_ARSDataContext db)
        {
            var airline = from a in db.AIRLINEs
                          select new { airlineCode = a.AIRLINE_CODE, airlineID = a.AIRLINE_ID };
            ListAirLineCode.DataSource = airline;
            ListAirLineCode.DataTextField = "airlineCode";
            ListAirLineCode.DataValueField = "airlineID";
            ListAirLineCode.DataBind();
        }

        private void showListPlane(DB_ARSDataContext db)
        {
            var plane = from p in db.PLANEs
                        select new { planeCode = p.PLANE_CODE, planeName = p.PLANE_NAME };
            listPlance.DataSource = plane;
            listPlance.DataTextField = "planeName";
            listPlance.DataValueField = "planeCode";
            listPlance.DataBind();
        }

        protected void btnChonLichDi_Click(object sender, EventArgs e)
        {
            CalendarDi.Visible = true;
        }

        protected void btnChonLichDen_Click(object sender, EventArgs e)
        {
            CalendarDen.Visible = true;
        }

        protected void ListAirLineCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            String airlineCode = ListAirLineCode.SelectedItem.ToString();
            txtFcode.Text = "FLIGHT-" + airlineCode;
        }

        protected void CalendarDi_SelectionChanged(object sender, EventArgs e)
        {
            String datestart = CalendarDi.SelectedDate.ToShortDateString();
            txtdateStart.Text = datestart;
            CalendarDi.Visible = false;
        }

        //protected void CalendarDen_SelectionChanged(object sender, EventArgs e)
        //{
        //    String dateStop = CalendarDen.SelectedDate.ToShortDateString();
        //    txtdateEnd.Text = dateStop;
        //    CalendarDen.Visible = false;
        //}

        //protected void listPlance_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    String pCode = listPlance.SelectedValue.ToString();

        //    var p = db.PLANEs.SingleOrDefault(p1=>p1.PLANE_CODE==pCode);
        //    String seat = p.PLANE_TOTALSEATS;
        //    txtTotalSeat.Text = seat;
        //}

        protected void listPlance_SelectedIndexChanged1(object sender, EventArgs e)
        {
            String pCode = listPlance.SelectedValue.ToString();

            var p = db.PLANEs.SingleOrDefault(p1 => p1.PLANE_CODE == pCode);
            String seat = p.PLANE_TOTALSEATS;
            txtTotalSeat.Text = seat;
        }

        protected void CalendarDen_SelectionChanged1(object sender, EventArgs e)
        {
            String dateStop = CalendarDen.SelectedDate.ToShortDateString();
            txtdateEnd.Text = dateStop;
            CalendarDen.Visible = false;
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            String FCode = txtFcode.Text;
            String PCode = listPlance.SelectedValue.ToString();
            String ACode = ListAirLineCode.SelectedItem.ToString();
            String dateStart = txtdateStart.Text;
            String dateStop = txtdateEnd.Text;
            int FPrice = Convert.ToInt32(txtFPrice.Text);
            int FSeat = Convert.ToInt32(txtTotalSeat.Text);
            int active = 1;

            if (RadioActive.Checked)
            {
                active = 1;
            } if (RadionotActive.Checked)
            {
                active = 0;
            }

            var p = db.PLANEs.SingleOrDefault(p1 => p1.PLANE_CODE==PCode);
            int pID = p.PLANE_ID;
            var a = db.AIRLINEs.SingleOrDefault(a1=>a1.AIRLINE_CODE==ACode);
            int aID = a.AIRLINE_ID;

            FLIGHT f = new FLIGHT();

            f.FLIGHT_CODE = FCode;
            f.FLIGHT_PLANE_ID = pID;
            f.FLIGHT_AIRLINE_ID = aID;
            f.FLIGHT_DATE_START = dateStart;
            f.FLIGHT_DATE_STOP = dateStop;
            f.FLIGHT_PRICE = FPrice;
            f.FLIGHT_TOTALSEARTS = FSeat;
            f.FLIGHT_STATUS = active;

            db.FLIGHTs.InsertOnSubmit(f);
            db.SubmitChanges();
            txtThongBaoAddFligt.Text = "Add Success!";
        }
    }
}