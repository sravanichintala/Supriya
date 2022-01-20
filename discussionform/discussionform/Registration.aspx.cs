using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using discussionform.ConnectionDB;
using System.Data;

namespace discussionform
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            DFConnection DFConnectionObj = new DFConnection();
            DFModel ModelObj = new DFModel();

            ModelObj.id = Convert.ToInt32(txtId.Text);
            ModelObj.Name = txtName.Text;
            ModelObj.Emailid = txtEmailid.Text;
            ModelObj.Mobile= Convert.ToInt32(txtMobile.Text);

            string msg = DFConnectionObj.InsertUsers(ModelObj);
            lblResult.Text = msg;
            DataTable dtResult =  DFConnectionObj.SelectUsers();
            gvUsersDetails.DataSource = dtResult;
            gvUsersDetails.DataBind();

        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {

        }
    }
}