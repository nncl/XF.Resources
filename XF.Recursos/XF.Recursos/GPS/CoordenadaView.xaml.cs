﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.GPS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoordenadaView : ContentPage
    {
        public CoordenadaView()
        {
            InitializeComponent();
        }

        private void btnCoordenada_Clicked(object sender, EventArgs e)
        {
            ILocalizacao geolocation = DependencyService.Get<ILocalizacao>();
            geolocation.GetCoordenada();

            MessagingCenter.Subscribe<ILocalizacao, Coordenada>(this, "coordenada",
                (objeto, geo) =>
                {
                    lblLatitude.Text = geo.Latitude;
                    lblLongitude.Text = geo.Longitude;
                });
        }
    }
}
