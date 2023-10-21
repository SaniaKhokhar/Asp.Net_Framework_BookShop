using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSellers();
        }
        private void ShowSellers()
        {
            string Query = "Select SellId SellName SellEmail SellPhone SellPass from SellerTb";
            SellerList.DataSource = Con.GetData(Query);
            SellerList.DataBind();
        }
        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = EmailTb.Value;
                    string SPhone = PhoneTb.Value;
                    string SPassword = PasswordTb.Value;

                    string Query = "Insert into SellerTb values('{0}', '{1}', '{2}','{3}')";
                    Query = string.Format(Query, SName, SEmail, SPhone, SPassword);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Inserted!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    PasswordTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        int Key = 0;
        protected void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SNameTb.Value = SellerList.SelectedRow.Cells[2].Text;
            EmailTb.Value = SellerList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = SellerList.SelectedRow.Cells[4].Text;
            PasswordTb.Value = SellerList.SelectedRow.Cells[5].Text;
            if (SNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellerList.SelectedRow.Cells[1].Text);
            }
        }

        protected void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = EmailTb.Value;
                    string SPhone = PhoneTb.Value;
                    string SPassword = PasswordTb.Value;

                    string Query = "Update SellerTb set SellName = '{0}', SellEmail = '{1}', SellPhone = '{2}', SellPass = '{3}' where SellId = {4}";
                    Query = string.Format(Query, SName, SEmail,SPhone, SPassword, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Updated!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    PasswordTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data!!";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string SEmail = EmailTb.Value;
                    string SPhone = PhoneTb.Value;
                    string SPassword = PasswordTb.Value;

                    string Query = "delete from SellerTb where SellId = {0}";
                    Query = string.Format(Query, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Deleted!!";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    PasswordTb.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }

        }
    }
}