//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsStore.Domain.EF_Practice.ManTmanWithPayload
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int Count { get; set; }
        public int OrderOrderId { get; set; }
        public int ItemSKU { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Item Item { get; set; }
    }
}
