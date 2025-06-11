using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIProyectoFinal.Models;

namespace WebAPIProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaRopaController : ControllerBase
    {
        private readonly DbTiendaRopaContext _context;

        public TiendaRopaController(DbTiendaRopaContext context)
        {
            _context = context;
        }

        // MÉTODOS INVENTARIO

        [HttpGet("inventario")]
        public async Task<ActionResult<IEnumerable<Inventario>>> GetInventarios()
        {
            return await _context.Inventarios.ToListAsync();
        }

        [HttpGet("inventario/{id}")]
        public async Task<ActionResult<Inventario>> GetInventario(int id)
        {
            var inventario = await _context.Inventarios.FirstOrDefaultAsync(i => i.IdInventario == id);
            if (inventario == null) return NotFound();
            return inventario;
        }

        [HttpPost("inventario")]
        public async Task<ActionResult<Inventario>> CrearInventario(Inventario inventario)
        {
            _context.Inventarios.Add(inventario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInventario), new { id = inventario.IdInventario }, inventario);
        }

        [HttpPut("inventario/{id}")]
        public async Task<IActionResult> ActualizarInventario(int id, Inventario inventario)
        {
            if (id != inventario.IdInventario) return BadRequest();
            _context.Entry(inventario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("inventario/{id}")]
        public async Task<IActionResult> EliminarInventario(int id)
        {
            var inv = await _context.Inventarios.FindAsync(id);
            if (inv == null) return NotFound();
            _context.Inventarios.Remove(inv);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //  MÉTODOS PRODUCTO

        [HttpGet("producto")]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        [HttpGet("producto/{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) return NotFound();
            return producto;
        }

        [HttpPost("producto")]
        public async Task<ActionResult<Producto>> CrearProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProducto), new { id = producto.IdProducto }, producto);
        }

        [HttpPut("producto/{id}")]
        public async Task<IActionResult> ActualizarProducto(int id, Producto producto)
        {
            if (id != producto.IdProducto) return BadRequest();
            _context.Entry(producto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("producto/{id}")]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) return NotFound();
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //  MÉTODOS INVENTARIO DETALLE

        [HttpGet("detalle")]
        public async Task<ActionResult<IEnumerable<InventarioDetalle>>> GetDetalles()
        {
            return await _context.InventarioDetalles
               // .Include(d => d.ProductoidProductoNavigation)
                //.Include(d => d.InventarioidInventarioNavigation)
                .ToListAsync();
        }


        [HttpPost("detallevalidado")]
        public async Task<ActionResult<InventarioDetalle>> CrearDetallevalida(InventarioDetalle detalle)
        {
            // Validar existencia de producto e inventario
            var productoExiste = await _context.Productos.AnyAsync(p => p.IdProducto == detalle.ProductoidProducto);
            var inventarioExiste = await _context.Inventarios.AnyAsync(i => i.IdInventario == detalle.InventarioidInventario);

            if (!productoExiste || !inventarioExiste)
            {
                return BadRequest("El producto o el inventario no existen.");
            }

            // Validar que la combinación producto-inventario no exista ya en InventarioDetalle
            var existeDetalle = await _context.InventarioDetalles
                .AnyAsync(d => d.ProductoidProducto == detalle.ProductoidProducto &&
                               d.InventarioidInventario == detalle.InventarioidInventario);

            if (existeDetalle)
            {
                return BadRequest("Ya existe un inventario detalle con ese producto e inventario.");
            }

            // Agregar nuevo detalle si todo es válido
            _context.InventarioDetalles.Add(detalle);
            await _context.SaveChangesAsync();
            return Ok(detalle);
        }
        //[HttpPost("detalle")]
        //public async Task<ActionResult<InventarioDetalle>> CrearDetalle(InventarioDetalle detalle)
        //{
        //    // Validar existencia de producto e inventario
        //    var productoExiste = await _context.Productos.AnyAsync(p => p.IdProducto == detalle.ProductoidProducto);
        //    var inventarioExiste = await _context.Inventarios.AnyAsync(i => i.IdInventario == detalle.InventarioidInventario);

        //    if (!productoExiste || !inventarioExiste)
        //    {
        //        return BadRequest("Producto o inventario no existe.");
        //    }
        //    _context.InventarioDetalles.Add(detalle);
        //    await _context.SaveChangesAsync();
        //    return Ok(detalle);
        //}

        [HttpPut("detalle")]
        public async Task<IActionResult> ActualizarDetalle(InventarioDetalle detalle)
        {
            var existente = await _context.InventarioDetalles.FirstOrDefaultAsync(d =>
                d.ProductoidProducto == detalle.ProductoidProducto &&
                d.InventarioidInventario == detalle.InventarioidInventario);

            if (existente == null) return NotFound();

            existente.Cantidad = detalle.Cantidad;
            existente.Total = detalle.Total;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("detalle")]
        public async Task<IActionResult> EliminarDetalle([FromQuery] int productoid, [FromQuery] int inventarioid)
        {
            var detalle = await _context.InventarioDetalles.FirstOrDefaultAsync(d =>
                d.ProductoidProducto == productoid && d.InventarioidInventario == inventarioid);

            if (detalle == null) return NotFound();

            _context.InventarioDetalles.Remove(detalle);
            await _context.SaveChangesAsync();
            return NoContent();
        }


       


       

    }

}
