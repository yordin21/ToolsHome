using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mts2 : ContentPage
    {
        double alto = 0;
        double ancho = 0;

        public Mts2()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Clicked(Object sender, EventArgs e)
        {
            alto = Convert.ToDouble(txtAlto.Text);
            ancho = Convert.ToDouble(txtAncho.Text);

            lblRespuesta.Text = (alto * ancho).ToString();
        }
    }
}
