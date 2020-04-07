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
	public partial class AssessmentPage : ContentPage
	{
		public AssessmentPage()
		{
			InitializeComponent();
		}

		async void Cancel_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void Save_Clicked(object sender, EventArgs e)
		{
			var obj = (Objective)BindingContext;
			await App.Database.SaveObjectiveAsync(obj);

			var perf = (Performance)BindingContext;
			await App.Database.SavePerformanceAsync(perf);

			await Navigation.PopAsync();
		}
	}
}