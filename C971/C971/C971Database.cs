using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C971.Models;
using SQLite;

namespace C971
{
	public class C971Database
	{
		static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
		{
			return new SQLiteAsyncConnection(Constant.DatabasePath, Constant.Flags);
		});

		static SQLiteAsyncConnection Database => lazyInitializer.Value;
		static bool initalized = false;

		public C971Database()
		{
			InitalizeAsync().SafeFireAndForget(false);
		}

		async Task InitalizeAsync()
		{
			if (!initalized)
			{
				if ((!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Course).Name)))
				{
					await Database.CreateTablesAsync(CreateFlags.None, typeof(Course)).ConfigureAwait(false);
					initalized = true;
				}
				if ((!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Term).Name)))
				{
					await Database.CreateTablesAsync(CreateFlags.None, typeof(Term)).ConfigureAwait(false);
					initalized = true;
				}
				if ((!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Instructor).Name)))
				{
					await Database.CreateTablesAsync(CreateFlags.None, typeof(Instructor)).ConfigureAwait(false);
					initalized = true;
				}
				if ((!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Note).Name)))
				{
					await Database.CreateTablesAsync(CreateFlags.None, typeof(Note)).ConfigureAwait(false);
					initalized = true;
				}
				if ((!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Objective).Name)))
				{
					await Database.CreateTablesAsync(CreateFlags.None, typeof(Objective)).ConfigureAwait(false);
					initalized = true;
				}
				if ((!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Performance).Name)))
				{
					await Database.CreateTablesAsync(CreateFlags.None, typeof(Performance)).ConfigureAwait(false);
					initalized = true;
				}
			}
		}

		//Read from DB 
		public Task<List<Term>> GetTermsAsync()
		{
			return Database.Table<Term>().ToListAsync();
		}
		public Task<Term> GetTermAsync(int id)
		{
			return Database.Table<Term>().Where(i => i.term == id).FirstOrDefaultAsync();
		}
		public Task<List<Course>> GetCoursesAsync()
		{
			return Database.Table<Course>().ToListAsync();
		}
		
		public Task<Course> GetCourseAsync(int id)
		{
			return Database.Table<Course>().Where(i => i.course == id).FirstOrDefaultAsync();
		}

		public Task<Instructor> GetInstructorAsync(int id)
		{
			return Database.Table<Instructor>().Where(i => i.instructor == id).FirstOrDefaultAsync();
		}
		public Task<Note> GetNoteAsync(int id)
		{
			return Database.Table<Note>().Where(i => i.note == id).FirstOrDefaultAsync();
		}
		public Task<Performance> GetPerformanceAsync(int id)
		{
			return Database.Table<Performance>().Where(i => i.performance == id).FirstOrDefaultAsync();
		}
		public Task<Objective> GetObjectiveAsync(int id)
		{
			return Database.Table<Objective>().Where(i => i.objective == id).FirstOrDefaultAsync();
		}

		//Update & Create 
		public Task<int> SaveCourseAsync(Course course)
		{
			if (course.course != 0)
				return Database.UpdateAsync(course);
			else
				return Database.InsertAsync(course);
		}

		public Task<int> SaveTermAsync(Term term)
		{
			if (term.term != 0)
				return Database.UpdateAsync(term);
			else
				return Database.InsertAsync(term);
		}

		public Task<int> SaveInstructorAsync(Instructor instructor)
		{
			if (instructor.instructor != 0)
				return Database.UpdateAsync(instructor);
			else
				return Database.InsertAsync(instructor);
		}

		public Task<int> SaveNoteAsync(Note note)
		{
			if (note.note != 0)
				return Database.UpdateAsync(note);
			else
				return Database.InsertAsync(note);
		}

		public Task<int> SavePerformanceAsync(Performance perf)
		{
			if (perf.performance != 0)
				return Database.UpdateAsync(perf);
			else
				return Database.InsertAsync(perf);
		}

		public Task<int> SaveObjectiveAsync(Objective obj)
		{
			if (obj.objective != 0)
				return Database.UpdateAsync(obj);
			else
				return Database.InsertAsync(obj);
		}

		//Delete
		public Task<int> DeleteCourseAsync(Course course)
		{
			return Database.DeleteAsync(course);
		}

		public Task<int> DeleteTermAsync(Term term)
		{
			return Database.DeleteAsync(term);
		}

		public Task<int> DeleteInstructorAsync(Instructor instructor)
		{
			return Database.DeleteAsync(instructor);
		}

		public Task<int> DeleteNoteAsync(Note note)
		{
			return Database.DeleteAsync(note);
		}
		public Task<int> DeletePerformanceAsync(Performance perf)
		{
			return Database.DeleteAsync(perf);
		}

		public Task<int> DeleteObjectiveAsync(Objective obj)
		{
			return Database.DeleteAsync(obj);
		}
	}
		
}
