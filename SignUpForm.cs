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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Signup
            try {
                if(!IsUpper || !IsLower || !IsDigit || !IsSpChar)
                {
                    MessageBox.Show("Not Valid");
                    lblErrPass.Text= lblError1.Text = "Error";
                    return;
                }
                //string connstr = "Data Source=.;Initial Catalog=Grocery;Integrated Security=True";
                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = connstr;

                //con.Open();

                //SqlCommand com =  con.CreateCommand();

                string wd = "";
                foreach(Control ctr in pnlWD.Controls)
                {
                    CheckBox chk = (CheckBox)ctr;
                    if (chk.Checked)
                        wd += chk.Text + ",";
                }
                if (wd.Length == 0) {
                    MessageBox.Show("Select Working Domain");
                    return;
                }
                string query = "insert into grcusers values('" + txtusername.Text.Trim()
                    + "','" + txtPass.Text.Trim()
                    + "','" + cmbCountryCode.Text +"-"+ txtPHone.Text.Trim() 
                    + "','"+ (rbFemale.Checked?"F":"M") 
                    +"','"+ dateDob.Value 
                    +"','"+ txtEmail.Text.Trim() 
                    +"','"+ wd +"',1);";

                Db_Context context = new Db_Context();

                int r = context.ExecuteDML(query);
                
                context.DisposeCon();

                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

          

        private void txtusername_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
            if (txtusername.Text.Trim().Length == 0)
            {
                //MessageBox.Show("Username required");
                //txtusername.Focus();
                //errorProvider1.SetError(txtusername, "Required");
                lblError1.Text = "* Required";
            }
            else {
                lblError1.Text = "";
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //"Atleast 8 characters, One Uppercase, one lower, numeric and a special character, without space";

        }
        bool IsUpper = false;
        bool IsLower = false;
        bool IsDigit = false;
        bool IsSpChar = false;
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            string text = txtPass.Text.Trim();
            if (txtPass.Text.Trim().Length < 8)
                lblErrPass.Text = "Must have characters";
            else
            {
                if(text.Contains(" "))
                    lblErrPass.Text = "Space is not allowed";
                else
                {
                    

                    for (int i=0; i<text.Length; i++)
                    {
                        if (Char.IsUpper(text[i]))
                        {
                            IsUpper = true;                            
                        }
                        if (Char.IsLower(text[i]))
                        {
                            IsLower = true;                            
                        }
                        if (Char.IsDigit(text[i]))
                        {
                            IsDigit = true;
                        }
                        if ("~!@#$%^&*()_+".Contains(text[i]))
                        {
                            IsSpChar = true;
                        }

                    }
                    if (!IsUpper)
                    {
                        lblErrPass.Text = "Must Contain Uppercase";
                    }
                    else if (!IsLower)
                    {
                        lblErrPass.Text = "Must Contain Lower";
                    }
                    else if (!IsDigit)
                    {
                        lblErrPass.Text = "Must Contain Digit";
                    }
                    else if (!IsSpChar)
                    {
                        lblErrPass.Text = "Must Contain [~!@#$%^&*()_+]";
                    }
                    else {
                        lblErrPass.Text = "";
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn_pass.TextChanged();
            string pass = txtPass.Text;
            MessageBox.Show(pass);
            //txtPass.Show.Text;
        }
    }
}
