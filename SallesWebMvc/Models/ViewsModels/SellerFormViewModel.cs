using System;
using System.Collections.Generic;

namespace SallesWebMvc.Models.ViewsModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
