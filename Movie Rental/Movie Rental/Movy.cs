//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movie_Rental
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        public Movy()
        {
            this.RentalRecords = new HashSet<RentalRecord>();
        }
    
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public int MovieGenre { get; set; }
    
        public virtual Genre Genre { get; set; }
        public virtual ICollection<RentalRecord> RentalRecords { get; set; }
    }
}
