using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomRoundCornorView
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage =new NavigationPage(new CustomRoundCornorView.SampleView()) { BarBackgroundColor = Color.White,BarTextColor=Color.FromHex("#15BC98") };

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
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
