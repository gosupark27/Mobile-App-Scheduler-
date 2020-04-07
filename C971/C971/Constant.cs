using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace C971
{
	public static class Constant
	{
		public const string DatabaseFileName = "SQLite.db3";

		public const SQLite.SQLiteOpenFlags Flags =
			//Open the db in read/write mode
			SQLite.SQLiteOpenFlags.ReadWrite |
			//create db if it doesn't exist 
			SQLite.SQLiteOpenFlags.Create |
			//enable multi-threaded db access 
			SQLite.SQLiteOpenFlags.SharedCache;

		public static string DatabasePath
		{
			get
			{
				var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				return Path.Combine(basePath, DatabaseFileName);
			}
		}
	}
}
