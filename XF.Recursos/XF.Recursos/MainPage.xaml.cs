﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Recursos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.SimplesView());
        }

        private async void btnDinamico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.DinamicoView());
        }

        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.GeralView());
        }

        private async void btnTriggers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.TriggersView());
        }

        private async void btnTemplate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Theme.ThemeView());
        }

        private async void btnHome_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navegacao.HomeView(DateTime.Now.ToString("u")));
        }

        private async void btnMC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navegacao.MCHomeView());
        }

        private async void btnTabbed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navegacao.TabbedHome());
        }

        private async void btnCarousel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navegacao.CarouselHome());
        }

        private async void btnMasterDetail_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new Menu.MestreDetalheView());
        }

        private async void btnListSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista.SimplesView());
        }

        private async void btnClasse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lista.ClasseView());
        }

        private async void btnLigar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new API.PhoneView());
        }

        private async void btnMestre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Menu.MainPage());
        }

        private async void btnLocation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GPS.CoordenadaView());
        }

        private async void btnCamera_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new API.CameraView());
        }

        private async void btnCustom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomControl.CustomView());
        }
    }
}
