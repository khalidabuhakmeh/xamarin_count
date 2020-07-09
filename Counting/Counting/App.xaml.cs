using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Counting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var cs = ColorScheme.Random();
            
            MainPage = new NavigationPage(new MainPage())
            {
                Title = "🧛‍ The Count",
                BarTextColor = Color.FromHex(cs.Text),
                BarBackgroundColor = Color.FromHex(cs.Background)
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}