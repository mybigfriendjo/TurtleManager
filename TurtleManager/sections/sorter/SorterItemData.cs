using System;
using System.Collections.Generic;
using System.Data.SQLite;
using NLog;
using TurtleManager.db;

namespace TurtleManager.sections.sorter {
	public class SorterItemData {
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		private static bool initialized;
		private const string TABLE_PREFIX = "sorter_";
		private const string TABLE_UNKNOWN = "unknown";
		private const string TABLE_ITEMS = "items";
		private static readonly string[] tableNames = { TABLE_UNKNOWN, TABLE_ITEMS };

		private static List<ItemDataListener> listeners = new List<ItemDataListener>();

		private static void Initialize() {
			if (initialized) {
				return;
			}

			logger.Debug("initializing ItemData");
			foreach (string tableName in tableNames) {
				SQLiteDataReader reader = SqLiteHelper.INSTANCE.Query("SELECT name FROM sqlite_master WHERE type='table' AND name='" + TABLE_PREFIX + tableName + "';");
				if (!reader.HasRows) {
					CreateTable(tableName);
				}
				reader.Close();
			}

			logger.Debug("ItemData is initialized");
			initialized = true;
		}

		private static void CreateTable(string tableName) {
			SqLiteHelper.INSTANCE.Execute("CREATE TABLE '" + TABLE_PREFIX + tableName + "' ( 'itemID' TEXT NOT NULL, 'list' TEXT NOT NULL, 'count' INTEGER, PRIMARY KEY(itemID));");
		}

		public static string GetListNameForItem(string itemId) {
			Initialize();
			logger.Debug("got request for itemID: " + itemId);

			SQLiteCommand searchItem = SqLiteHelper.INSTANCE.MakeCommand("SELECT * FROM " + TABLE_PREFIX + TABLE_ITEMS + " WHERE itemID='?';");
			searchItem.Parameters.Add(itemId);

			SQLiteDataReader readerItem = searchItem.ExecuteReader();
			if (readerItem.HasRows) {
				readerItem.Read();
				string list = (string)readerItem[1];
				logger.Debug("found item in item-data. list is: " + list);
				logger.Debug("updating count");
				SqLiteHelper.INSTANCE.Execute("UPDATE " + TABLE_PREFIX + TABLE_ITEMS + " SET count=count+1 WHERE itemID='" + itemId + "';");
				return list;
			}

			SQLiteCommand searchUnknown = SqLiteHelper.INSTANCE.MakeCommand("SELECT * FROM " + TABLE_PREFIX + TABLE_UNKNOWN + " WHERE itemID='?';");
			searchUnknown.Parameters.Add(itemId);

			SQLiteDataReader readerUnknown = searchUnknown.ExecuteReader();
			if (readerUnknown.HasRows) {
				logger.Debug("found item in unknown-data");
				logger.Debug("updating count");
				SqLiteHelper.INSTANCE.Execute("UPDATE " + TABLE_PREFIX + TABLE_UNKNOWN + " SET count=count+1 WHERE itemID='" + itemId + "';");
			} else {
				logger.Debug("couldn't find item. creating new entry in unknown-data");
				SqLiteHelper.INSTANCE.Execute("INSERT INTO " + TABLE_PREFIX + TABLE_UNKNOWN + " VALUES(" + itemId + ", 'unknown', 1);");
			}

			NotifyListeners();

			return TABLE_UNKNOWN;
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
