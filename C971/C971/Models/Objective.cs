using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Models
{
	public class Objective
	{
		[PrimaryKey, AutoIncrement, NotNull]
		public int objective { get; set; }
		public string name { get; set; }
		public DateTime start_date { get; set; }
		public DateTime end_date { get; set; }
	}
}
