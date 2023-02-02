using System.ComponentModel.DataAnnotations;

namespace TwoTableAssignment.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
