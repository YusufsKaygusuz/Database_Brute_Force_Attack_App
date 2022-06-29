namespace DBSecurity
{
    partial class frmBruteForce
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
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.DBNameLabel = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.CauntLabel = new System.Windows.Forms.Label();
            this.txtCaunt = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstPassword = new System.Windows.Forms.ListBox();
            this.strtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPLabel.Location = new System.Drawing.Point(12, 9);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(112, 28);
            this.ServerIPLabel.TabIndex = 0;
            this.ServerIPLabel.Text = "Server IP:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(12, 61);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(129, 28);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User Name:";
            // 
            // DBNameLabel
            // 
            this.DBNameLabel.AutoSize = true;
            this.DBNameLabel.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBNameLabel.Location = new System.Drawing.Point(12, 114);
            this.DBNameLabel.Name = "DBNameLabel";
            this.DBNameLabel.Size = new System.Drawing.Size(121, 28);
            this.DBNameLabel.TabIndex = 2;
            this.DBNameLabel.Text = "DB Name: ";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(181, 15);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(308, 33);
            this.txtServerName.TabIndex = 3;
            this.txtServerName.Text = "192.168.149.128";
            this.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(181, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(308, 33);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "SA";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDBName
            // 
            this.txtDBName.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBName.Location = new System.Drawing.Point(181, 112);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(308, 33);
            this.txtDBName.TabIndex = 5;
            this.txtDBName.Text = "MASTER";
            this.txtDBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CauntLabel
            // 
            this.CauntLabel.AutoSize = true;
            this.CauntLabel.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CauntLabel.Location = new System.Drawing.Point(542, 61);
            this.CauntLabel.Name = "CauntLabel";
            this.CauntLabel.Size = new System.Drawing.Size(83, 28);
            this.CauntLabel.TabIndex = 6;
            this.CauntLabel.Text = "Caunt: ";
            // 
            // txtCaunt
            // 
            this.txtCaunt.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaunt.Location = new System.Drawing.Point(631, 59);
            this.txtCaunt.Name = "txtCaunt";
            this.txtCaunt.Size = new System.Drawing.Size(99, 33);
            this.txtCaunt.TabIndex = 7;
            this.txtCaunt.Text = "1000";
            this.txtCaunt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(30, 28);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "...";
            // 
            // lstPassword
            // 
            this.lstPassword.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPassword.FormattingEnabled = true;
            this.lstPassword.ItemHeight = 27;
            this.lstPassword.Location = new System.Drawing.Point(17, 245);
            this.lstPassword.Name = "lstPassword";
            this.lstPassword.Size = new System.Drawing.Size(713, 436);
            this.lstPassword.TabIndex = 9;
            // 
            // strtButton
            // 
            this.strtButton.Font = new System.Drawing.Font("Bell MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtButton.Location = new System.Drawing.Point(597, 169);
            this.strtButton.Name = "strtButton";
            this.strtButton.Size = new System.Drawing.Size(133, 53);
            this.strtButton.TabIndex = 10;
            this.strtButton.Text = "Start";
            this.strtButton.UseVisualStyleBackColor = true;
            this.strtButton.Click += new System.EventHandler(this.strtButton_Click);
            // 
            // frmBruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 708);
            this.Controls.Add(this.strtButton);
            this.Controls.Add(this.lstPassword);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCaunt);
            this.Controls.Add(this.CauntLabel);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.DBNameLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ServerIPLabel);
            this.Name = "frmBruteForce";
            this.Text = "frmBruteForce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label DBNameLabel;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label CauntLabel;
        private System.Windows.Forms.TextBox txtCaunt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstPassword;
        private System.Windows.Forms.Button strtButton;
    }
}