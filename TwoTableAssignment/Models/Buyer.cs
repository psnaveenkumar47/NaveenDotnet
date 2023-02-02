using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwoTableAssignment.Models
{
    public class Buyer
    {
        [Key]
        public int BuyerId{ get; set; }
        [Required]
        public string BuyerName { get; set; }
        [ForeignKey("Books")]

        public int BookId { get; set; }


    }
}
