using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MovieRental1.Models
{
    public class CatClass
    {
        [DisplayName("Movie Name")]
        public Movy newMovie { get; set;}

        [DisplayName("Customer")]
        public CustomerInfo newCustomer { get; set;}

        [DisplayName("Return Date")]
        public RentalRecord newRecord { get; set;}
    }
   
}