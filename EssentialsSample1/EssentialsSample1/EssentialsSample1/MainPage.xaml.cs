using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EssentialsSample1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnVibrate(object sender, EventArgs e)
        {
            Vibration.Vibrate();
        }

        private async void OnSpeak(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hello, World!");
        }
    }
}
