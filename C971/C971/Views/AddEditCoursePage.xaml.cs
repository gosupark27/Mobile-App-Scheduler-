﻿using C971.Models;
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
	public partial class AddEditCoursePage : ContentPage
	{
		public AddEditCoursePage()
		{
			InitializeComponent();
		}

		async void Cancel_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void Save_Clicked(object sender, EventArgs e)
		{
			var course = (Course)BindingContext;
			await App.Database.SaveCourseAsync(course);
			await Navigation.PopAsync();
		}
	}
}