using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class login : System.Web.UI.Page
    {
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userlogin"] = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtusername.Text.Trim();
            String pass = txtpassword.Text.Trim();

            var login = db.USERs.SingleOrDefault(l => l.USERS_USERNAME == user);
            if (login == null)
            {

            }
            if (login.USERS_PASSWORD == pass)
            {
                if (Session["datve"].ToString().Equals(""))
                {
                    Session["userlogin"] = login.USERS_FULLNAME.ToString();
                    Response.Redirect("~/HomePage.aspx");
                }
                else
                {
                    Session["userlogin"] = login.USERS_FULLNAME.ToString();
                    //Session["datve"] = login.USERS_FULLNAME.ToString();
                    Response.Redirect("~/addTickets.aspx");
                }


            }
        }
    }
}