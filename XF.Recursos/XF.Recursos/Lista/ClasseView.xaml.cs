using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Lista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClasseView : ContentPage
    {
        public ClasseView()
        {
            InitializeComponent();

            lstCursos.ItemsSource = Curso.GetListaDeCursos();
        }

        private void lstCursos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Curso selecionado = e.SelectedItem as Curso;
            DisplayAlert("Item", string.Format("Unidade: {0}", selecionado.Unidade), "OK");
        }
    }
}
