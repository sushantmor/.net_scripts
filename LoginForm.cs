using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GroceryStore
{
    public partial class LoginForm : Form
    {
        public static bool IsAuthentic = false;
        public static bool IsSignedUp = false;

        public LoginForm()
        {
            InitializeComponent();
            IsAuthentic = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupform = new SignupForm();
            signupform.ShowDialog();
            IsSignedUp = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //IsAuthentic = (txtUser.Text.Trim().Equals(txtPwd.Text.Trim()));

            string query = "select * from grcusers where usrname='"+ txtUser.Text.Trim() +"' and passwd='" + txtPwd.Text.Trim() +"'";

            Db_Context context = new Db_Context();

            SqlDataReader dr = context.ExecuteSelect(query);

            if (dr.Read())
                IsAuthentic = true;

            context.DisposeCon();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
