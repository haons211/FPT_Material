using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCategoriesApp
{
    internal class MyStockDBContext
    {
    }
    public class Category
    {
        public Category() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriesID { get; set; }
        public string CategoryName { get; set; }
    }
    public class MyStock:MyStockDBContext { 
    }
}
