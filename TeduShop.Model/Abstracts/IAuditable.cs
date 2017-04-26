using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstracts
{
    public interface IAuditable
    {
         string MetaKeyword { set; get; }
         string MetaDescription { set; get; }
         DateTime CreatedDate { set; get; }
         string CreatedBy { set; get; }
         DateTime UpdatedDate { set; get; }
         string UpdateBy { set; get; }
         bool Status { set; get; }
    }
}
