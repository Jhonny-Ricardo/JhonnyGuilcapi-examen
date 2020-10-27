using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhonnyGuilcapi_examen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // habilitar la navegacion
            MainPage = new NavigationPage (new MainPage());
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
