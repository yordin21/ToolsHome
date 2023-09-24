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
            //CargarItems();
        }

        //private async void CargarItems()
        //{
        //    var Tareas = await App.Context.GetItemsAsync();
        //    cvTareas.ItemsSource = Tareas;
        //}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearTarea());
        }

        //private async void EliminarTarea_Clicked(object sender, EventArgs e)
        //{
        //    var eliminar = cvTareas.SelectedItems;
   
        //    foreach (var elemento in eliminar)
        //    {
        //        if (elemento is Tarea tarea)

        //        {
        //            await App.Context.DeleteItemAsync(tarea);

        //            CargarItems();
        //        }


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



//public IList<String> Tareas1 { get; set; }
//public IList<String> Tareas2 { get; set; }
//public IList<String> Tareas3 { get; set; }