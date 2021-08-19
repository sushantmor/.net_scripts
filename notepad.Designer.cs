
namespace GroceryStore
{
    partial class notepad
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
            this.rtb_notepad = new System.Windows.Forms.RichTextBox();
            this.panel_rtb_btns = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel_rtbox = new System.Windows.Forms.Panel();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.panel_rtb_btns.SuspendLayout();
            this.panel_rtbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_notepad
            // 
            this.rtb_notepad.Location = new System.Drawing.Point(10, 11);
            this.rtb_notepad.Name = "rtb_notepad";
            this.rtb_notepad.Size = new System.Drawing.Size(1116, 535);
            this.rtb_notepad.TabIndex = 0;
            this.rtb_notepad.Text = "";
            // 
            // panel_rtb_btns
            // 
            this.panel_rtb_btns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_rtb_btns.Controls.Add(this.txtFind);
            this.panel_rtb_btns.Controls.Add(this.btnFind);
            this.panel_rtb_btns.Controls.Add(this.btnColor);
            this.panel_rtb_btns.Controls.Add(this.btnFont);
            this.panel_rtb_btns.Controls.Add(this.btnOpen);
            this.panel_rtb_btns.Controls.Add(this.btnSave);
            this.panel_rtb_btns.Location = new System.Drawing.Point(2, 563);
            this.panel_rtb_btns.Name = "panel_rtb_btns";
            this.panel_rtb_btns.Size = new System.Drawing.Size(1134, 86);
            this.panel_rtb_btns.TabIndex = 3;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(793, 27);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(189, 27);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(988, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 29);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "F&ind";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(310, 27);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(94, 29);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "&Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(210, 27);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(94, 29);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "&Font";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(110, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel_rtbox
            // 
            this.panel_rtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_rtbox.Controls.Add(this.rtb_notepad);
            this.panel_rtbox.Location = new System.Drawing.Point(2, 2);
            this.panel_rtbox.Name = "panel_rtbox";
            this.panel_rtbox.Size = new System.Drawing.Size(1134, 555);
            this.panel_rtbox.TabIndex = 2;
            // 
            // notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 653);
            this.Controls.Add(this.panel_rtb_btns);
            this.Controls.Add(this.panel_rtbox);
            this.Name = "notepad";
            this.Text = "notepad";
            this.panel_rtb_btns.ResumeLayout(false);
            this.panel_rtb_btns.PerformLayout();
            this.panel_rtbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_notepad;
        private System.Windows.Forms.Panel panel_rtb_btns;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel_rtbox;
        private System.Windows.Forms.ColorDialog cd;
    }
}