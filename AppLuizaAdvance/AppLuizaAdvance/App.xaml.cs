using AppLuizaAdvance.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLuizaAdvance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NovoTaxaPromoPage());
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
