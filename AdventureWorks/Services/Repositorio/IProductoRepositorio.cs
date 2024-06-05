using AdventureWorks.Models;
using Microsoft.Data.SqlClient.DataClassification;

namespace AdventureWorks.Services.Repositorio
{
    public interface IProductoRepositorio
    {
        List<Product> DameTodos();
        Product? DameUno(int Id);
        bool BorrarProducto(int Id);
        bool Agregar(Product product);
        void Modificar(int Id, Product product);


    }
}
