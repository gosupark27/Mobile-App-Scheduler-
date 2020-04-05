using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using C971.Services;
using C971.Views;

namespace C971
{
	public partial class App : Application
	{
		public static string DatabaseLocation = string.Empty;

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new MainPage();
		}

		public App(string databaseLocation)
		{

			InitializeComponent();
			MainPage = new NavigationPage(new MainPage());
			DatabaseLocation = databaseLocation;
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
