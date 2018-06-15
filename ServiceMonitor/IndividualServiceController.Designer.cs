namespace ServiceMonitor
{
	partial class IndividualServiceController
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lServiceName = new System.Windows.Forms.Label();
			this.lServiceStatus = new System.Windows.Forms.Label();
			this.bStop = new System.Windows.Forms.Button();
			this.bStart = new System.Windows.Forms.Button();
			this.bRestart = new System.Windows.Forms.Button();
			this.lLogFileError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lServiceName
			// 
			this.lServiceName.AutoSize = true;
			this.lServiceName.ForeColor = System.Drawing.SystemColors.Desktop;
			this.lServiceName.Location = new System.Drawing.Point(4, 4);
			this.lServiceName.Name = "lServiceName";
			this.lServiceName.Size = new System.Drawing.Size(80, 13);
			this.lServiceName.TabIndex = 2;
			this.lServiceName.Text = "Service Name :";
			// 
			// lServiceStatus
			// 
			this.lServiceStatus.AutoSize = true;
			this.lServiceStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lServiceStatus.Location = new System.Drawing.Point(4, 21);
			this.lServiceStatus.Name = "lServiceStatus";
			this.lServiceStatus.Size = new System.Drawing.Size(82, 13);
			this.lServiceStatus.TabIndex = 3;
			this.lServiceStatus.Text = "Service Status :";
			this.lServiceStatus.DoubleClick += new System.EventHandler(this.lServiceStatus_DoubleClick);
			// 
			// bStop
			// 
			this.bStop.Location = new System.Drawing.Point(7, 37);
			this.bStop.Name = "bStop";
			this.bStop.Size = new System.Drawing.Size(75, 23);
			this.bStop.TabIndex = 4;
			this.bStop.Text = "Stop";
			this.bStop.UseVisualStyleBackColor = true;
			this.bStop.Click += new System.EventHandler(this.bStop_Click);
			// 
			// bStart
			// 
			this.bStart.Location = new System.Drawing.Point(88, 37);
			this.bStart.Name = "bStart";
			this.bStart.Size = new System.Drawing.Size(75, 23);
			this.bStart.TabIndex = 5;
			this.bStart.Text = "Start";
			this.bStart.UseVisualStyleBackColor = true;
			this.bStart.Click += new System.EventHandler(this.bStart_Click);
			// 
			// bRestart
			// 
			this.bRestart.Location = new System.Drawing.Point(169, 37);
			this.bRestart.Name = "bRestart";
			this.bRestart.Size = new System.Drawing.Size(75, 23);
			this.bRestart.TabIndex = 6;
			this.bRestart.Text = "Restart";
			this.bRestart.UseVisualStyleBackColor = true;
			this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
			// 
			// lLogFileError
			// 
			this.lLogFileError.AutoSize = true;
			this.lLogFileError.Location = new System.Drawing.Point(166, 21);
			this.lLogFileError.Name = "lLogFileError";
			this.lLogFileError.Size = new System.Drawing.Size(51, 13);
			this.lLogFileError.TabIndex = 7;
			this.lLogFileError.Text = "No Errors";
			this.lLogFileError.Visible = false;
			// 
			// IndividualServiceController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.lLogFileError);
			this.Controls.Add(this.bRestart);
			this.Controls.Add(this.bStart);
			this.Controls.Add(this.bStop);
			this.Controls.Add(this.lServiceStatus);
			this.Controls.Add(this.lServiceName);
			this.Name = "IndividualServiceController";
			this.Size = new System.Drawing.Size(255, 72);
			this.Load += new System.EventHandler(this.IndividualService_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lServiceName;
		private System.Windows.Forms.Label lServiceStatus;
		private System.Windows.Forms.Button bStop;
		private System.Windows.Forms.Button bStart;
		private System.Windows.Forms.Button bRestart;
		private System.Windows.Forms.Label lLogFileError;
	}
}
