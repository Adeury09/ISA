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
    
    public partial class Routes_Delivery
    {
        public int routeID { get; set; }
        public int deliveryID { get; set; }
        public string descriptionRD { get; set; }
    
        public virtual Delivery Delivery { get; set; }
        public virtual Route Route { get; set; }
    }
}
