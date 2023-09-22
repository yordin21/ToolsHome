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
        private Tarea tareaSeleccionadaParaEliminar;

        public CrearTarea()
        {
            InitializeComponent();

            cvTareas.ItemSelected += OnItemSelected;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                var tarea = new Tarea
                {
                    Descripcion = txtDescripcion.Text,
                    FechaRegistro = calFecha.Date,
                    Estado = cmbEstado.SelectedItem.ToString()
                };
                var resultado = await App.Context.InsertItemAsync(tarea);

                if (resultado == 1)
                {
                    await Navigation.PushAsync(new ToDo());
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo cargar la tarea", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void EliminarTarea_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (await DisplayAlert("Confirmación", "¿Estás seguro de que deseas eliminar esta tarea?", "Sí", "Cancelar"))
                {
                    if (tareaSeleccionadaParaEliminar != null)
                    {
                        int resultado = await App.Context.DeleteItemAsync(tareaSeleccionadaParaEliminar);

                        if (resultado == 1)
                        {
                            await DisplayAlert("Éxito", "Tarea eliminada correctamente", "OK");
                        }
                        else
                        {
                            await DisplayAlert("Error", "No se pudo eliminar la tarea", "OK");
                        }

                        tareaSeleccionadaParaEliminar = null;
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Tarea tareaSeleccionada)
            {
                tareaSeleccionadaParaEliminar = tareaSeleccionada;
            }
            else
            {
                tareaSeleccionadaParaEliminar = null;
            }
        }
    }
}











