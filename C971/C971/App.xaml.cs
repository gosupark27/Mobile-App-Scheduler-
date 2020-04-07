using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using C971.Services;
using C971.Views;

namespace C971
{
	public partial class App : Application
	{
		static C971Database database;
		public App()
		{
			InitializeComponent();

			var nav = new NavigationPage(new TermPage());

			//DependencyService.Register<MockDataStore>();
			MainPage = nav;
		}

		public static C971Database Database
		{
			get
			{
				if(database == null)
				{
					database = new C971Database();
				}
				return database;
			}
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
