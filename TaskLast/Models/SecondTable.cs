using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLast.Models
{
    public class SecondTable
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(30), Required]

        public string Description { get; set; }
        public bool IsDone { get; set; }

    }
}
