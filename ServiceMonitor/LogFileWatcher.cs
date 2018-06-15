using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitor
{
	public class LogFileWatcher : IDisposable
	{
		private int _refreshRate;
		public int RefreshRate
		{
			get { return _refreshRate; }
			set
			{
				_refreshRate = value;

				if(_timer == null)
				{
					_timer = new Timer();
				}

				_timer.Interval = value;

			}
		}

		private Timer _timer;

		public readonly string _logFilePath;

		public event EventHandler<LogFileErrorState> LogFileErrorStateChanged;
		public LogFileErrorState LogFileErrorState { get; private set; }

		private List<string> _errors;

		public LogFileWatcher(int refreshRate, string logFilePath)
		{
			_logFilePath = logFilePath;

			_errors = new List<string>();

			_timer = new Timer();

			RefreshRate = refreshRate;

			_timer.Tick += _timer_TickAsync;

			SetState(LogFileErrorState.NoError);

			//_timer.Start();
		}


		private async void _timer_TickAsync(object sender, EventArgs e)
		{
			List<string> lines = new List<string>();

			try
			{
				using (StreamReader reader = new StreamReader(_logFilePath))
				{
					string nextLine;
					while ((nextLine = await reader.ReadLineAsync()) != null)
					{
						lines.Add(nextLine);
					}
				}
			}
			catch (System.IO.DirectoryNotFoundException dnf)
			{

				SetState(LogFileErrorState.DirectoryNotFound);

				this.Dispose();

				return;
			}
			catch (System.IO.FileNotFoundException fnf)
			{
				SetState(LogFileErrorState.FileNotFound);

				this.Dispose();

				return;
			}
			catch (Exception ex)
			{
				this.Dispose();

				return;
			}

			bool errorFound = false;

			foreach (string line in lines)
			{
				if (line.ToLower().Contains("error"))
				{
					errorFound = true;
					// add to error list
					if (LogFileErrorState != LogFileErrorState.Error)
					{
						SetState(LogFileErrorState.Error);
					}

					if (!_errors.Contains(line))
					{
						_errors.Add(line);
					}
				}
			}

			if (!errorFound && LogFileErrorState == LogFileErrorState.Error)
			{
				SetState(LogFileErrorState.NoError);

				_errors = new List<string>();
			}
		}

		private void SetState(LogFileErrorState s)
		{
			LogFileErrorState = s;

			LogFileErrorStateChanged?.Invoke(this, s);
		}

		public void Dispose()
		{
			_timer.Stop();
			_timer.Tick -= _timer_TickAsync;
		}
	}

	public enum LogFileErrorState
	{
		NoError,
		Error,
		Warning,
		FileNotFound,
		DirectoryNotFound
	}
}
