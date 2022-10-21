using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class AppUsers
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public int Gender { get; set; }
        public string? Password { get; set; }

        // mandatory fields
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModifyBy { get; set; }
        public bool IsDel { get; set; }

    }
}
