using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ToolsHome.Models;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDo : ContentPage
    {
        public ToDo()
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
            var Tareas = await App.Context.GetItemsAsync();
            cvTareas.ItemsSource = Tareas;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearTarea());
        }

        private async void EliminarTarea_Clicd(object sender, EventArgs e)
        {
            if (cvTareas.SelectedItem is Tarea tareaSeleccionada)
            {
                if (await DisplayAlert("Confirmación", "¿Estás seguro de que deseas eliminar esta tarea?", "Sí", "Cancelar"))
                {
                    int resultado = await App.Context.DeleteItemAsync(tareaSeleccionada);

                    if (resultado == 1)
                    {
                        await DisplayAlert("Éxito", "Tarea eliminada correctamente", "OK");
                        CargarItems();
                    }
                    else
                    {
                        await DisplayAlert("Error", "No se pudo eliminar la tarea", "OK");
                    }
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, seleccione una tarea para eliminar.", "OK");
            }
        }
    }
}



/*Tareas1 = new List<String>();
Tareas1.Add("Tarea 4");
Tareas1.Add("Tarea 5");
Tareas1.Add("Tarea 6");

lista1.ItemsSource = Tareas1;

Tareas3 = new List<Tarea>();



Tareas3.Add(new Tarea
{
    IDTarea = 1,
    Descripcion = "Tarea 7",
    FechaRegistro = DateTime.Now,
    Estado = "Pendiente"
});
Tareas3.Add(new Tarea
{
    IDTarea = 1,
    Descripcion = "Tarea 8",
    FechaRegistro = DateTime.Now,
    Estado = "Pendiente"
});
Tareas3.Add(new Tarea
{
    IDTarea = 1,
    Descripcion = "Tarea 9",
    FechaRegistro = DateTime.Now,
    Estado = "Hecho"
});



lista3.ItemsSource = Tareas3;

Tareas4 = new List<Tarea>();



Tareas4.Add(new Tarea
{
    IDTarea = 1,
    Descripcion = "Tarea 10",
    FechaRegistro = DateTime.Now,
    Estado = "Pendiente"
});
Tareas4.Add(new Tarea
{
    IDTarea = 1,
    Descripcion = "Tarea 11",
    FechaRegistro = DateTime.Now,
    Estado = "Pendiente"
});
Tareas4.Add(new Tarea
{
    IDTarea = 1,
    Descripcion = "Tarea 12",
    FechaRegistro = DateTime.Now,
    Estado = "Hecho"
});

cvlLista4 .ItemsSource = Tareas4;

}
} 
}
*/