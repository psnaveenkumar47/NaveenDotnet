using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.ViewModels
{
    public class AnotherEmployeeListViewModel
    {
        public List<AnotherEmployeeViewModel> MyEmployees { get; set; } 
        public string UserName { get; set; }    
    }
}