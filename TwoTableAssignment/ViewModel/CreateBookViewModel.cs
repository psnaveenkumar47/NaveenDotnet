using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoTableAssignment.ViewModel
{
    public class CreateBookViewModel
    {
        public int BookId { get; set; }
        
        public string BookName { get; set; }
        
        public string AuthorName { get; set; }
    }
}