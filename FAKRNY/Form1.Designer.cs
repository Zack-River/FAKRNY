namespace FAKRNY
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CreateAccount_Button = new System.Windows.Forms.Button();
            this.Sign_Up_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Sign_Up_UserName_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1490, 813);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CreateAccount_Button);
            this.tabPage1.Controls.Add(this.Sign_Up_Password_TextBox);
            this.tabPage1.Controls.Add(this.Sign_Up_UserName_TextBox);
            this.tabPage1.Controls.Add(this.Password_Label);
            this.tabPage1.Controls.Add(this.UserName_Label);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1482, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rgister";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CreateAccount_Button
            // 
            this.CreateAccount_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_Button.Location = new System.Drawing.Point(179, 165);
            this.CreateAccount_Button.Name = "CreateAccount_Button";
            this.CreateAccount_Button.Size = new System.Drawing.Size(139, 62);
            this.CreateAccount_Button.TabIndex = 4;
            this.CreateAccount_Button.Text = "Create Account";
            this.CreateAccount_Button.UseVisualStyleBackColor = true;
            this.CreateAccount_Button.Click += new System.EventHandler(this.CreateAccount_Button_Click);
            // 
            // Sign_Up_Password_TextBox
            // 
            this.Sign_Up_Password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_Password_TextBox.Location = new System.Drawing.Point(167, 83);
            this.Sign_Up_Password_TextBox.Name = "Sign_Up_Password_TextBox";
            this.Sign_Up_Password_TextBox.Size = new System.Drawing.Size(165, 30);
            this.Sign_Up_Password_TextBox.TabIndex = 3;
            // 
            // Sign_Up_UserName_TextBox
            // 
            this.Sign_Up_UserName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_UserName_TextBox.Location = new System.Drawing.Point(167, 16);
            this.Sign_Up_UserName_TextBox.Name = "Sign_Up_UserName_TextBox";
            this.Sign_Up_UserName_TextBox.Size = new System.Drawing.Size(165, 30);
            this.Sign_Up_UserName_TextBox.TabIndex = 2;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.Location = new System.Drawing.Point(21, 88);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(98, 25);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password";
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Label.Location = new System.Drawing.Point(21, 21);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(110, 25);
            this.UserName_Label.TabIndex = 0;
            this.UserName_Label.Text = "User Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1482, 784);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log In";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FAKRNY-فكرني";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CreateAccount_Button;
        private System.Windows.Forms.TextBox Sign_Up_Password_TextBox;
        private System.Windows.Forms.TextBox Sign_Up_UserName_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label UserName_Label;
    }
}

