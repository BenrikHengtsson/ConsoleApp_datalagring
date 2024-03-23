using ConsoleApp_datalagring.Data;
using ConsoleApp_datalagring.Entities;

namespace ConsoleApp_datalagring.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }
}
