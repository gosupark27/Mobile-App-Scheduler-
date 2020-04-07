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
	public partial class NotePage : ContentPage
	{
		public NotePage()
		{
			InitializeComponent();
		}

		async void Cancel_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void Save_Clicked(object sender, EventArgs e)
		{
			var note = (Note)BindingContext;
			await App.Database.SaveNoteAsync(note);
			await Navigation.PopAsync();
		}
	}
}