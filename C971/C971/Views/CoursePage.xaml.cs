using C971.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace C971.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CoursePage : ContentPage
	{
		public ObservableCollection<string> Items { get; set; }

		public CoursePage()
		{
			InitializeComponent();

			Items = new ObservableCollection<string>
			{
				"Item 1",
				"Item 2",
				"Item 3",
				"Item 4",
				"Item 5"
			};

			MyListView.ItemsSource = Items;
		}

		//Need to add constructor to coursedetailpage that takes in course item 
		async void Course_Clicked(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
				return;
			Course course = (Course)e.Item;
			await Navigation.PushModalAsync(new CourseDetailPage(course));
		}

		async void Edit_Clicked()
		{
			await Navigation.PushModalAsync(new NavigationPage(new AddEditCoursePage()));
		}
	}
}
