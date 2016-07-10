using System;
using System.Windows.Forms;
using TurtleManager.nlog;
using TurtleManager.nancy;

namespace TurtleManager {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() {
			LoggingHelper.SetupConfiguration();

			NancyHelper.StartHost();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
