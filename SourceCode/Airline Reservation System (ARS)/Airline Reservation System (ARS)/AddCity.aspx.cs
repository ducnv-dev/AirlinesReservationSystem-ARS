using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class AddCity : System.Web.UI.Page
    {
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            String cityCode = txtCityCode.Text.Trim();
            String cityName = txtCityName.Text.Trim();
            int active = 1;
            if (rdoactive.Checked)
            {
                active = 1;
            } if (rdonotactive.Checked)
            {
                active = 0;
            }
            CITY c = new CITY();
            c.CITY_CODE = cityCode;
            c.CITY_NAME = cityName;
            c.CITY_STATUS = active;

            db.CITies.InsertOnSubmit(c);
            db.SubmitChanges();
            myclear();
            txtThongbaothemcity.Text = "Add Success!";
        }

        protected void btnHuy_Click(object sender, EventArgs e)
        {
            myclear();
        }

        private void myclear()
        {
            txtCityCode.Text = "";
            txtCityName.Text = "";
            txtThongbaothemcity.Text = "";
        }
    }
}