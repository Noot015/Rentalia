﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Rentalia.Data;
using Rentalia.FourMistakesAPIClient;

namespace Rentalia
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            //START
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
