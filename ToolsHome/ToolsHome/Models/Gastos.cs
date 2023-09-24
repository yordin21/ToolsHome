using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsHome.Models
{
    public class Gastos
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
    }
}