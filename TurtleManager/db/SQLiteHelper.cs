using System;
using System.Data.SQLite;
using System.IO;
using NLog;

namespace TurtleManager.db {
	public class SqLiteHelper {
		private readonly Logger logger = LogManager.GetCurrentClassLogger();
		private readonly SQLiteConnection conn;
		public static SqLiteHelper INSTANCE = new SqLiteHelper();
		public const string DATABASE_FILENAME = "data.db";

		private SqLiteHelper() {
			logger.Debug("loading sqlite database");
			logger.Debug("database already existed: " + File.Exists(DATABASE_FILENAME));
			conn = new SQLiteConnection("Data Source=" + DATABASE_FILENAME);
			conn.Open();
			logger.Debug("database opened");
		}

		public void Execute(string sql) {
			logger.Debug("executing sql: " + sql);
			SQLiteCommand command = conn.CreateCommand();
			command.CommandText = sql;
			command.ExecuteNonQuery();
			logger.Debug("execute done");
		}

		public SQLiteDataReader Query(string sql) {
			logger.Debug("executing sql query: " + sql);
			SQLiteCommand command = new SQLiteCommand(sql, conn);
			return command.ExecuteReader();
		}

		public void Close() {
			logger.Debug("closing sqlite database");
			conn.Close();
		}

		public bool IsOpen() {
			return conn.State == System.Data.ConnectionState.Open;
		}

		public SQLiteCommand MakeCommand(string sql) {
			return new SQLiteCommand(sql, conn);
		}
	}
}
