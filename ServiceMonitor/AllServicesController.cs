using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ServiceMonitor
{
	public partial class AllServicesController : UserControl
	{
		public AllServicesController()
		{
			InitializeComponent();
		}

		public List<IndividualServiceController> AllServices { get; set; }

		public string DisplayName
		{
			set
			{
				lDisplayName.Text = value;

				lDisplayName.Font = new Font(lDisplayName.Font, FontStyle.Bold);
			}
		}

		private void bStartAll_Click(object sender, EventArgs e)
		{
			foreach(var item in AllServices)
			{
				item.bStart_Click(null, null);
			}
		}

		private void bRestartAll_Click(object sender, EventArgs e)
		{
			foreach (var item in AllServices)
			{
				item.bRestart_Click(null, null);
			}
		}

		private void bStopAll_Click(object sender, EventArgs e)
		{
			foreach (var item in AllServices)
			{
				item.bStop_Click(null, null);
			}
		}

		private void nudRefreshRate_ValueChanged(object sender, EventArgs e)
		{
			foreach (var item in AllServices)
			{
				item.RefreshRate = (int)nudRefreshRate.Value;
			}
		}

		private void cbCheckLogsForErrors_CheckStateChanged(object sender, EventArgs e)
		{
			foreach (var item in AllServices)
			{
				item.CheckLogsForErrors = cbCheckLogsForErrors.CheckState == CheckState.Checked;
			}
		}
	}
}
