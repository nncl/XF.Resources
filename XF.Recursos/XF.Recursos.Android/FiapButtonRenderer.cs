using Xamarin.Forms;
using XF.Recursos.Droid;
using Xamarin.Forms.Platform.Android;
using XF.Recursos.CustomControl;

[assembly: ExportRenderer(typeof(FiapButton), typeof(FiapButtonRenderer))]
namespace XF.Recursos.Droid
{
    class FiapButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Gray);
            }
        }
    }
}
