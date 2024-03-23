using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Entities
{
    internal class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }



        //[ForeignKey(nameof(CategoryEntity))] - detta sett bör undvikas.
        public int CategoryOd { get; set; }
        //bör göras som nedstående, kan anvandas med joinsatser nu.
        public CategoryEntity Category { get; set; } = null!;
        public int CategoryId { get; internal set; }
    }
}


