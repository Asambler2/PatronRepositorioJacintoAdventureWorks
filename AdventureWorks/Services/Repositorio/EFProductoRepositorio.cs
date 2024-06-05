using AdventureWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Services.Repositorio
{
    public class EFProductoRepositorio : IProductoRepositorio
    {
        private readonly AdventureWorks2016Context _context = new();  
        public List<Product> DameTodos()
        {
            return _context.Products.AsNoTracking().ToList();

        }

        public Product? DameUno(int Id)
        {
            return _context.Products.Find(Id);
        }

        public bool BorrarProducto(int Id)
        {
            if (DameUno(Id) != null)
            {
                _context.Products.Remove(DameUno(Id));
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Agregar(Product product)
        {
            if (DameUno(product.ProductId) != null)
            {

                return false;
            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return true;
            }
        }

        public void Modificar(int Id, Product product)
        {
            var recupera = DameUno(Id);
            if (recupera != null)
            {
                BorrarProducto(Id);
            }
            Agregar(product);
        }
    }
}
