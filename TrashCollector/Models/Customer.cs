using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        [Display(Name = "Select One Time Pick Up Date")]
        [DataType(DataType.Date)]
        public string OneTimePickUpDate { get; set; }
        [Display(Name = "Select Suspend Start Date")]
        [DataType(DataType.Date)]
        public string SuspendPickUpStartDate { get; set; }
        [Display(Name = "Select Suspend End Date")]
        [DataType(DataType.Date)]
        public string SuspendPickUpEndDate { get; set; }
        public string PickUpDay { get; set; }
        [Display(Name = "Account Balance")]
        public double Balance { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public enum DayOfWeek { };
    }
}