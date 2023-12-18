namespace Fakarny
{
    partial class FakarnyPage
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
            this.Show_Name_Combobox = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.View_Contents_Button = new System.Windows.Forms.Button();
            this.Copy_Password_Button = new System.Windows.Forms.Button();
            this.Copy_Username_Button = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.User_Id_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Add_Acc_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Search_Textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Accounts_List_Label = new System.Windows.Forms.Label();
            this.Tabs_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.add_Account1 = new Fakarny.UserControls.Add_Account();
            this.edit_Account1 = new Fakarny.UserControls.Edit_Account();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.Tabs_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.Show_Name_Combobox);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.Add_Acc_Button);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Search_Textbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Accounts_List_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 681);
            this.panel1.TabIndex = 3;
            // 
            // Show_Name_Combobox
            // 
            this.Show_Name_Combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Show_Name_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Show_Name_Combobox.ForeColor = System.Drawing.Color.White;
            this.Show_Name_Combobox.FormattingEnabled = true;
            this.Show_Name_Combobox.Location = new System.Drawing.Point(27, 207);
            this.Show_Name_Combobox.Name = "Show_Name_Combobox";
            this.Show_Name_Combobox.Size = new System.Drawing.Size(445, 32);
            this.Show_Name_Combobox.TabIndex = 19;
            this.Show_Name_Combobox.Text = "Choose Your Account From Here";
            this.Show_Name_Combobox.DropDown += new System.EventHandler(this.Show_Name_Combobox_DropDown);
            this.Show_Name_Combobox.SelectionChangeCommitted += new System.EventHandler(this.Show_Name_Combobox_SelectionChangeCommitted);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.View_Contents_Button);
            this.panel9.Controls.Add(this.Copy_Password_Button);
            this.panel9.Controls.Add(this.Copy_Username_Button);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.User_Id_Label);
            this.panel9.Controls.Add(this.Name_Label);
            this.panel9.Location = new System.Drawing.Point(27, 122);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(701, 69);
            this.panel9.TabIndex = 18;
            // 
            // View_Contents_Button
            // 
            this.View_Contents_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.View_Contents_Button.FlatAppearance.BorderSize = 0;
            this.View_Contents_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Contents_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Contents_Button.ForeColor = System.Drawing.Color.White;
            this.View_Contents_Button.Location = new System.Drawing.Point(616, 3);
            this.View_Contents_Button.Name = "View_Contents_Button";
            this.View_Contents_Button.Size = new System.Drawing.Size(82, 55);
            this.View_Contents_Button.TabIndex = 19;
            this.View_Contents_Button.Text = "View Contents";
            this.View_Contents_Button.UseVisualStyleBackColor = false;
            this.View_Contents_Button.Click += new System.EventHandler(this.View_Contents_Button_Click);
            // 
            // Copy_Password_Button
            // 
            this.Copy_Password_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Copy_Password_Button.FlatAppearance.BorderSize = 0;
            this.Copy_Password_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Password_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_Password_Button.ForeColor = System.Drawing.Color.White;
            this.Copy_Password_Button.Location = new System.Drawing.Point(529, 3);
            this.Copy_Password_Button.Name = "Copy_Password_Button";
            this.Copy_Password_Button.Size = new System.Drawing.Size(82, 55);
            this.Copy_Password_Button.TabIndex = 19;
            this.Copy_Password_Button.Text = "Copy Password";
            this.Copy_Password_Button.UseVisualStyleBackColor = false;
            this.Copy_Password_Button.Click += new System.EventHandler(this.Copy_Password_Button_Click);
            // 
            // Copy_Username_Button
            // 
            this.Copy_Username_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Copy_Username_Button.FlatAppearance.BorderSize = 0;
            this.Copy_Username_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Username_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_Username_Button.ForeColor = System.Drawing.Color.White;
            this.Copy_Username_Button.Location = new System.Drawing.Point(441, 3);
            this.Copy_Username_Button.Name = "Copy_Username_Button";
            this.Copy_Username_Button.Size = new System.Drawing.Size(82, 55);
            this.Copy_Username_Button.TabIndex = 19;
            this.Copy_Username_Button.Text = "Copy Username";
            this.Copy_Username_Button.UseVisualStyleBackColor = false;
            this.Copy_Username_Button.Click += new System.EventHandler(this.Copy_Username_Button_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.panel8.Location = new System.Drawing.Point(19, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(660, 1);
            this.panel8.TabIndex = 16;
            // 
            // User_Id_Label
            // 
            this.User_Id_Label.AutoSize = true;
            this.User_Id_Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.User_Id_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.User_Id_Label.Location = new System.Drawing.Point(3, 38);
            this.User_Id_Label.Name = "User_Id_Label";
            this.User_Id_Label.Size = new System.Drawing.Size(75, 18);
            this.User_Id_Label.TabIndex = 14;
            this.User_Id_Label.Text = "Username";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(3, 7);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(84, 20);
            this.Name_Label.TabIndex = 14;
            this.Name_Label.Text = "App Name";
            // 
            // Add_Acc_Button
            // 
            this.Add_Acc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Acc_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Acc_Button.Location = new System.Drawing.Point(518, 599);
            this.Add_Acc_Button.Name = "Add_Acc_Button";
            this.Add_Acc_Button.Size = new System.Drawing.Size(207, 46);
            this.Add_Acc_Button.TabIndex = 7;
            this.Add_Acc_Button.Text = "Add Account";
            this.Add_Acc_Button.UseVisualStyleBackColor = true;
            this.Add_Acc_Button.Click += new System.EventHandler(this.Add_Acc_Button_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Fakarny.Properties.Resources.Search1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(486, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 30);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Search_Textbox
            // 
            this.Search_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Search_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Textbox.ForeColor = System.Drawing.Color.White;
            this.Search_Textbox.Location = new System.Drawing.Point(521, 27);
            this.Search_Textbox.Multiline = true;
            this.Search_Textbox.Name = "Search_Textbox";
            this.Search_Textbox.Size = new System.Drawing.Size(207, 30);
            this.Search_Textbox.TabIndex = 4;
            this.Search_Textbox.Text = "Search Account";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Fakarny.Properties.Resources.Fakarny_Icon1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(27, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "FAKARNY";
            // 
            // Accounts_List_Label
            // 
            this.Accounts_List_Label.AutoSize = true;
            this.Accounts_List_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounts_List_Label.ForeColor = System.Drawing.Color.White;
            this.Accounts_List_Label.Location = new System.Drawing.Point(278, 56);
            this.Accounts_List_Label.Name = "Accounts_List_Label";
            this.Accounts_List_Label.Size = new System.Drawing.Size(153, 29);
            this.Accounts_List_Label.TabIndex = 1;
            this.Accounts_List_Label.Text = "Accounts List";
            // 
            // Tabs_Panel
            // 
            this.Tabs_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Tabs_Panel.Controls.Add(this.add_Account1);
            this.Tabs_Panel.Controls.Add(this.edit_Account1);
            this.Tabs_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tabs_Panel.Location = new System.Drawing.Point(761, 0);
            this.Tabs_Panel.Name = "Tabs_Panel";
            this.Tabs_Panel.Size = new System.Drawing.Size(503, 681);
            this.Tabs_Panel.TabIndex = 4;
            // 
            // add_Account1
            // 
            this.add_Account1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.add_Account1.key = null;
            this.add_Account1.Location = new System.Drawing.Point(4, 5);
            this.add_Account1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_Account1.Name = "add_Account1";
            this.add_Account1.Program_Path = null;
            this.add_Account1.Size = new System.Drawing.Size(503, 681);
            this.add_Account1.TabIndex = 0;
            this.add_Account1.Load += new System.EventHandler(this.add_Account1_Load);
            // 
            // edit_Account1
            // 
            this.edit_Account1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.edit_Account1.key = null;
            this.edit_Account1.Location = new System.Drawing.Point(4, 696);
            this.edit_Account1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_Account1.Name = "edit_Account1";
            this.edit_Account1.Program_Path = null;
            this.edit_Account1.Size = new System.Drawing.Size(503, 681);
            this.edit_Account1.TabIndex = 1;
            // 
            // FakarnyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Tabs_Panel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FakarnyPage";
            this.Text = "FakarnyPage";
            this.Load += new System.EventHandler(this.FakarnyPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.Tabs_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Accounts_List_Label;
        private System.Windows.Forms.FlowLayoutPanel Tabs_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Search_Textbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Add_Acc_Button;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Copy_Username_Button;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label User_Id_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button View_Contents_Button;
        private System.Windows.Forms.Button Copy_Password_Button;
        private UserControls.Edit_Account edit_Account1;
        private UserControls.Add_Account add_Account1;
        private System.Windows.Forms.ComboBox Show_Name_Combobox;
    }
}