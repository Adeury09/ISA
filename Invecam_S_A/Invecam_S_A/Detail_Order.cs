//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invecam_S_A
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail_Order
    {
        public int orderID { get; set; }
        public int productID { get; set; }
        public Nullable<int> quantityPOrder { get; set; }
        public string descriptionDO { get; set; }
        public Nullable<int> discount { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
