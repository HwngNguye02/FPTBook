using System.ComponentModel.DataAnnotations;
using System;

namespace ASM1670.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        [Required]
        public int OrderQuantity { get; set; }
        public double OrderPrice { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
        public int BookId { get; set; }   //frkey
        public Book Book { get; set; }
    }
}
