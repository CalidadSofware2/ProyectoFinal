using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAPIProyectoFinal.Models;

public partial class Inventario
{
   // [JsonIgnore]
    public int IdInventario { get; set; }

    public DateOnly Fecha { get; set; }

    [JsonIgnore]
    public virtual ICollection<InventarioDetalle> InventarioDetalles { get; set; } = new List<InventarioDetalle>();
}
