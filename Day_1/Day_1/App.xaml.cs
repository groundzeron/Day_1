﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Day_1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
			//MainPage = new Day_1.MainPage();
            MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("4b68167c-5d6b-459d-8986-ab0ed7eeb146",typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

	}
}
