using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Entities
{
    internal class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        public string Catagory { get; set; } = null!;
        public string CategoryName { get; internal set; }
        public string CatagoryName { get; internal set; }
    }
}
