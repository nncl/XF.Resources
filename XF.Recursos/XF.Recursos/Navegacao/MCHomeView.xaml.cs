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
    public partial class MCHomeView : ContentPage
    {
        public MCHomeView()
        {
            InitializeComponent();
            AtivarCentroMensagens();
        }

        private void AtivarCentroMensagens()
        {
            MessagingCenter.Subscribe<MCHomeView>(this, "MensagemInfo",
                (sender) => { lblBoasVindas.Text = "Continue explorando..."; });
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MCInfoView());
        }

        private async void btnDetalhe_Clicked(object sender, EventArgs e)
        {
            var detalhe = new MCDetalheView();
            await Navigation.PushAsync(detalhe);
            var contato = new Contato
            {
                Nome = "Flavio Mariotti",
                Idade = 32,
                Profissao = "Developer",
                Pais = "Brasil"
            };

            MessagingCenter.Send<MCHomeView, Contato>(
                this, App_Code.MessagingViewModel.Navegacao.Alterar.ToString(), contato);
        }
    }
}
