using C971.Models;
using C971.ViewModels;
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
	public partial class TermPage : ContentPage
	{
		TermViewModel viewModel;
		public ObservableCollection<string> Items { get; set; }

		public TermPage()
		{
			InitializeComponent();
			viewModel = new TermViewModel();
			BindingContext = viewModel;

			//Items = new ObservableCollection<string>
			//{
			//	"Item 1",
			//	"Item 2",
			//	"Item 3",
			//	"Item 4",
			//	"Item 5"
			//};

			//MyListView.ItemsSource = Items;
		}
		
		//Clicking on term from the list will lead the user to TermDetail Page 
		async void Term_Clicked(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
				return;
			Term term = (Term)e.Item;
			await Navigation.PushModalAsync(new TermDetailPage(term));
		}

		async void AddTerm_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new NavigationPage(new AddEditTermPage()));
		}
	}
}
