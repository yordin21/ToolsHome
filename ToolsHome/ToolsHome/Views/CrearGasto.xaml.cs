using SQLite;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using ToolsHome.Models;
using ToolsHome.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class CrearGasto : ContentPage
    {
        
        public CrearGasto()
        {
            InitializeComponent();
        }

        private async void AgregarGasto_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(MontoEntry.Text, out double monto))
                {
                    var gasto = new Gastos
                    {
                        Descripcion = DescripcionEntry.Text,
                        Categoria = CategoriaPicker.SelectedItem?.ToString(),
                        Fecha = FechaDatePicker.Date,
                        Monto = monto
                    };
                    var resultado = await App.Context.InsertItemAsync(gasto);

                    if (resultado == 1)
                    {
                       
                        await Navigation.PushAsync(new ControlGastos());
                    }
                    else
                    {
                        await DisplayAlert("Error", "No se pudo cargar el gasto", "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Monto no válido", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
       
        }
    }
    


