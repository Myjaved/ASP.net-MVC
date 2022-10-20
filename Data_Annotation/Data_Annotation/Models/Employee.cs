using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data_Annotation.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage ="ID must required")]
        public int EmployeeID  { get; set; }


        [DisplayName("NAME")]
        [Required (ErrorMessage ="Name Must required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Name should be in between 5 to 20")] //string data annotation for string length
        public string EmployeeName { get; set; }


        [DisplayName("AGE")]
        [Required (ErrorMessage ="Age Must be required")]
        [Range(20,60,ErrorMessage ="Age must be in between 20 to 60")]    //Range data annotation for numeric values
        public int? EmployeeAge { get; set; }


        [DisplayName("GENDER")]
        [Required (ErrorMessage ="Gender Must be required")]
        public string EmployeeGender { get; set; }


        [DisplayName("E-MAIL")]
        [Required (ErrorMessage ="Email must be required")]
        public string EmployeeEmail { get; set; }


        //compare data aanotation for comparing two fields
        [DisplayName("PASSWORD")]
        [Required(ErrorMessage = "Password Must be required")]
        public string EmpPassword { get; set; }

        
        [DisplayName("CONFIRM PASSWORD")]
        [Required(ErrorMessage = "ConfirmPassword Must be required")]
        [Compare("EmpPassword")]    
        public string EmpConfirmPassord { get; set; }

        
        
        [DisplayName("ORGANISATION NAME")]
        [ReadOnly(true)]
        public string EmpOrganisationName { get; set; }

         

    }
}