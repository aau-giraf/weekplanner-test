using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeekPlanner.ApplicationObjects;
using Autofac;

namespace WeekPlanner.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestingView : ContentPage
	{
        private readonly LoginView _loginPage;
        public TestingView (LoginView loginPage)
		{
            InitializeComponent ();
           
            Title = "Navigering";

            _loginPage = loginPage;
		}

        private async void Login_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(_loginPage);
        }
    }
}