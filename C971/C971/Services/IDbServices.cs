using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Services
{
	public interface IDbServices
	{
		SQLiteAsyncConnection Connection();
	}
}
