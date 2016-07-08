using System.Windows.Forms;
using NLog;
using TurtleManager.db;
using TurtleManager.nancy;

namespace TurtleManager {
	public partial class MainWindow : Form {
		private readonly Logger logger = LogManager.GetCurrentClassLogger();
		public MainWindow() {
			InitializeComponent();

		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			logger.Debug("window was closed - starting cleanup");

			logger.Debug("shutting down nancy host");
			NancyHelper.StopHost();

			logger.Debug("closing database");
			SqLiteHelper.INSTANCE.Close();
		}
	}
}
