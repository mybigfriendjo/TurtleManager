using System.Windows.Forms;
using NLog;
using TurtleManager.db;
using TurtleManager.nancy;
using TurtleManager.sections.sorter;

namespace TurtleManager {
	public partial class MainWindow : Form {
		private readonly Logger logger = LogManager.GetCurrentClassLogger();

		public MainWindow() {
			InitializeComponent();

			SorterGuiManager sorterManager = new SorterGuiManager();
			sorterManager.UnknownList = sorter_listBoxUnsorted;
			sorterManager.ListnameList = sorter_listBoxIDLists;
			sorterManager.ItemList = sorter_listBoxIDsOnList;
			sorterManager.AddItemButton = sorter_buttonAddIDToList;
			sorterManager.RemoveItemButton = sorter_buttonRemoveIDFromList;
			sorterManager.InitGui();
			sorterManager.InitEvents();
			SorterItemData.AddListener(sorterManager);
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
