using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToolsHome.Models;
using System.Windows.Input;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlGastos : ContentPage
    {
        public ControlGastos()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            CargarItems();
        }

        private async void CargarItems()
        {
         
            var Gastos = await App.Context.GetGastosAsync();
            cvGastos.ItemsSource = Gastos;
        }

        private async void AgregarGasto_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearGasto());
        }
        private async void EliminarGastos_Clicked(object sender, EventArgs e)
        {
            var Gastos = cvGastos.SelectedItems;

            foreach (var elemento in Gastos)
            {
                if (elemento is Gastos gastos)
                {
                     await App.Context.DeleteGastosAsync(gastos.ID);
                  
                    CargarItems(); 
                }
            }
        }
    }
}
    

        
 
