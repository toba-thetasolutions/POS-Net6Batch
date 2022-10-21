using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public string? ItemCode { get; set; }
        public decimal Price { get; set; }
        public decimal Qunatity { get; set; }
        public int Serial { get; set; }
        // mandatory fields
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifyBy { get; set; }
        public bool IsDel { get; set; }

    }
}
