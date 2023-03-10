namespace MySQLParser2
{
    partial class MySQLParser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_DatabaseIP = new TextBox();
            lbl_DatabaseIP = new Label();
            btn_QueryDatabase = new Button();
            grid_DataView = new DataGridView();
            txt_DatabaseName = new TextBox();
            lbl_DatabaseName = new Label();
            lbl_DatabaseUsername = new Label();
            lbl_DatabasePassword = new Label();
            txt_DatabaseUsername = new TextBox();
            txt_DatabasePassword = new TextBox();
            txt_QueryDatabase = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grid_DataView).BeginInit();
            SuspendLayout();
            // 
            // txt_DatabaseIP
            // 
            txt_DatabaseIP.Location = new Point(223, 70);
            txt_DatabaseIP.Margin = new Padding(6);
            txt_DatabaseIP.Name = "txt_DatabaseIP";
            txt_DatabaseIP.Size = new Size(182, 39);
            txt_DatabaseIP.TabIndex = 0;
            // 
            // lbl_DatabaseIP
            // 
            lbl_DatabaseIP.AutoSize = true;
            lbl_DatabaseIP.Location = new Point(85, 77);
            lbl_DatabaseIP.Margin = new Padding(6, 0, 6, 0);
            lbl_DatabaseIP.Name = "lbl_DatabaseIP";
            lbl_DatabaseIP.Size = new Size(138, 32);
            lbl_DatabaseIP.TabIndex = 1;
            lbl_DatabaseIP.Text = "Database IP";
            // 
            // btn_QueryDatabase
            // 
            btn_QueryDatabase.Location = new Point(85, 425);
            btn_QueryDatabase.Margin = new Padding(6);
            btn_QueryDatabase.Name = "btn_QueryDatabase";
            btn_QueryDatabase.Size = new Size(206, 49);
            btn_QueryDatabase.TabIndex = 2;
            btn_QueryDatabase.Text = "Query Database";
            btn_QueryDatabase.UseVisualStyleBackColor = true;
            btn_QueryDatabase.Click += btn_QueryDatabase_Click;
            // 
            // grid_DataView
            // 
            grid_DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_DataView.Location = new Point(85, 486);
            grid_DataView.Margin = new Padding(6);
            grid_DataView.Name = "grid_DataView";
            grid_DataView.RowHeadersWidth = 82;
            grid_DataView.RowTemplate.Height = 25;
            grid_DataView.Size = new Size(982, 320);
            grid_DataView.TabIndex = 3;
            // 
            // txt_DatabaseName
            // 
            txt_DatabaseName.Location = new Point(223, 167);
            txt_DatabaseName.Name = "txt_DatabaseName";
            txt_DatabaseName.Size = new Size(200, 39);
            txt_DatabaseName.TabIndex = 4;
            // 
            // lbl_DatabaseName
            // 
            lbl_DatabaseName.AutoSize = true;
            lbl_DatabaseName.Location = new Point(40, 174);
            lbl_DatabaseName.Name = "lbl_DatabaseName";
            lbl_DatabaseName.Size = new Size(183, 32);
            lbl_DatabaseName.TabIndex = 5;
            lbl_DatabaseName.Text = "Database Name";
            // 
            // lbl_DatabaseUsername
            // 
            lbl_DatabaseUsername.AutoSize = true;
            lbl_DatabaseUsername.Location = new Point(620, 73);
            lbl_DatabaseUsername.Name = "lbl_DatabaseUsername";
            lbl_DatabaseUsername.Size = new Size(226, 32);
            lbl_DatabaseUsername.TabIndex = 6;
            lbl_DatabaseUsername.Text = "Database Username";
            // 
            // lbl_DatabasePassword
            // 
            lbl_DatabasePassword.AutoSize = true;
            lbl_DatabasePassword.Location = new Point(620, 157);
            lbl_DatabasePassword.Name = "lbl_DatabasePassword";
            lbl_DatabasePassword.Size = new Size(216, 32);
            lbl_DatabasePassword.TabIndex = 7;
            lbl_DatabasePassword.Text = "Database Password";
            // 
            // txt_DatabaseUsername
            // 
            txt_DatabaseUsername.Location = new Point(867, 70);
            txt_DatabaseUsername.Name = "txt_DatabaseUsername";
            txt_DatabaseUsername.Size = new Size(200, 39);
            txt_DatabaseUsername.TabIndex = 8;
            // 
            // txt_DatabasePassword
            // 
            txt_DatabasePassword.Location = new Point(867, 157);
            txt_DatabasePassword.Name = "txt_DatabasePassword";
            txt_DatabasePassword.Size = new Size(200, 39);
            txt_DatabasePassword.TabIndex = 9;
            // 
            // txt_QueryDatabase
            // 
            txt_QueryDatabase.Location = new Point(320, 430);
            txt_QueryDatabase.Name = "txt_QueryDatabase";
            txt_QueryDatabase.Size = new Size(615, 39);
            txt_QueryDatabase.TabIndex = 10;
            // 
            // MySQLParser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(txt_QueryDatabase);
            Controls.Add(txt_DatabasePassword);
            Controls.Add(txt_DatabaseUsername);
            Controls.Add(lbl_DatabasePassword);
            Controls.Add(lbl_DatabaseUsername);
            Controls.Add(lbl_DatabaseName);
            Controls.Add(txt_DatabaseName);
            Controls.Add(grid_DataView);
            Controls.Add(btn_QueryDatabase);
            Controls.Add(lbl_DatabaseIP);
            Controls.Add(txt_DatabaseIP);
            Margin = new Padding(6);
            Name = "MySQLParser";
            Text = "MySQLParser";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid_DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_DatabaseIP;
        private Label lbl_DatabaseIP;
        private Button btn_QueryDatabase;
        private DataGridView grid_DataView;
        private TextBox txt_DatabaseName;
        private Label lbl_DatabaseName;
        private Label lbl_DatabaseUsername;
        private Label lbl_DatabasePassword;
        private TextBox txt_DatabaseUsername;
        private TextBox txt_DatabasePassword;
        private TextBox txt_QueryDatabase;
    }
}