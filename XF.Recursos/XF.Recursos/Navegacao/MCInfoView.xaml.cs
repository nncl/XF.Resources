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
    public partial class MCInfoView : ContentPage
    {
        public MCInfoView()
        {
            InitializeComponent();
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            var mcHome = new MCHomeView();
            MessagingCenter.Send<MCHomeView>(mcHome, "MensagemInfo");
            Navigation.PopAsync();
        }
    }
}
