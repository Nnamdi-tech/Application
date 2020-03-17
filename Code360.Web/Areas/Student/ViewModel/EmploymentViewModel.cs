using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360.Web.Areas.Student.ViewModel
{
    public class EmploymentViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Date of Employment")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }
        [Required]
        public Double Salary { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        [Display(Name = "Contact Person")]
        public String ContactPerson { get; set; }
    }
}
