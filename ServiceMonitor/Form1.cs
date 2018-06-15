using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServiceMonitor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			flpDEV.BorderStyle = BorderStyle.FixedSingle;
			flpINT.BorderStyle = BorderStyle.FixedSingle;
			flpINT_LF.BorderStyle = BorderStyle.FixedSingle;

			LoadWatchers("DSSTBCFGAPP04", flpDEV, "Config.Dev");
			LoadWatchers("DSINTAPP09", flpINT, "INT");
			LoadWatchers("DSINTAPP13", flpINT_LF, "DEV LightFleet");

			// flp ideal size = 1317, 332
			// add it dynamically
		}

		private void LoadWatchers(string hostName, FlowLayoutPanel flp, string displayName)
		{
			flp.Controls.Clear();
			flp.FlowDirection = FlowDirection.TopDown;

			List<Tuple<string, string, string, ServiceType, string>> servicesDetails = new List<Tuple<string, string, string, ServiceType, string>>
			{
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Incoming.M2K",									"M2K Incoming",									ServiceType.Windows, "M2K"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Incoming.M6K",									"M6K Incoming",									ServiceType.Windows, "M6K"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Incoming.TDI",									"TDI Incoming",									ServiceType.Windows, "TDI"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Incoming.G52S",								"G52 Incoming",									ServiceType.Windows, "G52"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Incoming.Iridium",							"Iridium Incoming",							ServiceType.Windows, "Iridium"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.DataProcessor",								"Data Processor",								ServiceType.Windows, "DataProcessor"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.MessageBackup",								"Message Backup",								ServiceType.Windows, "MessageBackup"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.DataPersistor",								"Legacy Persistor",							ServiceType.Windows, "DataPersistor"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Outgoing.Lightning",						"Lightning Outgoing",						ServiceType.Windows, "LightningOutgoing"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Outgoing.HOS",									"HOS Outgoing",									ServiceType.Windows, "HOS"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.DataProcessing.Outgoing.EventNotifications",	"Notifications Outgoing",				ServiceType.Windows, "EventNotifications"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.Monitoring",																	"Monitoring",										ServiceType.Windows, "Monitoring"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.Fm.ActiveMessageProcessor",										"FM Active Message Processor",	ServiceType.Windows, "FmActiveMessageProcessor"),
				new Tuple<string, string, string, ServiceType, string>(hostName, "DynaMiX.DeviceConfig.Services.Tabs.FirmwareLFT",														"Tabs Firmware LFT",						ServiceType.Windows, "TabsFirmwareLFT")
				//new Tuple<string, string, string, ServiceType>("DSSTBCFGIIS03", "http://api.dynamic-can.configdev.development.domain.local",				"Device Config API",						ServiceType.Web)

				// http://api.dynamic-can.configdev.development.domain.local
			};

			List<IndividualServiceController> watchers = new List<IndividualServiceController>();

			int refreshRate = 30;

			if (Environment.UserName.ToLower().Equals("wynands") || Environment.UserName.ToLower().Equals("jacquesv"))
			{
				AllServicesController allServicesController = new AllServicesController();
				allServicesController.DisplayName = $"{hostName} - {displayName}";
				allServicesController.AllServices = watchers;

				flp.Controls.Add(allServicesController);
			}

			foreach (var item in servicesDetails)
			{
				IndividualServiceController watcher = new IndividualServiceController
				{
					HostName = item.Item1,
					ServiceName = item.Item2,
					DisplayName = item.Item3,
					RefreshRate = refreshRate,
					LogFilePath = $"\\\\{hostName}\\L$\\Services\\{item.Item2}\\{item.Item5}.log"
				};

				watchers.Add(watcher);
			}

			

			foreach (var item in watchers)
			{
				flp.Controls.Add(item);
			}
		}
	}

	public enum ServiceType
	{
		Windows,
		Web
	}
}
