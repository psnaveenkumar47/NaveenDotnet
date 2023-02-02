using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwoTableAssignment.ViewModel
{
    public class BuyerViewModel
    {
       
        public int BuyerId{ get; set; }
     
        public string BuyerName { get; set; }
        

        public int BookId { get; set; }


    }
}
