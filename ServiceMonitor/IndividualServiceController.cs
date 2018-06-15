using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Drawing;
using System.Threading.Tasks;

namespace ServiceMonitor
{
	public partial class IndividualServiceController : UserControl
	{
		public IndividualServiceController()
		{
			InitializeComponent();
		}

		private delegate void ServiceAction(ServiceController sc);

		private bool SafelyActOnService(ServiceAction sa)
		{
			try
			{
				using (ServiceController controller = new ServiceController(ServiceName, HostName))
				{
					sa(controller);
				}
				return true;
			}
			catch
			{
				_timer.Stop();
				_timer.Tick -= _timer_Tick;

				return false;
			}
		}

		private LogFileWatcher _logFileWatcher;

		private ServiceControllerStatus _currentStatus;

		public string HostName { get; set; }
		public string ServiceName { get; set; }
		public string DisplayName
		{
			set
			{
				lServiceName.Text = value;
			}
		}

		private int _refreshRate;
		public int RefreshRate
		{
			get { return _refreshRate; }
			set
			{
				_refreshRate = value;

				if (_timer != null)
				{
					_timer.Interval = value;
				}
			}
		}

		public string LogFilePath { get; set; }

		public bool CheckLogsForErrors { get; set; }

		private Timer _timer;

		public void bStart_Click(object sender, EventArgs e)
		{
			if (!bStart.Enabled)
			{
				IndividualService_Load(null, null);
			}

			EnableUI(SafelyActOnService((sc) => sc.Start()));

			GetStatus();
		}

		public void bRestart_Click(object sender, EventArgs e)
		{
			bStop_Click(null, null);
			bStart_Click(null, null);
		}

		public void bStop_Click(object sender, EventArgs e)
		{
			EnableUI(SafelyActOnService((sc) => sc.Stop()));

			GetStatus();
		}

		private void IndividualService_Load(object sender, EventArgs e)
		{
			_timer = new Timer();

			_timer.Interval = RefreshRate;

			_timer.Tick += _timer_Tick;

			_timer.Start();

			bStart.Enabled = bStop.Enabled = bRestart.Enabled = true;

			lServiceStatus.Font = new Font(lServiceStatus.Font, FontStyle.Bold);

			lServiceName.Font = new Font(lServiceStatus.Font, FontStyle.Bold);

			lLogFileError.Font = new Font(lLogFileError.Font, FontStyle.Bold);

			lLogFileError.ForeColor = Color.OrangeRed;

			_logFileWatcher = new LogFileWatcher(_refreshRate, LogFilePath);

			_logFileWatcher.LogFileErrorStateChanged += _logFileWatcher_LogFileErrorStateChanged;
		}

		private void _logFileWatcher_LogFileErrorStateChanged(object sender, LogFileErrorState e)
		{
			switch (e)
			{
				case LogFileErrorState.NoError:
					lLogFileError.Text = "No Errors";
					lLogFileError.ForeColor = Color.White;
					lLogFileError.Visible = true;
					break;
				case LogFileErrorState.Error:
					lLogFileError.Text = "Errors in logs";
					lLogFileError.ForeColor = Color.OrangeRed;
					lLogFileError.Visible = true;
					break;
				case LogFileErrorState.Warning:
					lLogFileError.Text = "Warnings in logs";
					lLogFileError.ForeColor = Color.Orange;
					lLogFileError.Visible = true;
					break;
				case LogFileErrorState.FileNotFound:
					lLogFileError.Text = "FileNotFound";
					lLogFileError.ForeColor = Color.Red;
					lLogFileError.Visible = true;
					break;
				case LogFileErrorState.DirectoryNotFound:
					break;
				default:
					lLogFileError.Text = "DirectoryNotFound";
					lLogFileError.ForeColor = Color.Red;
					lLogFileError.Visible = true;
					break;
			}
		}

		private void _timer_Tick(object sender, EventArgs e)
		{
			GetStatus();
		}

		private void GetStatus()
		{
			//bool safe = false;

			//var t = Task.Run(() =>
			//{
			//	safe = SafelyActOnService((sc) => _currentStatus = sc.Status);
			//});

			//if (EnableUI(safe))
			//{
			//	t.Wait();
			//	SetServiceControllerStatus();
			//}

			if (EnableUI(SafelyActOnService((sc) => _currentStatus = sc.Status)))
			{
				SetServiceControllerStatus();
			}
		}

		private bool EnableUI(bool enable)
		{
			bStart.Enabled = bStop.Enabled = bRestart.Enabled = enable;

			if (!enable)
			{
				//lServiceName.ForeColor = System.Drawing.Color.Orange;
				lServiceStatus.ForeColor = System.Drawing.Color.Orange;
				lServiceStatus.Text = "Not Found";

				_logFileWatcher.LogFileErrorStateChanged -= _logFileWatcher_LogFileErrorStateChanged;
				_logFileWatcher.Dispose();
			}

			return enable;
		}

		private void SetServiceControllerStatus()
		{
			switch (_currentStatus)
			{
				case ServiceControllerStatus.ContinuePending:
					lServiceStatus.ForeColor = System.Drawing.Color.OrangeRed;
					lServiceStatus.Text = "ContinuePending";
					break;
				case ServiceControllerStatus.Paused:
					lServiceStatus.ForeColor = System.Drawing.Color.OrangeRed;
					lServiceStatus.Text = "Paused";
					break;
				case ServiceControllerStatus.PausePending:
					lServiceStatus.ForeColor = System.Drawing.Color.OrangeRed;
					lServiceStatus.Text = "PausePending";
					break;
				case ServiceControllerStatus.Running:
					lServiceStatus.ForeColor = System.Drawing.Color.ForestGreen;
					lServiceStatus.Text = "Running";
					break;
				case ServiceControllerStatus.StartPending:
					lServiceStatus.ForeColor = System.Drawing.Color.OrangeRed;
					lServiceStatus.Text = "StartPending";
					break;
				case ServiceControllerStatus.Stopped:
					lServiceStatus.ForeColor = System.Drawing.Color.OrangeRed;
					lServiceStatus.Text = "Stopped";
					break;
				case ServiceControllerStatus.StopPending:
					lServiceStatus.ForeColor = System.Drawing.Color.OrangeRed;
					lServiceStatus.Text = "StopPending";
					break;
				default:
					break;
			}
		}

		private void lServiceStatus_DoubleClick(object sender, EventArgs e)
		{
			GetStatus();
		}
	}

	public class ServiceWatcher
	{

	}
}
