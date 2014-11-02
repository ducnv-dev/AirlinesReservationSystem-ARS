using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            logout.Visible = false;
            String user = Session["userlogin"].ToString();
            if (!user.Equals(""))
            {
                
                login.Text = user;
                login.Enabled = false;
                logout.Visible = true;

            }
            
            
        }

        
    }
}