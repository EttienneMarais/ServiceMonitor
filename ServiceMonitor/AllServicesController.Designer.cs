namespace ServiceMonitor
{
	partial class AllServicesController
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
			this.bStop = new System.Windows.Forms.Button();
			this.bStart = new System.Windows.Forms.Button();
			this.bRestart = new System.Windows.Forms.Button();
			this.lDisplayName = new System.Windows.Forms.Label();
			this.cbCheckLogsForErrors = new System.Windows.Forms.CheckBox();
			this.nudRefreshRate = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudRefreshRate)).BeginInit();
			this.SuspendLayout();
			// 
			// bStop
			// 
			this.bStop.Location = new System.Drawing.Point(7, 46);
			this.bStop.Name = "bStop";
			this.bStop.Size = new System.Drawing.Size(75, 23);
			this.bStop.TabIndex = 4;
			this.bStop.Text = "Stop All";
			this.bStop.UseVisualStyleBackColor = true;
			this.bStop.Click += new System.EventHandler(this.bStopAll_Click);
			// 
			// bStart
			// 
			this.bStart.Location = new System.Drawing.Point(88, 46);
			this.bStart.Name = "bStart";
			this.bStart.Size = new System.Drawing.Size(75, 23);
			this.bStart.TabIndex = 5;
			this.bStart.Text = "Start All";
			this.bStart.UseVisualStyleBackColor = true;
			this.bStart.Click += new System.EventHandler(this.bStartAll_Click);
			// 
			// bRestart
			// 
			this.bRestart.Location = new System.Drawing.Point(169, 46);
			this.bRestart.Name = "bRestart";
			this.bRestart.Size = new System.Drawing.Size(75, 23);
			this.bRestart.TabIndex = 6;
			this.bRestart.Text = "Restart All";
			this.bRestart.UseVisualStyleBackColor = true;
			this.bRestart.Click += new System.EventHandler(this.bRestartAll_Click);
			// 
			// lDisplayName
			// 
			this.lDisplayName.AutoSize = true;
			this.lDisplayName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lDisplayName.Location = new System.Drawing.Point(4, 7);
			this.lDisplayName.Name = "lDisplayName";
			this.lDisplayName.Size = new System.Drawing.Size(138, 13);
			this.lDisplayName.TabIndex = 7;
			this.lDisplayName.Text = "Control all Services on host:";
			// 
			// cbCheckLogsForErrors
			// 
			this.cbCheckLogsForErrors.AutoSize = true;
			this.cbCheckLogsForErrors.Location = new System.Drawing.Point(7, 23);
			this.cbCheckLogsForErrors.Name = "cbCheckLogsForErrors";
			this.cbCheckLogsForErrors.Size = new System.Drawing.Size(123, 17);
			this.cbCheckLogsForErrors.TabIndex = 8;
			this.cbCheckLogsForErrors.Text = "Check logs for errors";
			this.cbCheckLogsForErrors.UseVisualStyleBackColor = true;
			this.cbCheckLogsForErrors.CheckStateChanged += new System.EventHandler(this.cbCheckLogsForErrors_CheckStateChanged);
			// 
			// nudRefreshRate
			// 
			this.nudRefreshRate.Location = new System.Drawing.Point(205, 20);
			this.nudRefreshRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudRefreshRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudRefreshRate.Name = "nudRefreshRate";
			this.nudRefreshRate.Size = new System.Drawing.Size(39, 20);
			this.nudRefreshRate.TabIndex = 9;
			this.nudRefreshRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.nudRefreshRate.ValueChanged += new System.EventHandler(this.nudRefreshRate_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(136, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Refresh rate ";
			// 
			// AllServicesController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudRefreshRate);
			this.Controls.Add(this.cbCheckLogsForErrors);
			this.Controls.Add(this.lDisplayName);
			this.Controls.Add(this.bRestart);
			this.Controls.Add(this.bStart);
			this.Controls.Add(this.bStop);
			this.Name = "AllServicesController";
			this.Size = new System.Drawing.Size(255, 72);
			((System.ComponentModel.ISupportInitialize)(this.nudRefreshRate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bStop;
		private System.Windows.Forms.Button bStart;
		private System.Windows.Forms.Button bRestart;
		private System.Windows.Forms.Label lDisplayName;
		private System.Windows.Forms.CheckBox cbCheckLogsForErrors;
		private System.Windows.Forms.NumericUpDown nudRefreshRate;
		private System.Windows.Forms.Label label1;
	}
}
