using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Navegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor com parametro de entrada do tipo string
        /// </summary>
        /// <param name="paramData">Passar o horário do dispositivo</param>
        public HomeView(string paramData)
        {
            InitializeComponent();

            lblData.Text = paramData;
        }

        private async void btnDetalhe_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = "Flavio Mariotti",
                Idade = 32,
                Profissao = "Developer",
                Pais = "Brasil"
            };

            var detalhePage = new DetalheView();
            detalhePage.BindingContext = contato;
            await Navigation.PushAsync(detalhePage);
        }
    }
}
