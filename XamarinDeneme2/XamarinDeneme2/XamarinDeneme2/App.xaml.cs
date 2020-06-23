using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDeneme2.Services;
using XamarinDeneme2.Views;

namespace XamarinDeneme2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SwitchAndSlide();
             
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
