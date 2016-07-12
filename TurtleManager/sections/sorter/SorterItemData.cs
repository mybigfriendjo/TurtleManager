using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using NLog;
using TurtleManager.db;

namespace TurtleManager.sections.sorter {
	public class SorterItemData {
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		private static bool initialized;
		private const string TABLE_PREFIX = "sorter_";
		private const string TABLE_ITEMS = "items";
		private const string UNKNOWN_LISTNAME = "unknown";

		private static readonly List<ItemDataListener> listeners = new List<ItemDataListener>();

		private static readonly SQLiteCommand createTable = SqLiteHelper.INSTANCE.MakeCommand("CREATE TABLE " + TABLE_PREFIX + TABLE_ITEMS + " ( 'itemId' TEXT NOT NULL, 'list' TEXT NOT NULL, 'count' INTEGER, PRIMARY KEY(itemId));");
		private static readonly SQLiteCommand updateCount = SqLiteHelper.INSTANCE.MakeCommand("UPDATE " + TABLE_PREFIX + TABLE_ITEMS + " SET count=count+1 WHERE itemId=@itemId;");
		private static readonly SQLiteCommand insertItem = SqLiteHelper.INSTANCE.MakeCommand("INSERT INTO " + TABLE_PREFIX + TABLE_ITEMS + " VALUES(@itemId, '" + UNKNOWN_LISTNAME + "', 1);");
		private static readonly SQLiteCommand tableExists = SqLiteHelper.INSTANCE.MakeCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" + TABLE_PREFIX + TABLE_ITEMS + "';");
		private static readonly SQLiteCommand searchItem = SqLiteHelper.INSTANCE.MakeCommand("SELECT * FROM " + TABLE_PREFIX + TABLE_ITEMS + " WHERE itemId=@itemId;");
		private static readonly SQLiteCommand getAllFromList = SqLiteHelper.INSTANCE.MakeCommand("SELECT * FROM " + TABLE_PREFIX + TABLE_ITEMS + " WHERE list=@list ORDER BY itemId ASC;");
		private static readonly SQLiteCommand getAllLists = SqLiteHelper.INSTANCE.MakeCommand("SELECT DISTINCT list FROM " + TABLE_PREFIX + TABLE_ITEMS + " ORDER BY list ASC;");
		private static readonly SQLiteCommand changeItemList = SqLiteHelper.INSTANCE.MakeCommand("UPDATE " + TABLE_PREFIX + TABLE_ITEMS + " SET list=@list WHERE itemId=@itemId;");


		public static IEnumerable<string> GetAllUnknown() {
			Initialize();
			getAllFromList.Reset();
			getAllFromList.Parameters.Add("@list", DbType.String);
			getAllFromList.Parameters["@list"].Value = UNKNOWN_LISTNAME;
			SQLiteDataReader reader = getAllFromList.ExecuteReader();
			List<string> temp = new List<string>();
			while (reader.Read()) {
				temp.Add(reader.GetString(0));
			}
			reader.Close();
			return temp;
		}

		public static IEnumerable<string> GetAllListNames() {
			Initialize();
			SQLiteDataReader reader = getAllLists.ExecuteReader();
			List<string> temp = new List<string>();
			while (reader.Read()) {
				string tempName = reader.GetString(0);
				if (UNKNOWN_LISTNAME.Equals(tempName)) {
					continue;
				}
				temp.Add(tempName);
			}
			reader.Close();
			return temp;
		}

		public static IEnumerable<string> GetAllItemsForList(string selectedList) {
			Initialize();
			getAllFromList.Reset();
			getAllFromList.Parameters.Add("@list", DbType.String);
			getAllFromList.Parameters["@list"].Value = selectedList;
			SQLiteDataReader reader = getAllFromList.ExecuteReader();
			List<string> temp = new List<string>();
			while (reader.Read()) {
				temp.Add(reader.GetString(0));
			}
			reader.Close();
			return temp;
		}

		public static void AddItemToList(string itemId, string list) {
			Initialize();
			changeItemList.Reset();
			changeItemList.Parameters.Add("@list", DbType.String);
			changeItemList.Parameters["@list"].Value = list;
			changeItemList.Parameters.Add("@itemId", DbType.String);
			changeItemList.Parameters["@itemId"].Value = itemId;
			changeItemList.ExecuteNonQuery();

			NotifyListeners();
		}

		public static void RemoveItemFromList(string itemId) {
			Initialize();
			changeItemList.Reset();
			changeItemList.Parameters.Add("@list", DbType.String);
			changeItemList.Parameters["@list"].Value = UNKNOWN_LISTNAME;
			changeItemList.Parameters.Add("@itemId", DbType.String);
			changeItemList.Parameters["@itemId"].Value = itemId;
			changeItemList.ExecuteNonQuery();

			NotifyListeners();
		}

		private static void Initialize() {
			if (initialized) {
				return;
			}

			logger.Debug("initializing ItemData");


			SQLiteDataReader reader = tableExists.ExecuteReader();

			if (!reader.HasRows) {
				createTable.ExecuteNonQuery();
			}
			reader.Close();


			logger.Debug("ItemData is initialized");
			initialized = true;
		}

		public static string GetListNameForItem(string itemId) {
			Initialize();
			logger.Debug("got request for itemID: " + itemId);

			searchItem.Reset();
			searchItem.Parameters.Add("@itemId", DbType.String);
			searchItem.Parameters["@itemId"].Value = itemId;

			SQLiteDataReader readerItem = searchItem.ExecuteReader();
			if (readerItem.HasRows) {
				readerItem.Read();
				string list = (string)readerItem[1];
				logger.Debug("found item in item-data. list is: " + list);
				logger.Debug("updating count");
				updateCount.Reset();
				updateCount.Parameters.Add("@itemId", DbType.String);
				updateCount.Parameters["@itemId"].Value = itemId;
				updateCount.ExecuteNonQuery();
				NotifyListeners();
				return list;
			}
			logger.Debug("couldn't find item. creating new entry in unknown-data");
			insertItem.Reset();
			insertItem.Parameters.Add("@itemId", DbType.String);
			insertItem.Parameters["@itemId"].Value = itemId;
			insertItem.ExecuteNonQuery();
			
			NotifyListeners();

			return UNKNOWN_LISTNAME;
		}

		public interface ItemDataListener {
			void UpdateItemData();
		}

		public static void AddListener(ItemDataListener listener) {
			logger.Debug("adding ItemDataListener");
			if (listeners.Contains(listener)) {
				logger.Debug("listener already exists in list");
				return;
			}
			listeners.Add(listener);
		}

		private static void NotifyListeners() {
			logger.Debug("notifying ItemDataListeners");
			foreach (ItemDataListener listener in listeners) {
				listener.UpdateItemData();
			}
		}
	}
}
