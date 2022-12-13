using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samPharma.Models
{
    public class User
    {
        [Key]
        public long Id {get; set;}
        public String? UserName {get; set;}
        public String? Email {get; set;}
        public String? Password {get; set;}
        public String? Role {get; set;}
        public String? StaffId {get; set;}

    }
}