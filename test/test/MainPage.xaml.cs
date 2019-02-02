using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

namespace test
{
    public partial class MainPage : ContentPage
    {
          
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

           
        }
        private async void ButtonWpp(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Run(() => { Device.OpenUri(new Uri("https://wa.me/5491145281006")); });
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Task.Run(() => { UIApplication.SharedApplication.OpenUrl(new NSUrl("https://wa.me/5491145281006")); });
            }
        }
        private async void ButtonWeb(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Run(() => { Device.OpenUri(new Uri("http://www.copello.com.ar/")); });
            }
            if(Device.RuntimePlatform == Device.iOS)
            {
                await Task.Run(() => { UIApplication.SharedApplication.OpenUrl(new NSUrl("http://www.copello.com.ar/")); });
            }
        }
        private async void ButtonExp(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Run(() => { Device.OpenUri(new Uri("https://www.pagomiexpensa.com.ar/")); });
            }
            if(Device.RuntimePlatform == Device.iOS)
            {
                await Task.Run(() => { UIApplication.SharedApplication.OpenUrl(new NSUrl("https://www.pagomiexpensa.com.ar/")); });
            }
        }
        private async void ButtonCnRed(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Run(() => { Device.OpenUri(new Uri("http://www.consorciosenred.com/cerDevelopment/cer_nav.nsf/inicio.html")); });
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Task.Run(() => { UIApplication.SharedApplication.OpenUrl(new NSUrl("http://www.consorciosenred.com/cerDevelopment/cer_nav.nsf/inicio.html")); });
            }                
        }
        private async void ButtonFb(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Run(() => { Device.OpenUri(new Uri("https://m.facebook.com/EstudioRjcopello/")); });
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Task.Run(() => { UIApplication.SharedApplication.OpenUrl(new NSUrl("https://m.facebook.com/EstudioRjcopello/")); });
            }
        }
        private async void ButtonIg(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Run(() => { Device.OpenUri(new Uri("https://www.instagram.com/estudiorjcopello/?utm_source=ig_profile_share&igshid=14vrshew50yk2&fbclid=IwAR2TpgzoMXazmMzDNMTF-NfQdpl_Rwi0A1Ifb7h_26QsD4B8bCeuyAUH-bM")); });
            }
            if(Device.RuntimePlatform == Device.iOS)
            {
                await Task.Run(() => { UIApplication.SharedApplication.OpenUrl(new NSUrl("https://www.instagram.com/estudiorjcopello/?utm_source=ig_profile_share&igshid=14vrshew50yk2&fbclid=IwAR2TpgzoMXazmMzDNMTF-NfQdpl_Rwi0A1Ifb7h_26QsD4B8bCeuyAUH-bM")); });
            }
        }
        private async void ButtonFaq(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FaqPage());
        }
        private async void ButtonAcercaDe(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AcercaDePage());
        }

       
    }

}
    

