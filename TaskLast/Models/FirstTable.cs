using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLast.Models
{
    public class FirstTable
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(300), Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        [ForeignKey("CustomUser")]
        public string CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
        public bool IsDone { get; set; }
    }
}
