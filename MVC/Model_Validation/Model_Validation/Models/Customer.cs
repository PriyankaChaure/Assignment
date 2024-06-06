using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model_Validation.Models
{
    public class Customer
    {
        [evencreditlimit1(ErrorMessage ="credit should be even")]
        [Required(ErrorMessage ="enter customer id!!!")]
        public Int64 customerid { get; set; }
        [Required(ErrorMessage = "enter customer full name!!!")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="name shpould be in the range of 5-20")]
        [Display(Name="customer full name")]
        public string customername { get; set; }
        [Required(ErrorMessage = "enter customer address!!!")]
        public string address { get; set; }
        [Required(ErrorMessage = "enter customer email-id!!!")]
        [EmailAddress(ErrorMessage ="invalid email id")]
        public string emailid { get; set; }
        [Required(ErrorMessage = "enter customer mobile no!!!")]
        [RegularExpression(@"^\d{10}$",ErrorMessage ="10 digits required")]
        public string mobileno { get; set; }
        [Required(ErrorMessage = "enter customer credit limit!!!")]
        [Range(1000,10000,ErrorMessage ="credit limit should be in the range of[1000-10000]")]
        public decimal creditlimit { get; set; }
        [Required(ErrorMessage = "enter password!!!")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "enter confirm password!!!")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }

    }
}