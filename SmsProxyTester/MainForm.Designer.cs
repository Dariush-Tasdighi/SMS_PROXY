namespace MyApplication
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnDisplayCredit = new System.Windows.Forms.Button();
			this.btnGetPanelExpireDate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUsername.Location = new System.Drawing.Point(90, 12);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(390, 23);
			this.txtUsername.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(90, 41);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(390, 23);
			this.txtPassword.TabIndex = 3;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 15);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(72, 16);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "&Username";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 44);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(70, 16);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "&Password";
			// 
			// btnDisplayCredit
			// 
			this.btnDisplayCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisplayCredit.Location = new System.Drawing.Point(12, 258);
			this.btnDisplayCredit.Name = "btnDisplayCredit";
			this.btnDisplayCredit.Size = new System.Drawing.Size(468, 23);
			this.btnDisplayCredit.TabIndex = 4;
			this.btnDisplayCredit.Text = "Display &Credit";
			this.btnDisplayCredit.UseVisualStyleBackColor = true;
			this.btnDisplayCredit.Click += new System.EventHandler(this.btnDisplayCredit_Click);
			// 
			// btnGetPanelExpireDate
			// 
			this.btnGetPanelExpireDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGetPanelExpireDate.Location = new System.Drawing.Point(12, 287);
			this.btnGetPanelExpireDate.Name = "btnGetPanelExpireDate";
			this.btnGetPanelExpireDate.Size = new System.Drawing.Size(468, 23);
			this.btnGetPanelExpireDate.TabIndex = 5;
			this.btnGetPanelExpireDate.Text = "Display Panel &Expire Date";
			this.btnGetPanelExpireDate.UseVisualStyleBackColor = true;
			this.btnGetPanelExpireDate.Click += new System.EventHandler(this.btnGetPanelExpireDate_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 322);
			this.Controls.Add(this.btnGetPanelExpireDate);
			this.Controls.Add(this.btnDisplayCredit);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnDisplayCredit;
		private System.Windows.Forms.Button btnGetPanelExpireDate;
	}
}
