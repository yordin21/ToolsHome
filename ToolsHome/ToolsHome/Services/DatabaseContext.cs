using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToolsHome.Models;
using Xamarin.Forms;

namespace ToolsHome.Services
{
    public class DatabaseContext
    {
        public SQLiteAsyncConnection Connection { get; set; }

        public DatabaseContext(string path)
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<Tarea>().Wait();
            Connection.CreateTableAsync<Gastos>().Wait();

        }

        public async Task<List<Gastos>> GetGastosAsync()
        {
            return await Connection.Table<Gastos>().ToListAsync();
        }

        public async Task<int> InsertItemAsync(Gastos item)
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<int> DeleteGastosAsync(int ID)
        {
            return await Connection.DeleteAsync<Gastos>(ID);

        }




        public async Task<List<Tarea>> GetItemsAsync()
        {
            return await Connection.Table<Tarea>().ToListAsync();
        }

        public async Task<int> InsertItemAsync(Tarea item)
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(Tarea tarea)
        {
            return await Connection.DeleteAsync(tarea);
        }

 
        
    }

}




