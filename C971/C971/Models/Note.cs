using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Models
{
	public class Note
	{
		[PrimaryKey, AutoIncrement, NotNull]
		public int note { get; set;}

		[ForeignKey(typeof(Course))]
		public int noteId { get; set; }
		public string name { get; set; }
		public string description { get; set; }

	}
}
