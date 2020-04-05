using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;

namespace SQLite.Library
{
	class SqliteDataService : ILocalDataService
	{
		private SQLiteConnection _database;
		public void Initialize()
		{
			if(_database == null)
			{
				string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "C971Db.db3");
				_database = new SQLiteConnection(dbPath);
			}
			
		}
	}
}
