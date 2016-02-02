using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace Geolocation
{
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var loc = CrossGeolocator.Current;
            var pos = await loc.GetPositionAsync(10000);

            if (pos == null)
            {
                await DisplayAlert("Error", "No hemos recibido su posicion", "Aceptar");
                return;
            }

            else
            {
                TxtLat.Text = pos.Latitude.ToString();
                TxtLong.Text = pos.Longitude.ToString();
            }


        }

        private void ButtonDelete(object sender, EventArgs e)
        {

            TxtLat.Text = "";
            TxtLong.Text = "";




        }
    }
}
