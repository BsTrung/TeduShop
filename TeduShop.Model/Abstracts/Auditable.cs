using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstracts
{
    public abstract class Auditable:IAuditable
    {
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        public bool Status { set; get; }
        DateTime IAuditable.CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime IAuditable.UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
