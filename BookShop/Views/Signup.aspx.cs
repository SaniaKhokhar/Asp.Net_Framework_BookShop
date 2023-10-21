using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Views
{
    public partial class Signup : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string UName = UNameTb.Value;
                    string UEmail = EmailTb.Value;
                    string UPhone = PhoneTb.Value;
                    string UPassword = PasswordTb.Value;

                    string Query = "Insert into SellerTb values('{0}', '{1}', '{2}','{3}')";
                    Query = string.Format(Query, UName, UEmail, UPhone, UPassword);
                    Con.SetData(Query);
                    
                    UNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    PasswordTb.Value = "";

                    Response.Redirect("Login.aspx");
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}