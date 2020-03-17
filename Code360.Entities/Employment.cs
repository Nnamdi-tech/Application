using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code360.Entities
{
    public class Employment
    {
        [Key]
        public int Guid { get; set; }
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display (Name = "Date of Employment")]
        public DateTime StartDate { get; set; }        
        [Required]
        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }
        [Required]
        public  Double Salary { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        [Display(Name = "Contact Person")]
        public String ContactPerson { get; set; }

    }

    
}
