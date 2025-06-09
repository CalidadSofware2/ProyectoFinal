using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPIProyectoFinal.Models;

public partial class InventarioDetalle
{
    public int ProductoidProducto { get; set; }

    public int InventarioidInventario { get; set; }

    public int Cantidad { get; set; }

    public decimal Total { get; set; }


    //[JsonIgnore]
    //public virtual Inventario InventarioidInventarioNavigation { get; set; } = null!;
   // [JsonIgnore]
   // public virtual Producto ProductoidProductoNavigation { get; set; } = null!;
}
