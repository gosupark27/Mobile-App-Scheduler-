using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using C971.Models;
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
				string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "");
				_database = new SQLiteConnection(dbPath);
			}
			_database.CreateTable<Term>();
			_database.CreateTable<Course>();
			_database.CreateTable<Instructor>();
			_database.CreateTable<Note>();
			_database.CreateTable<Objective>();
			_database.CreateTable<Performance>();
		}
	}
}
