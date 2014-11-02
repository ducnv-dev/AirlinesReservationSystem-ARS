using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airline_Reservation_System__ARS_
{
    public partial class addTickets : System.Web.UI.Page
    {
        
        DB_ARSDataContext db = new DB_ARSDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            //String fcode = Request.QueryString["fCode"];
            //Response.Write("<h1>"+fcode+"</h1>");
            if (!IsPostBack)
            {
                String isLogin = Session["userlogin"].ToString();
                if (isLogin.Equals(""))
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    loadInfo();
                    checkslKhachHang();
                }
            }
        }

       

        public void get1custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u=> u.USERS_FULLNAME==userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f=> f.FLIGHT_CODE==fCode);
            int flightID= getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            btnBack.Visible = true;
            //Response.Write("<script>alert('Tickets saved successfully!');</script>");

        }

        private void get2custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            //table2.Visible = true;
            //table3.Visible = true;
            //table4.Visible = true;
            //table5.Visible = true;
            //table6.Visible = true;
            //table7.Visible = true;
            //table8.Visible = true;
            //table9.Visible = true;
            btnBack.Visible = true;
        }

        private void get3custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            //table3.Visible = true;
            //table4.Visible = true;
            //table5.Visible = true;
            //table6.Visible = true;
            //table7.Visible = true;
            //table8.Visible = true;
            //table9.Visible = true;
            btnBack.Visible = true;
        }

        private void get4custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            //table4.Visible = true;
            //table5.Visible = true;
            //table6.Visible = true;
            //table7.Visible = true;
            //table8.Visible = true;
            //table9.Visible = true;
            btnBack.Visible = true;
        }

        private void get5custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String Name5 = txtFullName5.Text;
            String Pass5 = txtPass5.Text;
            String Adress5 = txtAdress5.Text;
            String Phone5 = txtPhone1.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();

            TICKET t5 = new TICKET();
            t5.TICKETS_CODE = "TICKETS-" + fCode;
            t5.TICKETS_USER_ID = userID;
            t5.TICKETS_FLIGHT_ID = flightID;
            t5.TICKETS_PRICE = Price.ToString();

            t5.TICKETS_CUSTOME_FULLNAME = Name5; ;
            t5.TICKETS_CUSTOMER_ADDRESS = Adress5;
            t5.TICKETS_PASSPORT = Pass5;
            t5.TICKETS_CUSTOMER_PHONE = Phone5;

            db.TICKETs.InsertOnSubmit(t5);
            db.SubmitChanges();
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            table4.Enabled = false;
            //table5.Visible = true;
            //table6.Visible = true;
            //table7.Visible = true;
            //table8.Visible = true;
            //table9.Visible = true;
            btnBack.Visible = true;
        }

        private void get6custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String Name5 = txtFullName5.Text;
            String Pass5 = txtPass5.Text;
            String Adress5 = txtAdress5.Text;
            String Phone5 = txtPhone1.Text;

            String Name6 = txtFullName6.Text;
            String Pass6 = txtPass6.Text;
            String Adress6 = txtAdress6.Text;
            String Phone6 = txtPhone6.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();

            TICKET t5 = new TICKET();
            t5.TICKETS_CODE = "TICKETS-" + fCode;
            t5.TICKETS_USER_ID = userID;
            t5.TICKETS_FLIGHT_ID = flightID;
            t5.TICKETS_PRICE = Price.ToString();

            t5.TICKETS_CUSTOME_FULLNAME = Name5; ;
            t5.TICKETS_CUSTOMER_ADDRESS = Adress5;
            t5.TICKETS_PASSPORT = Pass5;
            t5.TICKETS_CUSTOMER_PHONE = Phone5;

            db.TICKETs.InsertOnSubmit(t5);
            db.SubmitChanges();

            TICKET t6 = new TICKET();
            t6.TICKETS_CODE = "TICKETS-" + fCode;
            t6.TICKETS_USER_ID = userID;
            t6.TICKETS_FLIGHT_ID = flightID;
            t6.TICKETS_PRICE = Price.ToString();

            t6.TICKETS_CUSTOME_FULLNAME = Name6; ;
            t6.TICKETS_CUSTOMER_ADDRESS = Adress6;
            t6.TICKETS_PASSPORT = Pass6;
            t6.TICKETS_CUSTOMER_PHONE = Phone6;

            db.TICKETs.InsertOnSubmit(t6);
            db.SubmitChanges();

           


            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            table4.Enabled = false;
            table5.Enabled = false;
            

            btnBack.Visible = true;
        }

        private void get7custom()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String Name5 = txtFullName5.Text;
            String Pass5 = txtPass5.Text;
            String Adress5 = txtAdress5.Text;
            String Phone5 = txtPhone1.Text;

            String Name6 = txtFullName6.Text;
            String Pass6 = txtPass6.Text;
            String Adress6 = txtAdress6.Text;
            String Phone6 = txtPhone6.Text;

            String Name7 = txtFullName7.Text;
            String Pass7 = txtPass7.Text;
            String Adress7 = txtAdress7.Text;
            String Phone7 = txtpPhone7.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();

            TICKET t5 = new TICKET();
            t5.TICKETS_CODE = "TICKETS-" + fCode;
            t5.TICKETS_USER_ID = userID;
            t5.TICKETS_FLIGHT_ID = flightID;
            t5.TICKETS_PRICE = Price.ToString();

            t5.TICKETS_CUSTOME_FULLNAME = Name5; ;
            t5.TICKETS_CUSTOMER_ADDRESS = Adress5;
            t5.TICKETS_PASSPORT = Pass5;
            t5.TICKETS_CUSTOMER_PHONE = Phone5;

            db.TICKETs.InsertOnSubmit(t5);
            db.SubmitChanges();

            TICKET t6 = new TICKET();
            t6.TICKETS_CODE = "TICKETS-" + fCode;
            t6.TICKETS_USER_ID = userID;
            t6.TICKETS_FLIGHT_ID = flightID;
            t6.TICKETS_PRICE = Price.ToString();

            t6.TICKETS_CUSTOME_FULLNAME = Name6; ;
            t6.TICKETS_CUSTOMER_ADDRESS = Adress6;
            t6.TICKETS_PASSPORT = Pass6;
            t6.TICKETS_CUSTOMER_PHONE = Phone6;

            db.TICKETs.InsertOnSubmit(t6);
            db.SubmitChanges();

            TICKET t7 = new TICKET();
            t7.TICKETS_CODE = "TICKETS-" + fCode;
            t7.TICKETS_USER_ID = userID;
            t7.TICKETS_FLIGHT_ID = flightID;
            t7.TICKETS_PRICE = Price.ToString();

            t7.TICKETS_CUSTOME_FULLNAME = Name7; ;
            t7.TICKETS_CUSTOMER_ADDRESS = Adress7;
            t7.TICKETS_PASSPORT = Pass7;
            t7.TICKETS_CUSTOMER_PHONE = Phone7;

            db.TICKETs.InsertOnSubmit(t7);
            db.SubmitChanges();

            
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            table4.Enabled = false;
            table5.Enabled = false;
            table6.Enabled = false;
            
            btnBack.Visible = true;
        }

        private void get8customer()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String Name5 = txtFullName5.Text;
            String Pass5 = txtPass5.Text;
            String Adress5 = txtAdress5.Text;
            String Phone5 = txtPhone1.Text;

            String Name6 = txtFullName6.Text;
            String Pass6 = txtPass6.Text;
            String Adress6 = txtAdress6.Text;
            String Phone6 = txtPhone6.Text;

            String Name7 = txtFullName7.Text;
            String Pass7 = txtPass7.Text;
            String Adress7 = txtAdress7.Text;
            String Phone7 = txtpPhone7.Text;

            String Name8 = txtFullName8.Text;
            String Pass8 = txtPass8.Text;
            String Adress8 = txtAddress8.Text;
            String Phone8 = txtPhone8.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();

            TICKET t5 = new TICKET();
            t5.TICKETS_CODE = "TICKETS-" + fCode;
            t5.TICKETS_USER_ID = userID;
            t5.TICKETS_FLIGHT_ID = flightID;
            t5.TICKETS_PRICE = Price.ToString();

            t5.TICKETS_CUSTOME_FULLNAME = Name5; ;
            t5.TICKETS_CUSTOMER_ADDRESS = Adress5;
            t5.TICKETS_PASSPORT = Pass5;
            t5.TICKETS_CUSTOMER_PHONE = Phone5;

            db.TICKETs.InsertOnSubmit(t5);
            db.SubmitChanges();

            TICKET t6 = new TICKET();
            t6.TICKETS_CODE = "TICKETS-" + fCode;
            t6.TICKETS_USER_ID = userID;
            t6.TICKETS_FLIGHT_ID = flightID;
            t6.TICKETS_PRICE = Price.ToString();

            t6.TICKETS_CUSTOME_FULLNAME = Name6; ;
            t6.TICKETS_CUSTOMER_ADDRESS = Adress6;
            t6.TICKETS_PASSPORT = Pass6;
            t6.TICKETS_CUSTOMER_PHONE = Phone6;

            db.TICKETs.InsertOnSubmit(t6);
            db.SubmitChanges();

            TICKET t7 = new TICKET();
            t7.TICKETS_CODE = "TICKETS-" + fCode;
            t7.TICKETS_USER_ID = userID;
            t7.TICKETS_FLIGHT_ID = flightID;
            t7.TICKETS_PRICE = Price.ToString();

            t7.TICKETS_CUSTOME_FULLNAME = Name7; ;
            t7.TICKETS_CUSTOMER_ADDRESS = Adress7;
            t7.TICKETS_PASSPORT = Pass7;
            t7.TICKETS_CUSTOMER_PHONE = Phone7;

            db.TICKETs.InsertOnSubmit(t7);
            db.SubmitChanges();

            TICKET t8 = new TICKET();
            t8.TICKETS_CODE = "TICKETS-" + fCode;
            t8.TICKETS_USER_ID = userID;
            t8.TICKETS_FLIGHT_ID = flightID;
            t8.TICKETS_PRICE = Price.ToString();

            t8.TICKETS_CUSTOME_FULLNAME = Name8; ;
            t8.TICKETS_CUSTOMER_ADDRESS = Adress8;
            t8.TICKETS_PASSPORT = Pass8;
            t8.TICKETS_CUSTOMER_PHONE = Phone8;

            db.TICKETs.InsertOnSubmit(t8);
            db.SubmitChanges();

            
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            table4.Enabled = false;
            table5.Enabled = false;
            table6.Enabled = false;
            table7.Enabled = false;
           
            btnBack.Visible = true;
        }

        private void get9custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String Name5 = txtFullName5.Text;
            String Pass5 = txtPass5.Text;
            String Adress5 = txtAdress5.Text;
            String Phone5 = txtPhone1.Text;

            String Name6 = txtFullName6.Text;
            String Pass6 = txtPass6.Text;
            String Adress6 = txtAdress6.Text;
            String Phone6 = txtPhone6.Text;

            String Name7 = txtFullName7.Text;
            String Pass7 = txtPass7.Text;
            String Adress7 = txtAdress7.Text;
            String Phone7 = txtpPhone7.Text;

            String Name8 = txtFullName8.Text;
            String Pass8 = txtPass8.Text;
            String Adress8 = txtAddress8.Text;
            String Phone8 = txtPhone8.Text;

            String Name9 = txtFullName9.Text;
            String Pass9 = txtPass9.Text;
            String Adress9 = txtAdress9.Text;
            String Phone9 = txtPhone9.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();

            TICKET t5 = new TICKET();
            t5.TICKETS_CODE = "TICKETS-" + fCode;
            t5.TICKETS_USER_ID = userID;
            t5.TICKETS_FLIGHT_ID = flightID;
            t5.TICKETS_PRICE = Price.ToString();

            t5.TICKETS_CUSTOME_FULLNAME = Name5; ;
            t5.TICKETS_CUSTOMER_ADDRESS = Adress5;
            t5.TICKETS_PASSPORT = Pass5;
            t5.TICKETS_CUSTOMER_PHONE = Phone5;

            db.TICKETs.InsertOnSubmit(t5);
            db.SubmitChanges();

            TICKET t6 = new TICKET();
            t6.TICKETS_CODE = "TICKETS-" + fCode;
            t6.TICKETS_USER_ID = userID;
            t6.TICKETS_FLIGHT_ID = flightID;
            t6.TICKETS_PRICE = Price.ToString();

            t6.TICKETS_CUSTOME_FULLNAME = Name6; ;
            t6.TICKETS_CUSTOMER_ADDRESS = Adress6;
            t6.TICKETS_PASSPORT = Pass6;
            t6.TICKETS_CUSTOMER_PHONE = Phone6;

            db.TICKETs.InsertOnSubmit(t6);
            db.SubmitChanges();

            TICKET t7 = new TICKET();
            t7.TICKETS_CODE = "TICKETS-" + fCode;
            t7.TICKETS_USER_ID = userID;
            t7.TICKETS_FLIGHT_ID = flightID;
            t7.TICKETS_PRICE = Price.ToString();

            t7.TICKETS_CUSTOME_FULLNAME = Name7; ;
            t7.TICKETS_CUSTOMER_ADDRESS = Adress7;
            t7.TICKETS_PASSPORT = Pass7;
            t7.TICKETS_CUSTOMER_PHONE = Phone7;

            db.TICKETs.InsertOnSubmit(t7);
            db.SubmitChanges();

            TICKET t8 = new TICKET();
            t8.TICKETS_CODE = "TICKETS-" + fCode;
            t8.TICKETS_USER_ID = userID;
            t8.TICKETS_FLIGHT_ID = flightID;
            t8.TICKETS_PRICE = Price.ToString();

            t8.TICKETS_CUSTOME_FULLNAME = Name8; ;
            t8.TICKETS_CUSTOMER_ADDRESS = Adress8;
            t8.TICKETS_PASSPORT = Pass8;
            t8.TICKETS_CUSTOMER_PHONE = Phone8;

            db.TICKETs.InsertOnSubmit(t8);
            db.SubmitChanges();

            TICKET t9 = new TICKET();
            t9.TICKETS_CODE = "TICKETS-" + fCode;
            t9.TICKETS_USER_ID = userID;
            t9.TICKETS_FLIGHT_ID = flightID;
            t9.TICKETS_PRICE = Price.ToString();

            t9.TICKETS_CUSTOME_FULLNAME = Name9; ;
            t9.TICKETS_CUSTOMER_ADDRESS = Adress9;
            t9.TICKETS_PASSPORT = Pass9;
            t9.TICKETS_CUSTOMER_PHONE = Phone9;

            db.TICKETs.InsertOnSubmit(t9);
            db.SubmitChanges();

           
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            table4.Enabled = false;
            table5.Enabled = false;
            table6.Enabled = false;
            table7.Enabled = false;
            table8.Enabled = false;
            
            btnBack.Visible = true;
        }

        public void get10custome()
        {
            String Name1 = txtFullName1.Text;
            String Pass1 = txtPass1.Text;
            String Adress1 = txtAddress1.Text;
            String Phone1 = txtPhone1.Text;

            String Name2 = txtFullName2.Text;
            String Pass2 = txtPass2.Text;
            String Adress2 = txtAdress2.Text;
            String Phone2 = txtPhone2.Text;

            String Name3 = txtFullName3.Text;
            String Pass3 = txtPass3.Text;
            String Adress3 = txtAddress3.Text;
            String Phone3 = txtPhone3.Text;

            String Name4 = txtFullName4.Text;
            String Pass4 = txtPass4.Text;
            String Adress4 = txtAdress4.Text;
            String Phone4 = txtPhone4.Text;

            String Name5 = txtFullName5.Text;
            String Pass5 = txtPass5.Text;
            String Adress5 = txtAdress5.Text;
            String Phone5 = txtPhone1.Text;

            String Name6 = txtFullName6.Text;
            String Pass6 = txtPass6.Text;
            String Adress6 = txtAdress6.Text;
            String Phone6 = txtPhone6.Text;

            String Name7 = txtFullName7.Text;
            String Pass7 = txtPass7.Text;
            String Adress7 = txtAdress7.Text;
            String Phone7 = txtpPhone7.Text;

            String Name8 = txtFullName8.Text;
            String Pass8 = txtPass8.Text;
            String Adress8 = txtAddress8.Text;
            String Phone8 = txtPhone8.Text;

            String Name9 = txtFullName9.Text;
            String Pass9 = txtPass9.Text;
            String Adress9 = txtAdress9.Text;
            String Phone9 = txtPhone9.Text;

            String Name10 = txtFullName10.Text;
            String Pass10 = txtPass10.Text;
            String Adress10 = txtAdress10.Text;
            String Phone10 = txtPhone10.Text;

            String fCode = Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            var getUserID = db.USERs.SingleOrDefault(u => u.USERS_FULLNAME == userLogin);
            int userID = getUserID.USERS_ID;
            var getFlightID = db.FLIGHTs.FirstOrDefault(f => f.FLIGHT_CODE == fCode);
            int flightID = getFlightID.FLIGHT_ID;
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;

            TICKET t = new TICKET();
            t.TICKETS_CODE = "TICKETS-" + fCode;
            t.TICKETS_USER_ID = userID;
            t.TICKETS_FLIGHT_ID = flightID;
            t.TICKETS_PRICE = Price.ToString();

            t.TICKETS_CUSTOME_FULLNAME = Name1; ;
            t.TICKETS_CUSTOMER_ADDRESS = Adress1;
            t.TICKETS_PASSPORT = Pass1;
            t.TICKETS_CUSTOMER_PHONE = Phone1;

            db.TICKETs.InsertOnSubmit(t);
            db.SubmitChanges();

            TICKET t2 = new TICKET();
            t2.TICKETS_CODE = "TICKETS-" + fCode;
            t2.TICKETS_USER_ID = userID;
            t2.TICKETS_FLIGHT_ID = flightID;
            t2.TICKETS_PRICE = Price.ToString();

            t2.TICKETS_CUSTOME_FULLNAME = Name2; ;
            t2.TICKETS_CUSTOMER_ADDRESS = Adress2;
            t2.TICKETS_PASSPORT = Pass2;
            t2.TICKETS_CUSTOMER_PHONE = Phone2;

            db.TICKETs.InsertOnSubmit(t2);
            db.SubmitChanges();

            TICKET t3 = new TICKET();
            t3.TICKETS_CODE = "TICKETS-" + fCode;
            t3.TICKETS_USER_ID = userID;
            t3.TICKETS_FLIGHT_ID = flightID;
            t3.TICKETS_PRICE = Price.ToString();

            t3.TICKETS_CUSTOME_FULLNAME = Name3; ;
            t3.TICKETS_CUSTOMER_ADDRESS = Adress3;
            t3.TICKETS_PASSPORT = Pass3;
            t3.TICKETS_CUSTOMER_PHONE = Phone3;

            db.TICKETs.InsertOnSubmit(t3);
            db.SubmitChanges();

            TICKET t4 = new TICKET();
            t4.TICKETS_CODE = "TICKETS-" + fCode;
            t4.TICKETS_USER_ID = userID;
            t4.TICKETS_FLIGHT_ID = flightID;
            t4.TICKETS_PRICE = Price.ToString();

            t4.TICKETS_CUSTOME_FULLNAME = Name4; ;
            t4.TICKETS_CUSTOMER_ADDRESS = Adress4;
            t4.TICKETS_PASSPORT = Pass4;
            t4.TICKETS_CUSTOMER_PHONE = Phone4;

            db.TICKETs.InsertOnSubmit(t4);
            db.SubmitChanges();

            TICKET t5 = new TICKET();
            t5.TICKETS_CODE = "TICKETS-" + fCode;
            t5.TICKETS_USER_ID = userID;
            t5.TICKETS_FLIGHT_ID = flightID;
            t5.TICKETS_PRICE = Price.ToString();

            t5.TICKETS_CUSTOME_FULLNAME = Name5; ;
            t5.TICKETS_CUSTOMER_ADDRESS = Adress5;
            t5.TICKETS_PASSPORT = Pass5;
            t5.TICKETS_CUSTOMER_PHONE = Phone5;

            db.TICKETs.InsertOnSubmit(t5);
            db.SubmitChanges();

            TICKET t6 = new TICKET();
            t6.TICKETS_CODE = "TICKETS-" + fCode;
            t6.TICKETS_USER_ID = userID;
            t6.TICKETS_FLIGHT_ID = flightID;
            t6.TICKETS_PRICE = Price.ToString();

            t6.TICKETS_CUSTOME_FULLNAME = Name6; ;
            t6.TICKETS_CUSTOMER_ADDRESS = Adress6;
            t6.TICKETS_PASSPORT = Pass6;
            t6.TICKETS_CUSTOMER_PHONE = Phone6;

            db.TICKETs.InsertOnSubmit(t6);
            db.SubmitChanges();

            TICKET t7 = new TICKET();
            t7.TICKETS_CODE = "TICKETS-" + fCode;
            t7.TICKETS_USER_ID = userID;
            t7.TICKETS_FLIGHT_ID = flightID;
            t7.TICKETS_PRICE = Price.ToString();

            t7.TICKETS_CUSTOME_FULLNAME = Name7; ;
            t7.TICKETS_CUSTOMER_ADDRESS = Adress7;
            t7.TICKETS_PASSPORT = Pass7;
            t7.TICKETS_CUSTOMER_PHONE = Phone7;

            db.TICKETs.InsertOnSubmit(t7);
            db.SubmitChanges();

            TICKET t8 = new TICKET();
            t8.TICKETS_CODE = "TICKETS-" + fCode;
            t8.TICKETS_USER_ID = userID;
            t8.TICKETS_FLIGHT_ID = flightID;
            t8.TICKETS_PRICE = Price.ToString();

            t8.TICKETS_CUSTOME_FULLNAME = Name8; ;
            t8.TICKETS_CUSTOMER_ADDRESS = Adress8;
            t8.TICKETS_PASSPORT = Pass8;
            t8.TICKETS_CUSTOMER_PHONE = Phone8;

            db.TICKETs.InsertOnSubmit(t8);
            db.SubmitChanges();

            TICKET t9 = new TICKET();
            t9.TICKETS_CODE = "TICKETS-" + fCode;
            t9.TICKETS_USER_ID = userID;
            t9.TICKETS_FLIGHT_ID = flightID;
            t9.TICKETS_PRICE = Price.ToString();

            t9.TICKETS_CUSTOME_FULLNAME = Name9; ;
            t9.TICKETS_CUSTOMER_ADDRESS = Adress9;
            t9.TICKETS_PASSPORT = Pass9;
            t9.TICKETS_CUSTOMER_PHONE = Phone9;

            db.TICKETs.InsertOnSubmit(t9);
            db.SubmitChanges();

            TICKET t10 = new TICKET();
            t10.TICKETS_CODE = "TICKETS-" + fCode;
            t10.TICKETS_USER_ID = userID;
            t10.TICKETS_FLIGHT_ID = flightID;
            t10.TICKETS_PRICE = Price.ToString();

            t10.TICKETS_CUSTOME_FULLNAME = Name10; ;
            t10.TICKETS_CUSTOMER_ADDRESS = Adress10;
            t10.TICKETS_PASSPORT = Pass10;
            t10.TICKETS_CUSTOMER_PHONE = Phone10;

            db.TICKETs.InsertOnSubmit(t10);
            db.SubmitChanges();
            txtThongBaoConfim.Text = "Tickets saved successfully!";
            tableInforCustomer.Enabled = false;
            table1.Enabled = false;
            table2.Enabled = false;
            table3.Enabled = false;
            table4.Enabled = false;
            table5.Enabled = false;
            table6.Enabled = false;
            table7.Enabled = false;
            table8.Enabled = false;
            table9.Enabled = false;
            btnBack.Visible = true;
        }

        private void checkslKhachHang()
        {
            //int slNguoilon = Convert.ToInt32(Request.QueryString["slNguoiLon"]);
            //int slTreem = Convert.ToInt32(Request.QueryString["slTreem"]);
            //int slEmbe = Convert.ToInt32(Request.QueryString["slEmBe"]);
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            int total = slEmbe + slNguoilon + slTreem;
            switch (total)
            {
                case 1:
                    tableInforCustomer.Visible = true;
                    break;
                case 2:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;

                    break;
                case 3:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;

                    break;
                case 4:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;

                    break;
                case 5:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;

                    break;
                case 6:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;
                    table5.Visible = true;

                    break;
                case 7:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;
                    table5.Visible = true;
                    table6.Visible = true;

                    break;
                case 8:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;
                    table5.Visible = true;
                    table6.Visible = true;
                    table7.Visible = true;


                    break;
                case 9:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;
                    table5.Visible = true;
                    table6.Visible = true;
                    table7.Visible = true;
                    table8.Visible = true;

                    break;
                case 10:
                    tableInforCustomer.Visible = true;
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;
                    table5.Visible = true;
                    table6.Visible = true;
                    table7.Visible = true;
                    table8.Visible = true;
                    table9.Visible = true;
                    break;
                default:
                    tableInforCustomer.Visible = true;
                    break;
            }
        }
        private void loadInfo()
        {
            //String fCode = Request.QueryString["fCode"];
            //int slNguoilon = Convert.ToInt32(Request.QueryString["slNguoiLon"]);
            //int slTreem = Convert.ToInt32(Request.QueryString["slTreEm"]);
            //int slEmbe = Convert.ToInt32(Request.QueryString["slEmBe"]);
            
            String fCode =Session["fCode"].ToString();
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            String userLogin = Session["userlogin"].ToString();
            //var getairlineCode = db.FLIGHTs.SingleOrDefault(a=>a.FLIGHT_CODE == fCode);
            //int airlineCode =(int)getairlineCode.FLIGHT_AIRLINE_ID;
            //var getCode = db.AIRLINEs.SingleOrDefault(f=>f.AIRLINE_ID==airlineCode);
            var getFPrice = db.FLIGHTs.FirstOrDefault(fp => fp.FLIGHT_CODE == fCode);
            int Price = (int)getFPrice.FLIGHT_PRICE;
            int giaNg = slNguoilon * Price;
            int giaTE = slTreem * Price;

            int totalPrice = giaNg + giaTE;
            txtTCode.Text = "TICKET-" + fCode;
            txtTFlightCode.Text = fCode;
            txtTUserCOde.Text = userLogin;
            txtTPriceAdult.Text = slNguoilon + " x " + Price.ToString("#,### VNĐ");
            txtTPriceChilren.Text = slTreem + " x " + Price.ToString("#,### VNĐ");
            txtTPriceInfan.Text = slEmbe + " x " + " 0 VNĐ";
            txtTTotalPrice.Text = totalPrice.ToString("#,### VNĐ");
        }

        

        protected void btnConfim_Click(object sender, EventArgs e)
        {
            //int slNguoilon = Convert.ToInt32(Request.QueryString["slNguoiLon"]);
            //int slTreem = Convert.ToInt32(Request.QueryString["slTreem"]);
            //int slEmbe = Convert.ToInt32(Request.QueryString["slEmBe"]);
            int slNguoilon = Convert.ToInt32(Session["slNguoilon"].ToString());
            int slTreem = Convert.ToInt32(Session["slTreem"].ToString());
            int slEmbe = Convert.ToInt32(Session["slEmbe"].ToString());
            int total = slEmbe + slNguoilon + slTreem;
            switch (total)
            {
                case 1:
                    get1custome();

                    break;
                case 2:
                    get2custome();
                    break;
                case 3:
                    get3custome();
                    break;
                case 4:
                    get4custome();

                    break;
                case 5:
                    get5custome();

                    break;
                case 6:
                    get6custome();

                    break;
                case 7:
                    get7custom();

                    break;
                case 8:
                    get8customer();

                    break;
                case 9:
                    get9custome();

                    break;
                case 10:
                    get10custome();

                    break;
                default:
                    tableInforCustomer.Visible = true;
                    break;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}