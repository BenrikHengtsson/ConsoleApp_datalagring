using ConsoleApp_datalagring.Data;
using ConsoleApp_datalagring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Repositories
{
    internal class AdressRepository : Repo<AdressEntity>
    {
        public AdressRepository(DataContext context) : base(context)
        {
        }
    }
}
