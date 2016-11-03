using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental1
{
    [MetadataType(typeof(CustomerInfoMetaData))]
    public partial class CustomerInfo
    {

    }
    public partial class CustomerInfoMetaData
    {
        [DisplayName("Customer Phone Number")]
        [Required(ErrorMessage = "Enter A Valid Movie Name")]
        [MaxLength(50, ErrorMessage = "Movie Name has to be 50 letters or less")]
        public string CustomerPhoneNumber { get; set; }
    }

    [MetadataType(typeof(GenreMetaData))]
    public partial class Genre
    {

    }
    public partial class GenreMetaData
    {
        [DisplayName("Genre ID")]
        public int GenreId { get; set; }

        [DisplayName("Genre Name")]
        [Required(ErrorMessage="You must enter a valid genre name")]
        [MaxLength(50,ErrorMessage ="Genre name must be 50 letters or less")]
        public string GenreName { get; set; }
    }
    [MetadataType(typeof(MovyMetaData))]
    public partial class Movy
    {
      
    }
    public partial class MovyMetaData
    {
        [DisplayName("Movie ID")]
        public int MovieID { get; set; }
        [DisplayName("Movie Name")]
        [Required(ErrorMessage = "You must enter a movie name!")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 letters or less")]
        public string MovieName { get; set; }
        [DisplayName("Movie Description")]
        [Required(ErrorMessage ="A description is required")]
        public string MovieDescription { get; set; }
        [DisplayName("Movie Genre")]
        [Required(ErrorMessage ="You must enter a genre name")]
        public Nullable<int> MovieGenre { get; set; }
    }
    [MetadataType(typeof(RentalRecordMetaData))]
    public partial class RentalRecord
    {

    }
    public partial class RentalRecordMetaData
    {
        [DisplayName("Rental Id")]
        public int RentalId { get; set; }
        [DisplayName("Movie Id")]
        public int MovieId { get; set; }
        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "You must enter a customer name")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 letter or less")]
        public int CustomerId { get; set; }
        [DisplayName("Rental Date")]
        [Required(ErrorMessage = "You must enter a rental date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime RentalDate { get; set; }
        [Required(ErrorMessage = "You must enter a due date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Due Date")]
        public System.DateTime DueDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Return Date")]
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}