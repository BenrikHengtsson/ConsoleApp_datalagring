using ConsoleApp_datalagring.Data;
using ConsoleApp_datalagring.Entities;

namespace ConsoleApp_datalagring.Repositories
{
    internal class RoleRepository : Repo<RolesEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
