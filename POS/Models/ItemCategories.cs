using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class ItemCategories
    {
        [Key]
        public int Id { get; set; }
        public string? CatName { get; set; }
        public string? CatCode { get; set; }
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
