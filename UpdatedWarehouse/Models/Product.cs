using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpdatedWarehouse.Models
{
    public class Product
    {
        public int ID { get; set; } //Primary Key
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}