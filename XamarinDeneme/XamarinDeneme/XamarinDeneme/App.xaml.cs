using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDeneme.Services;
using XamarinDeneme.Views;

namespace XamarinDeneme
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MyContentPage();
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
