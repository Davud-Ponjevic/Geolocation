using Microsoft.Maui.Controls;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Map; // Hier wird der Namespace für die SecureStorageHelper-Klasse importiert

namespace Map
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Setzen Sie den API-Schlüssel, bevor die Karte initialisiert wird
            await SecureStorageHelper.SetApiKeyAsync("AIzaSyBdGPcZoeKFxy7w8qfOrpkQcMhutGjePUs");

            // Führen Sie hier weitere Initialisierungsschritte durch
        }
    }
}
