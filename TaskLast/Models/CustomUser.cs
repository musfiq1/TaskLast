using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLast.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(30), Required]
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<FirstTable> FirstTables { get; set; }
    }
}
