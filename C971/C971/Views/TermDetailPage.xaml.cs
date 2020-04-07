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
	public partial class TermDetailPage : ContentPage
	{
		public TermDetailPage()
		{
			InitializeComponent();
		}

		public TermDetailPage(Term term)
		{
			InitializeComponent();

			App.Database.GetCourseAsync(term.term);
			//Hmmm maybe grab either do id or do a search that'll match the term name
			//then you would grab that record from the Term table and then populate the field 
		}

		async void Edit_Clicked()
		{
			await Navigation.PushModalAsync(new NavigationPage(new AddEditTermPage()));
		}

		async void View_Clicked()
		{
			await Navigation.PushModalAsync(new NavigationPage(new CoursePage()));
		}

		//Are we suppose to popmodal or just pop? 
		async void Delete_Clicked()
		{
			var term = (Term)BindingContext;
			await App.Database.DeleteTermAsync(term);
			await Navigation.PopModalAsync();

		}
	}
}