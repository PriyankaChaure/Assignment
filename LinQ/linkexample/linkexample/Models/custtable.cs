//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace linkexample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class custtable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public custtable()
        {
            this.bills = new HashSet<bill>();
        }
    
        public long custid { get; set; }
        public string custname { get; set; }
        public string address { get; set; }
        public string emailid { get; set; }
        public string mobileno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bill> bills { get; set; }
    }
}
