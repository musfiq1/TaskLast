using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLast.Models
{
    public class SecondTable
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(300), Required]

        public string Description { get; set; }
        [ForeignKey("FirstTable")]
        public int FirstTableId { get; set; }
        public FirstTable FirstTable { get; set; }
        public bool IsDone { get; set; }

    }
}
