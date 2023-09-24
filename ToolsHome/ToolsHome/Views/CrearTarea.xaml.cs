using System;
using System.Threading.Tasks;
using ToolsHome.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearTarea : ContentPage
    {
        public CrearTarea()
        {
            InitializeComponent();

        }
        //private async void ToolbarItem_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var tarea = new Tarea
        //        {
        //            Descripcion = txtDescripcion.Text,
        //            FechaRegistro = calFecha.Date,
        //            Estado = cmbEstado.SelectedItem.ToString()
        //        };
        //        var resultado = await App.Context.InsertItemAsync(tarea);

        //        if (resultado == 1)
        //        {
        //            await Navigation.PushAsync(new ToDo());
        //        }
        //        else
        //        {
        //            await DisplayAlert("Error", "No se pudo cargar la tarea", "OK");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("Error", ex.Message, "OK");
        //    }
        }
    }













