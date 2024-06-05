using AdventureWorks.Models;

namespace AdventureWorks.ViewModels
{
    public class ProductoPorColor02 : IProductoPorColorBuilder
    {
        private readonly AdventureWorks2016Context _context;

        public ProductoPorColor02(AdventureWorks2016Context context)
        {
            this._context = context;
        }
        public List<ProductoVenta> DamePorColor(string color)
        {
            var resultado =
                from p in this._context.Products
                join l in this._context.SalesOrderDetails
                    on p.ProductId equals l.ProductId
                where p.Color == color &&
                      l.OrderQty > 2
                select new ProductoVenta()
                {   
                    ProductName = p.Name + p.Style,
                    ProductoVentaId = p.ProductId,
                    unidadesVendidas = l.OrderQty
                };
            return resultado.ToList();




        }
    }
}
