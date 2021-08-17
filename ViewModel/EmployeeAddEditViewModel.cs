using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class EmployeeAddEditViewModel
    {
        public Employee Employee { get; set; }
        public List<City> Cities { get; set; }
        public List<WorkingCompany> companies { get; set; }
        public List<PayrollComp> PayrollCompany { get; set; }
        public List<EmpStatus> Status { get; set; }
        public List<EmpType> Type { get; set; }
        public List<BatchId> BatchIds { get; set; }
        public List<Department> Departments { get; set; }
        public List<HRRepresentative> HR { get; set; }
        public List<ActualRecruiter> Recruiters { get; set; }
        public List<WorkingLocation> Locations { get; set; }
        public List<AppRefData> StatusList { get; internal set; }
    }
}