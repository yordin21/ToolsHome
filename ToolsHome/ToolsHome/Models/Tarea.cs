using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsHome.Models
{
    public class Tarea
    {

        public int IDTarea { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estado { get; set; }

    }
}
