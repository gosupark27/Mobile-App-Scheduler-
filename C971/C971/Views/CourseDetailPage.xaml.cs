using C971.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace C971.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CourseDetailPage : ContentPage
	{
		public CourseDetailPage()
		{
			InitializeComponent();
		}

		public CourseDetailPage(Course course)
		{
			InitializeComponent();
			App.Database.GetCourseAsync(course.course);
			//TODO: Populate the fields idk lol. 
		}

		async void Edit_Clicked()
		{
			await Navigation.PushModalAsync(new NavigationPage(new AddEditTermPage()));
		}

		//Need to get binding context of selected course...(maybe look @ itemtappedeventargs??) 
		async void Delete_Clicked()
		{
			var course = (Course)BindingContext;
			await App.Database.DeleteCourseAsync(course);
			await Navigation.PopModalAsync();
			
		}
	}

	
}