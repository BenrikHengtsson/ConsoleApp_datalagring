using ConsoleApp_datalagring.Data;
using ConsoleApp_datalagring.Entities;

namespace ConsoleApp_datalagring.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
