using Foundation;
using System;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using Xamarin.Essentials;
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
            await Browser.OpenAsync("https://wa.me/5491145281006");
        }
        private async void ButtonWeb(object sender, EventArgs args)
        {
            await Browser.OpenAsync("http://www.copello.com.ar/");
        }
        private async void ButtonExp(object sender, EventArgs args)
        {
            await Browser.OpenAsync("https://www.pagomiexpensa.com.ar/");
        }
        private async void ButtonCnRed(object sender, EventArgs args)
        {
            await Browser.OpenAsync("http://www.consorciosenred.com/cerDevelopment/cer_nav.nsf/inicio.html");               
        }
        private async void ButtonFb(object sender, EventArgs args)
        {
            await Browser.OpenAsync("https://m.facebook.com/EstudioRjcopello/");
        }
        private async void ButtonIg(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.instagram.com/estudiorjcopello/?utm_source=ig_profile_share&igshid=14vrshew50yk2&fbclid=IwAR2TpgzoMXazmMzDNMTF-NfQdpl_Rwi0A1Ifb7h_26QsD4B8bCeuyAUH-bM");
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
    

