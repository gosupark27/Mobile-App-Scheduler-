using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace C971.Models
{
	public class Course
	{
		[PrimaryKey, AutoIncrement, NotNull]
		public int course { get; set; }

		[ForeignKey(typeof(Term))]
		public int termId { get; set; }

		[OneToMany]
		public List<Note> Notes { get; set; }

		[ForeignKey(typeof(Instructor))]
		public int instructorId { get; set; }
		[OneToOne]
		public Instructor instructor { get; set; }

		[ForeignKey(typeof(Objective))]
		public int objectiveId { get; set; }
		[OneToOne]
		public Objective objective { get; set; }

		[ForeignKey(typeof(Performance))]
		public int performanceId { get; set; }
		[OneToOne]
		public Performance performance { get; set; }

		public string name { get; set; }
		public string status { get; set; } //should status be enumerated type? 
		public DateTime start_date { get; set; }
		public DateTime end_date { get; set; }
	}
}
