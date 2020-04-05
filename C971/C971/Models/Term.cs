using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Models
{
	public class Term
	{
		[PrimaryKey, AutoIncrement, NotNull]
		public int term { get; set; }
		public string name { get; set; }
		public DateTime start_date { get; set; }
		public DateTime end_date { get; set; }
		[OneToMany]
		public List<Course> Courses { get; set; }
	}
}
