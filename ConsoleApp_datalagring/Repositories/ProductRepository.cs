using ConsoleApp_datalagring.Data;
using ConsoleApp_datalagring.Entities;

namespace ConsoleApp_datalagring.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
