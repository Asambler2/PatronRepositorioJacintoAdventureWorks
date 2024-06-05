using AdventureWorks.Models;

namespace AdventureWorks.ViewModels
{
    public class ProductoPorColorViewModel
    {
        public string Color { get; set; }
        public List<ProductoVenta> VentasDeProducto { get; set; }}

    public class ProductoVenta
    {
        public int ProductoVentaId { get; set; }
        public string ProductName { get; set; }
        public int unidadesVendidas { get; set; }
    }
}
