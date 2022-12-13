using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models
{
    public class Stock
    {
        [Key]
        public long Drug_Id { get; set; }
        public string? Supplier_Id { get; set; }
        public DateTime Supply_Date { get; set; }
        public Decimal Price { get; set; }
        public Decimal Tax { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Buy_Price { get; set; }
        public Decimal Selling_Price { get; set; }
        public string? Current_Invent { get; set; }

    }
}