using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Models
{
	public class Course
	{
		public int course { get; set; }
		public int term { get; set; }
		public int note { get; set; }
		public int instructor { get; set; }
		public int objective { get; set; }
		public int performance { get; set; }
		public string name { get; set; }
		public string status { get; set; } //should status be enumerated type? 
		public DateTime start_date { get; set; }
		public DateTime end_date { get; set; }
	}
}
