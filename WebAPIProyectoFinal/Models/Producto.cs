using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace WebAPIProyectoFinal.Models;

public partial class Producto
{
   // [JsonIgnore]
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public string? Descripcion { get; set; }

    public int CantidadStock { get; set; }

    [JsonIgnore]
    public virtual ICollection<InventarioDetalle> InventarioDetalles { get; set; } = new List<InventarioDetalle>();
}
