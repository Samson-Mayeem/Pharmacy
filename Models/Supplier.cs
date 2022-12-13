using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models
{
    public class Supplier
    {
        [Key]
        public long Expiry_ID { get; set; }
        public string? Supplier_Name { get; set; }
        public string? Supplier_Address { get; set; }
        public string? Supplier_Contact { get; set; }
        public string? Supplier_Telephone { get; set; }
    }
}