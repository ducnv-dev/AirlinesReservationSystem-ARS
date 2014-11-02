using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class addPlane : System.Web.UI.Page
    {
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            String planeCode = txtPlaneCode.Text.Trim();
            String planeName = txtPlaneName.Text.Trim();
            String total =txttotalseats.Text.Trim();
            int active = 1;
            if (rdoactive.Checked)
            {
                active = 1;
            } if (rdonotactive.Checked)
            {
                active = 0;
            }
            PLANE p = new PLANE();
            p.PLANE_CODE = planeCode;
            p.PLANE_NAME = planeName;
            p.PLANE_TOTALSEATS = total;
            p.PLANE_STATUS = active;

            db.PLANEs.InsertOnSubmit(p);
            db.SubmitChanges();
            txtThongbaothem.Text = "Add Success!";
        }
    }
}