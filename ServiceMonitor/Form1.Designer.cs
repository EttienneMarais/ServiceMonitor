namespace ServiceMonitor
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
			this.flpDEV = new System.Windows.Forms.FlowLayoutPanel();
			this.flpINT = new System.Windows.Forms.FlowLayoutPanel();
			this.flpINT_LF = new System.Windows.Forms.FlowLayoutPanel();
			this.flpHouse = new System.Windows.Forms.FlowLayoutPanel();
			this.flpHouse.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpDEV
			// 
			this.flpDEV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpDEV.AutoScroll = true;
			this.flpDEV.Location = new System.Drawing.Point(3, 679);
			this.flpDEV.Name = "flpDEV";
			this.flpDEV.Size = new System.Drawing.Size(1317, 332);
			this.flpDEV.TabIndex = 0;
			// 
			// flpINT
			// 
			this.flpINT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpINT.AutoScroll = true;
			this.flpINT.Location = new System.Drawing.Point(3, 341);
			this.flpINT.Name = "flpINT";
			this.flpINT.Size = new System.Drawing.Size(1317, 332);
			this.flpINT.TabIndex = 0;
			// 
			// flpINT_LF
			// 
			this.flpINT_LF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpINT_LF.AutoScroll = true;
			this.flpINT_LF.Location = new System.Drawing.Point(3, 3);
			this.flpINT_LF.Name = "flpINT_LF";
			this.flpINT_LF.Size = new System.Drawing.Size(1317, 332);
			this.flpINT_LF.TabIndex = 0;
			// 
			// flpHouse
			// 
			this.flpHouse.AutoScroll = true;
			this.flpHouse.Controls.Add(this.flpINT_LF);
			this.flpHouse.Controls.Add(this.flpINT);
			this.flpHouse.Controls.Add(this.flpDEV);
			this.flpHouse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpHouse.Location = new System.Drawing.Point(0, 0);
			this.flpHouse.Name = "flpHouse";
			this.flpHouse.Size = new System.Drawing.Size(1375, 804);
			this.flpHouse.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1375, 804);
			this.Controls.Add(this.flpHouse);
			this.Name = "Form1";
			this.Text = "Service Watcher";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.flpHouse.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flpDEV;
		private System.Windows.Forms.FlowLayoutPanel flpINT;
		private System.Windows.Forms.FlowLayoutPanel flpINT_LF;
		private System.Windows.Forms.FlowLayoutPanel flpHouse;
	}
}

