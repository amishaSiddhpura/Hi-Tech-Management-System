//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectHiTech
{
    using System;
    using System.Collections.Generic;
    
    public partial class bookData
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public Nullable<int> UnitPrice { get; set; }
        public Nullable<int> YearPublished { get; set; }
        public Nullable<int> Qoh { get; set; }
        public string Category { get; set; }
        public Nullable<int> A_ID { get; set; }
        public Nullable<int> S_ID { get; set; }
    
        public virtual author author { get; set; }
    }
}
