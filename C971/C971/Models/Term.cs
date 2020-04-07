using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Models
{
	public class Term
	{
		//public Term(string name, DateTime start_date, DateTime end_dates)
		//{
		//	this.name = name;
		//	this.start_date = start_date;
		//	this.end_date = end_date;
		//}

		//CRUD methods create sqlite connection for every method (try catch)_ 
		//insert method -- 

		//add method

		//delete method except for delete 

		//update method 

		[PrimaryKey, AutoIncrement, NotNull]
		public int term { get; set; }
		public string name { get; set; }
		public DateTime start_date { get; set; }
		public DateTime end_date { get; set; }
		[OneToMany]
		public List<Course> Courses { get; set; }
	}


}
