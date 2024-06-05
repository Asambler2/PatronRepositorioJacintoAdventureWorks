
using AdventureWorks.Models;

namespace AdventureWorks.ViewModels
{
    public class CreaListaPorColorViewModel : ICreaListaPorColorViewModel
    {
        private readonly AdventureWorks2016Context context;
        private readonly IProductoPorColorBuilder builder;

        public CreaListaPorColorViewModel(AdventureWorks2016Context context, IProductoPorColorBuilder builder)
        {
            this.context = context;
            this.builder = builder;
        }
        public List<ProductoPorColorViewModel> dameTodosLosColores()
        {
            var ProductosDistintos = from p in context.Products.ToList() group(p) by p.Color into g
                select g;

            List<ProductoPorColorViewModel> coleccionADevolver = new();
            foreach (var _colorDistinto in ProductosDistintos)
            {
                ProductoPorColorViewModel ElementoAPoner = 
                    new() { Color = _colorDistinto.Key , VentasDeProducto = 
                            new ProductoPorColor01(this.context).
                                DamePorColor(_colorDistinto.Key).ToList()};
                coleccionADevolver.Add(ElementoAPoner);
            }
            return coleccionADevolver;
        }
    }
}
