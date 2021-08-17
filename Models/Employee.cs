using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name Should be min 3 and max 20 length")]

        public string Name { get; set; }
        public string City { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Working Company")]
        [Display(Name = "Working Company")]
        public string WorkingCompany { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Payroll Company")]
        [Display(Name = "Payroll Company")]
        public string PayrollComp { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Employee Status")]
        [Display(Name = "Employee Status")]
        public string EmpStatus { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Employee Type")]
        [Display(Name = "Employee Type")]
        public string EmpType { get; set; }
        [Required]
        public int? SSN { get; set; }

        [DataType(DataType.Date)]
        public DataType Date_of_Birth { get; set; }
        [Required]
        public string BatchId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Department")]
        [Display(Name = "Department")]
        public int? Department { get; set; }
        [Required]
        public string PersonalEmailId { get; set; }
        [Required]
        public string OfficialEmailId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DataType Date_of_Hire { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select HR Representative")]
        [Display(Name = "HR Representative")]
        public string HRRepresentative { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Actual Recruiter")]
        [Display(Name = "Actual Recruiter")]
        public string ActualRecruiter { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Select Working Location")]
        [Display(Name = "Working Location")]
        public string WorkingLocation { get; set; }



    }
}