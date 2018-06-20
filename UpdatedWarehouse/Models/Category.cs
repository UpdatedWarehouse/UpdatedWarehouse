using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UpdatedWarehouse.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UpdatedWarehouse.Models
{

    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
        public string Type  { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}