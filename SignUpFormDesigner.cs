
namespace GroceryStore
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrPass = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnCancelSignup = new System.Windows.Forms.Button();
            this.pnlWD = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.txtPHone = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cmbCountryCode = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlWD.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblErrPass);
            this.panel1.Controls.Add(this.lblError1);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlWD);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.dateDob);
            this.panel1.Controls.Add(this.txtPHone);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.cmbCountryCode);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 704);
            this.panel1.TabIndex = 0;
            // 
            // lblErrPass
            // 
            this.lblErrPass.AutoSize = true;
            this.lblErrPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblErrPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrPass.Location = new System.Drawing.Point(523, 171);
            this.lblErrPass.Name = "lblErrPass";
            this.lblErrPass.Size = new System.Drawing.Size(0, 17);
            this.lblErrPass.TabIndex = 25;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.BackColor = System.Drawing.Color.White;
            this.lblError1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(530, 123);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 17);
            this.lblError1.TabIndex = 24;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(259, 166);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(251, 27);
            this.txtPass.TabIndex = 23;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(104, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Password :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.btnSignup);
            this.panel4.Controls.Add(this.btnCancelSignup);
            this.panel4.Location = new System.Drawing.Point(133, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 71);
            this.panel4.TabIndex = 21;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignup.Location = new System.Drawing.Point(41, 20);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(94, 37);
            this.btnSignup.TabIndex = 19;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelSignup
            // 
            this.btnCancelSignup.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelSignup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSignup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelSignup.Location = new System.Drawing.Point(221, 20);
            this.btnCancelSignup.Name = "btnCancelSignup";
            this.btnCancelSignup.Size = new System.Drawing.Size(94, 37);
            this.btnCancelSignup.TabIndex = 20;
            this.btnCancelSignup.Text = "Cancel";
            this.btnCancelSignup.UseVisualStyleBackColor = false;
            this.btnCancelSignup.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlWD
            // 
            this.pnlWD.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlWD.Controls.Add(this.checkBox1);
            this.pnlWD.Controls.Add(this.checkBox3);
            this.pnlWD.Controls.Add(this.checkBox2);
            this.pnlWD.Controls.Add(this.checkBox4);
            this.pnlWD.Location = new System.Drawing.Point(266, 473);
            this.pnlWD.Name = "pnlWD";
            this.pnlWD.Size = new System.Drawing.Size(251, 60);
            this.pnlWD.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(3, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Management";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox3.Location = new System.Drawing.Point(3, 31);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 24);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Clerical";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(132, 1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 24);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Cleaning";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox4.Location = new System.Drawing.Point(132, 31);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 24);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Transport";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(259, 416);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(259, 350);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(251, 27);
            this.dateDob.TabIndex = 11;
            this.dateDob.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtPHone
            // 
            this.txtPHone.Location = new System.Drawing.Point(333, 218);
            this.txtPHone.Name = "txtPHone";
            this.txtPHone.Size = new System.Drawing.Size(177, 27);
            this.txtPHone.TabIndex = 10;
            // 
            // txtusername
            // 
            this.txtusername.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtusername.Location = new System.Drawing.Point(259, 116);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(251, 27);
            this.txtusername.TabIndex = 9;
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            this.txtusername.Validating += new System.ComponentModel.CancelEventHandler(this.txtusername_Validating);
            // 
            // cmbCountryCode
            // 
            this.cmbCountryCode.FormattingEnabled = true;
            this.cmbCountryCode.Items.AddRange(new object[] {
            "C.C.",
            "+91",
            "+44",
            "+1",
            "+344",
            "+414",
            "+92",
            "+907"});
            this.cmbCountryCode.Location = new System.Drawing.Point(259, 217);
            this.cmbCountryCode.Name = "cmbCountryCode";
            this.cmbCountryCode.Size = new System.Drawing.Size(68, 28);
            this.cmbCountryCode.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.rbFemale);
            this.panel2.Controls.Add(this.rbMale);
            this.panel2.Location = new System.Drawing.Point(259, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 51);
            this.panel2.TabIndex = 7;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFemale.Location = new System.Drawing.Point(147, 14);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 24);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMale.Location = new System.Drawing.Point(20, 15);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(63, 24);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(104, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(105, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Working Domain :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(104, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(104, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "D.O.B. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(104, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(164, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up Window";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupForm";
            this.Text = "Sign Up Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlWD.ResumeLayout(false);
            this.pnlWD.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtPHone;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ComboBox cmbCountryCode;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Panel pnlWD;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.Button btnCancelSignup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblErrPass;
    }
}
