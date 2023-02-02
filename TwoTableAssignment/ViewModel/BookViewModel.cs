using System.ComponentModel.DataAnnotations;

namespace TwoTableAssignment.ViewModel
{
    public class BookViewModel
    {
        
        public int BookId { get; set; }
        
        public string BookName { get; set; }
        
        public string AuthorName { get; set; }
    }
}
