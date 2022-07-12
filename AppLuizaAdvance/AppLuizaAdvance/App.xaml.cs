using AppLuizaAdvance.Views;
using Xamarin.Forms;

namespace AppLuizaAdvance
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellPage();
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
