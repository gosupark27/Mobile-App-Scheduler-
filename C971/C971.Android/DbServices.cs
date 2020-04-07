using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using C971.Droid;
using C971.Services;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(DbServices))]

namespace C971.Droid
{
	class DbServices : IDbServices
	{
		public SQLiteAsyncConnection Connection()
		{
			var docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments); //Special Folder "MyDocuments" can be changed
			var path = Path.Combine(docPath, "MySQLite.db3"); //fileName for db can be changed

			return new SQLiteAsyncConnection(path);
		}
	}
}