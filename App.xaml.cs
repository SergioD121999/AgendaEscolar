using AgendaE.Services;
using AgendaE.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaE
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Inicio();
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
