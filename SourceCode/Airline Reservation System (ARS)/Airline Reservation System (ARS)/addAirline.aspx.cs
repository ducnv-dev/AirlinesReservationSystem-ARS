using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class addAirline : System.Web.UI.Page
    {
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadListCity(db);
            }
        }

        private void loadListCity(DB_ARSDataContext db)
        {
            var city = from c in db.CITies
                       select new { cityCode = c.CITY_CODE, cityName = c.CITY_NAME };
            listAStart.DataSource = city;
            listAStart.DataTextField = "cityName";
            listAStart.DataValueField = "cityCode";
            listAStart.DataBind();

            listAStop.DataSource = city;
            listAStop.DataTextField = "cityName";
            listAStop.DataValueField = "cityCode";
            listAStop.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            String aCode = txtACode.Text.Trim();
            String acodestart = listAStart.SelectedValue.ToString();
            String acodestop = listAStop.SelectedValue.ToString();
            int Chieudai = Convert.ToInt32(txtChieudai.Text.ToString());

            var start = db.CITies.SingleOrDefault(s=> s.CITY_CODE == acodestart);
            int codeS = start.CITY_ID;
            var stop = db.CITies.SingleOrDefault(s2 => s2.CITY_CODE == acodestop);
            int codeStop = stop.CITY_ID;
            int active = 1;

            if (rdoActive.Checked)
            {
                active = 1;
            }
            if (rdoNoActive.Checked)
            {
                active = 0;
            }

            AIRLINE a = new AIRLINE();

            a.AIRLINE_CODE = aCode;
            a.AIRLINE_CITY_ID_START = codeS;
            a.AIRLINE_CITY_ID_STOP = codeStop;
            a.AIRLINE_DISTANCE = Chieudai;
            a.AIRLINE_STATUS = active;

            db.AIRLINEs.InsertOnSubmit(a);
            db.SubmitChanges();
            txtThongbao.Text = "Add Success!";
        }

        protected void listAStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void listAStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String acodestart = listAStart.SelectedValue.ToString();
            String acodestop = listAStop.SelectedValue.ToString();

            txtACode.Text = "AIRLINE-" + acodestart+"-" + acodestop;
        }
    }
}