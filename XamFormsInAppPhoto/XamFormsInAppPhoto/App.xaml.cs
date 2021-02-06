using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsInAppPhoto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InAppCameraPage();
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
