using NLog;
using TurtleManager.db;

namespace TurtleManager.sections.sorter {
	public class ItemData : DbData {
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		private static bool initialized;
		

		private static void Initialize() {
			if (initialized) {
				return;
			}

			logger.Debug("initializing ItemData");
			//TODO: Check and setup DB if necessary

			logger.Debug("ItemData is initialized");
			initialized = true;
		}

		public static string GetListNameForItem(string itemId) {
			Initialize();
			logger.Debug("got request for itemID: " + itemId);
			//TODO: access DB and return saved List Name or UNSORTED
			return ""; //TODO:
		}

		public string GetTablePrefix() {
			return "sorter_";
		}
	}
}
