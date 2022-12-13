using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public String? Customer_Reference {get; set;}
        public String? Customer_Name {get; set;}
        public String? Customer_Address {get; set;}
        public String? Customer_Contact {get; set;}
        public String? Customer_ImageUrl {get; set;}
    }
}