using System.ComponentModel.DataAnnotations;

namespace BaiTest.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string SalesOrder { get; set; }
        [Required]
        public string SalesOrderItem { get; set; }
        [Required]
        public string WorkOrder { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string OrderQuantity { get; set; }
        [Required]
        public string OrderStatus { get; set; }
        [Required]
        public DateTime Times_tamp { get; set; }
    }
}
