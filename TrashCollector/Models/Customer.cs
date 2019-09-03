using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public string oneTimePickUpDate { get; set; }
        public bool suspendPickUpStartToEnd { get; set; }
        public string selectOrChangePickUpDate { get; set; }

    }
}