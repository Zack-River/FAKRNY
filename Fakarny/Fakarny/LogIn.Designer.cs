﻿namespace Fakarny
{
    partial class Login_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_Fakrny_Logo_Panel = new System.Windows.Forms.Panel();
            this.Create_New_Acount_Link = new System.Windows.Forms.LinkLabel();
            this.Login_Button = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Login_Password_Error_Panel = new System.Windows.Forms.Panel();
            this.Wrong_Password_Label = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Password_UnderLine_Panel = new System.Windows.Forms.Panel();
            this.Login_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Password_Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Login_Username_Error_Panel = new System.Windows.Forms.Panel();
            this.Invalid_Username_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Username_UnderLine_Panel = new System.Windows.Forms.Panel();
            this.Login_UserName_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Password_Icon_Panel = new System.Windows.Forms.Panel();
            this.Login_UserName_Label = new System.Windows.Forms.Label();
            this.Login_Username_Icon_Panel = new System.Windows.Forms.Panel();
            this.Login_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.Login_Password_Error_Panel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Login_Username_Error_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.Login_Fakrny_Logo_Panel);
            this.panel1.Controls.Add(this.Create_New_Acount_Link);
            this.panel1.Controls.Add(this.Login_Button);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.Login_Password_Label);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Login_Password_Icon_Panel);
            this.panel1.Controls.Add(this.Login_UserName_Label);
            this.panel1.Controls.Add(this.Login_Username_Icon_Panel);
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(609, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 982);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login_Fakrny_Logo_Panel
            // 
            this.Login_Fakrny_Logo_Panel.BackgroundImage = global::Fakarny.Properties.Resources.Fakrny_Icon_Demo;
            this.Login_Fakrny_Logo_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Fakrny_Logo_Panel.Location = new System.Drawing.Point(267, 28);
            this.Login_Fakrny_Logo_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Fakrny_Logo_Panel.Name = "Login_Fakrny_Logo_Panel";
            this.Login_Fakrny_Logo_Panel.Size = new System.Drawing.Size(120, 123);
            this.Login_Fakrny_Logo_Panel.TabIndex = 8;
            // 
            // Create_New_Acount_Link
            // 
            this.Create_New_Acount_Link.AutoSize = true;
            this.Create_New_Acount_Link.LinkColor = System.Drawing.Color.White;
            this.Create_New_Acount_Link.Location = new System.Drawing.Point(250, 818);
            this.Create_New_Acount_Link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Create_New_Acount_Link.Name = "Create_New_Acount_Link";
            this.Create_New_Acount_Link.Size = new System.Drawing.Size(151, 20);
            this.Create_New_Acount_Link.TabIndex = 7;
            this.Create_New_Acount_Link.TabStop = true;
            this.Create_New_Acount_Link.Text = "Create new account";
            this.Create_New_Acount_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Create_New_Acount_Link_LinkClicked);
            // 
            // Login_Button
            // 
            this.Login_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Login_Button.FlatAppearance.BorderSize = 2;
            this.Login_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Login_Button.Location = new System.Drawing.Point(183, 692);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(290, 65);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            this.Login_Button.MouseEnter += new System.EventHandler(this.Login_Button_MouseEnter);
            this.Login_Button.MouseLeave += new System.EventHandler(this.Login_Button_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Login_Password_Error_Panel);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(222, 458);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(366, 123);
            this.panel8.TabIndex = 5;
            // 
            // Login_Password_Error_Panel
            // 
            this.Login_Password_Error_Panel.Controls.Add(this.Wrong_Password_Label);
            this.Login_Password_Error_Panel.Location = new System.Drawing.Point(4, 71);
            this.Login_Password_Error_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Password_Error_Panel.Name = "Login_Password_Error_Panel";
            this.Login_Password_Error_Panel.Size = new System.Drawing.Size(362, 35);
            this.Login_Password_Error_Panel.TabIndex = 6;
            this.Login_Password_Error_Panel.Visible = false;
            // 
            // Wrong_Password_Label
            // 
            this.Wrong_Password_Label.AutoSize = true;
            this.Wrong_Password_Label.ForeColor = System.Drawing.Color.Red;
            this.Wrong_Password_Label.Location = new System.Drawing.Point(4, 0);
            this.Wrong_Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wrong_Password_Label.Name = "Wrong_Password_Label";
            this.Wrong_Password_Label.Size = new System.Drawing.Size(129, 20);
            this.Wrong_Password_Label.TabIndex = 0;
            this.Wrong_Password_Label.Text = "Wrong Password";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Password_UnderLine_Panel);
            this.panel10.Controls.Add(this.Login_Password_TextBox);
            this.panel10.Location = new System.Drawing.Point(8, 5);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(354, 57);
            this.panel10.TabIndex = 3;
            // 
            // Password_UnderLine_Panel
            // 
            this.Password_UnderLine_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Password_UnderLine_Panel.ForeColor = System.Drawing.SystemColors.Window;
            this.Password_UnderLine_Panel.Location = new System.Drawing.Point(4, 35);
            this.Password_UnderLine_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_UnderLine_Panel.Name = "Password_UnderLine_Panel";
            this.Password_UnderLine_Panel.Size = new System.Drawing.Size(350, 2);
            this.Password_UnderLine_Panel.TabIndex = 4;
            // 
            // Login_Password_TextBox
            // 
            this.Login_Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Login_Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Login_Password_TextBox.Location = new System.Drawing.Point(4, 5);
            this.Login_Password_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Password_TextBox.Name = "Login_Password_TextBox";
            this.Login_Password_TextBox.PasswordChar = '*';
            this.Login_Password_TextBox.Size = new System.Drawing.Size(350, 19);
            this.Login_Password_TextBox.TabIndex = 2;
            this.Login_Password_TextBox.Text = "Password";
            this.Login_Password_TextBox.Click += new System.EventHandler(this.Login_Password_TextBox_Click);
            this.Login_Password_TextBox.TextChanged += new System.EventHandler(this.Pass_Changed);
            this.Login_Password_TextBox.Enter += new System.EventHandler(this.Pass_Enter);
            this.Login_Password_TextBox.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // Login_Password_Label
            // 
            this.Login_Password_Label.AutoSize = true;
            this.Login_Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Password_Label.Location = new System.Drawing.Point(116, 472);
            this.Login_Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_Password_Label.Name = "Login_Password_Label";
            this.Login_Password_Label.Size = new System.Drawing.Size(98, 25);
            this.Login_Password_Label.TabIndex = 1;
            this.Login_Password_Label.Text = "Password";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Login_Username_Error_Panel);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(222, 308);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(366, 123);
            this.panel5.TabIndex = 5;
            // 
            // Login_Username_Error_Panel
            // 
            this.Login_Username_Error_Panel.Controls.Add(this.Invalid_Username_Label);
            this.Login_Username_Error_Panel.Location = new System.Drawing.Point(4, 71);
            this.Login_Username_Error_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Username_Error_Panel.Name = "Login_Username_Error_Panel";
            this.Login_Username_Error_Panel.Size = new System.Drawing.Size(362, 35);
            this.Login_Username_Error_Panel.TabIndex = 6;
            this.Login_Username_Error_Panel.Visible = false;
            // 
            // Invalid_Username_Label
            // 
            this.Invalid_Username_Label.AutoSize = true;
            this.Invalid_Username_Label.ForeColor = System.Drawing.Color.Red;
            this.Invalid_Username_Label.Location = new System.Drawing.Point(4, 0);
            this.Invalid_Username_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Invalid_Username_Label.Name = "Invalid_Username_Label";
            this.Invalid_Username_Label.Size = new System.Drawing.Size(132, 20);
            this.Invalid_Username_Label.TabIndex = 0;
            this.Invalid_Username_Label.Text = "Invalid Username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Username_UnderLine_Panel);
            this.panel2.Controls.Add(this.Login_UserName_TextBox);
            this.panel2.Location = new System.Drawing.Point(8, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 57);
            this.panel2.TabIndex = 3;
            // 
            // Username_UnderLine_Panel
            // 
            this.Username_UnderLine_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Username_UnderLine_Panel.Location = new System.Drawing.Point(4, 35);
            this.Username_UnderLine_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_UnderLine_Panel.Name = "Username_UnderLine_Panel";
            this.Username_UnderLine_Panel.Size = new System.Drawing.Size(350, 2);
            this.Username_UnderLine_Panel.TabIndex = 4;
            // 
            // Login_UserName_TextBox
            // 
            this.Login_UserName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Login_UserName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_UserName_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Login_UserName_TextBox.Location = new System.Drawing.Point(4, 5);
            this.Login_UserName_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_UserName_TextBox.Multiline = true;
            this.Login_UserName_TextBox.Name = "Login_UserName_TextBox";
            this.Login_UserName_TextBox.Size = new System.Drawing.Size(350, 28);
            this.Login_UserName_TextBox.TabIndex = 2;
            this.Login_UserName_TextBox.Text = "Username";
            this.Login_UserName_TextBox.Click += new System.EventHandler(this.Login_UserName_TextBox_Click);
            this.Login_UserName_TextBox.TextChanged += new System.EventHandler(this.User_Changed);
            this.Login_UserName_TextBox.Enter += new System.EventHandler(this.Enter_User);
            this.Login_UserName_TextBox.Leave += new System.EventHandler(this.Leave_User);
            // 
            // Login_Password_Icon_Panel
            // 
            this.Login_Password_Icon_Panel.BackgroundImage = global::Fakarny.Properties.Resources.Lock_Icon;
            this.Login_Password_Icon_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Password_Icon_Panel.Location = new System.Drawing.Point(56, 458);
            this.Login_Password_Icon_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Password_Icon_Panel.Name = "Login_Password_Icon_Panel";
            this.Login_Password_Icon_Panel.Size = new System.Drawing.Size(51, 52);
            this.Login_Password_Icon_Panel.TabIndex = 4;
            // 
            // Login_UserName_Label
            // 
            this.Login_UserName_Label.AutoSize = true;
            this.Login_UserName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_UserName_Label.Location = new System.Drawing.Point(116, 322);
            this.Login_UserName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_UserName_Label.Name = "Login_UserName_Label";
            this.Login_UserName_Label.Size = new System.Drawing.Size(102, 25);
            this.Login_UserName_Label.TabIndex = 1;
            this.Login_UserName_Label.Text = "Username";
            // 
            // Login_Username_Icon_Panel
            // 
            this.Login_Username_Icon_Panel.BackgroundImage = global::Fakarny.Properties.Resources.Profile_Icon;
            this.Login_Username_Icon_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_Username_Icon_Panel.Location = new System.Drawing.Point(56, 308);
            this.Login_Username_Icon_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_Username_Icon_Panel.Name = "Login_Username_Icon_Panel";
            this.Login_Username_Icon_Panel.Size = new System.Drawing.Size(51, 52);
            this.Login_Username_Icon_Panel.TabIndex = 4;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.Color.White;
            this.Login_Label.Location = new System.Drawing.Point(274, 174);
            this.Login_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(101, 37);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Login";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.BackgroundImage = global::Fakarny.Properties.Resources.Picsart_23_11_27_23_53_32_550;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.Text = "Fakrny - فكرني";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.Login_Password_Error_Panel.ResumeLayout(false);
            this.Login_Password_Error_Panel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.Login_Username_Error_Panel.ResumeLayout(false);
            this.Login_Username_Error_Panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login_UserName_Label;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Login_Username_Icon_Panel;
        private System.Windows.Forms.TextBox Login_UserName_TextBox;
        private System.Windows.Forms.Panel Username_UnderLine_Panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Login_Username_Error_Panel;
        private System.Windows.Forms.Label Invalid_Username_Label;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel Login_Password_Error_Panel;
        private System.Windows.Forms.Label Wrong_Password_Label;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel Password_UnderLine_Panel;
        private System.Windows.Forms.TextBox Login_Password_TextBox;
        private System.Windows.Forms.Label Login_Password_Label;
        private System.Windows.Forms.Panel Login_Password_Icon_Panel;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.LinkLabel Create_New_Acount_Link;
        private System.Windows.Forms.Panel Login_Fakrny_Logo_Panel;
    }
}

