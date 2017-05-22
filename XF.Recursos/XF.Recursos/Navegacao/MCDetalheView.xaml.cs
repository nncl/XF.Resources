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
    public partial class MCDetalheView : ContentPage
    {
        public MCDetalheView()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MCHomeView, Contato>(
                this, App_Code.MessagingViewModel.Navegacao.Alterar.ToString(),
               (navegarParametro, param) =>
               {
                   BindingContext = param;
                   MessagingCenter.Unsubscribe<MCHomeView, Contato>(
                       this, App_Code.MessagingViewModel.Navegacao.Alterar.ToString());
               });
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
