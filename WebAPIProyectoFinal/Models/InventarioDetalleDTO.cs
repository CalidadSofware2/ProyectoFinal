namespace WebAPIProyectoFinal.Models
{
    public class InventarioDetalleDTO
    {
        public int ProductoidProducto { get; set; }
        public int InventarioidInventario { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
