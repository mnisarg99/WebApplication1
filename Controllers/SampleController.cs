using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
      
        public ActionResult Index()

        {
            var cities = new List<City>();
            cities.Add(new City { Id = 1, Name = "Jpr" });
            cities.Add(new City { Id = 2, Name = "Krl" });

            var workingcompany = new List<WorkingCompany>();
            workingcompany.Add(new WorkingCompany { Id = 1, Name = "Compunnel Inc" });
            workingcompany.Add(new WorkingCompany { Id = 2, Name = "Infopro Learning Inc" });
            workingcompany.Add(new WorkingCompany { Id = 3, Name = "Compunnel Healthcare" });
            workingcompany.Add(new WorkingCompany { Id = 4, Name = "JobleticsPro" });
            workingcompany.Add(new WorkingCompany { Id = 5, Name = "Compunnel India" });
            workingcompany.Add(new WorkingCompany { Id = 6, Name = "Compunnel Canada" });
            workingcompany.Add(new WorkingCompany { Id = 7, Name = "LMG Healthcare" });

            var Payrollcom = new List<PayrollComp>();
            Payrollcom.Add(new PayrollComp { Id = 1, Name = "Compunnel Inc" });
            Payrollcom.Add(new PayrollComp { Id = 2, Name = "Infopro Learning Inc" });
            Payrollcom.Add(new PayrollComp { Id = 3, Name = "Compunnel Healthcare" });
            Payrollcom.Add(new PayrollComp { Id = 4, Name = "JobleticsPro" });
            Payrollcom.Add(new PayrollComp { Id = 5, Name = "Compunnel India" });
            Payrollcom.Add(new PayrollComp { Id = 6, Name = "Compunnel Canada" });
            Payrollcom.Add(new PayrollComp { Id = 7, Name = "LMG Healthcare" });

            var status = new List<EmpStatus>();
            status.Add(new EmpStatus { Id = 1, Name = "Active" });
            status.Add(new EmpStatus { Id = 2, Name = "Inactive" });

            var type = new List<EmpType>();
            type.Add(new EmpType { Id = 1, Name = "Counsultant" });
            type.Add(new EmpType { Id = 2, Name = "Customer Contact" });
            type.Add(new EmpType { Id = 3, Name = "In-House Employee" });
            type.Add(new EmpType { Id = 4, Name = "Job Seeker" });
            type.Add(new EmpType { Id = 5, Name = "Sub-Contractor" });

            var batchids = new List<BatchId>();
            batchids.Add(new BatchId { Id = 1, Name = "0" });
            batchids.Add(new BatchId { Id = 2, Name = "100" });
            batchids.Add(new BatchId { Id = 3, Name = "200" });
            batchids.Add(new BatchId { Id = 4, Name = "Referral Emp" });
            batchids.Add(new BatchId { Id = 5, Name = "300" });

            var departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Sales" });
            departments.Add(new Department { Id = 2, Name = "Recruitment" });
            departments.Add(new Department { Id = 3, Name = "Legal" });
            departments.Add(new Department { Id = 4, Name = "HR" });
            departments.Add(new Department { Id = 5, Name = "Accountinvg" });
            departments.Add(new Department { Id = 6, Name = "Custom Projects" });

            var hr = new List<HRRepresentative>();
            hr.Add(new HRRepresentative { Id = 1, Name = "Ajay Singh" });
            hr.Add(new HRRepresentative { Id = 2, Name = "Akshay Kumar" });
            hr.Add(new HRRepresentative { Id = 3, Name = "Alok Mishra" });
            hr.Add(new HRRepresentative { Id = 4, Name = "Aman Srivastava" });
            hr.Add(new HRRepresentative { Id = 5, Name = "Amit Gaur" });

            var recruiters = new List<ActualRecruiter>();
            recruiters.Add(new ActualRecruiter { Id = 1, Name = "Ajay Singh" });
            recruiters.Add(new ActualRecruiter { Id = 2, Name = "Akshay Kumar" });
            recruiters.Add(new ActualRecruiter { Id = 3, Name = "Alok Mishra" });
            recruiters.Add(new ActualRecruiter { Id = 4, Name = "Aman Srivastava" });
            recruiters.Add(new ActualRecruiter { Id = 5, Name = "Amit Gaur" });

            var locations = new List<WorkingLocation>();
            locations.Add(new WorkingLocation { Id = 1, Name = "Noida" });
            locations.Add(new WorkingLocation { Id = 2, Name = "Goa" });
            locations.Add(new WorkingLocation { Id = 3, Name = "Jaipur" });
            locations.Add(new WorkingLocation { Id = 4, Name = "Pune" });
            locations.Add(new WorkingLocation { Id = 5, Name = "California" });

            var emp = new EmployeeAddEditViewModel
            { 
                        Cities = cities,
                        companies = workingcompany,
                        PayrollCompany = Payrollcom,
                        Status = status,
                        Type = type,
                        BatchIds = batchids,
                        Departments = departments,
                        HR = hr,
                        Recruiters = recruiters,
                        Locations = locations

            };

            return View(emp);
        }

        public ActionResult Create(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                var cities = new List<City>();
                cities.Add(new City { Id = 1, Name = "Jpr" });
                cities.Add(new City { Id = 2, Name = "Krl" });

                var workingcompany = new List<WorkingCompany>();
                workingcompany.Add(new WorkingCompany { Id = 1, Name = "Compunnel Inc" });
                workingcompany.Add(new WorkingCompany { Id = 2, Name = "Infopro Learning Inc" });
                workingcompany.Add(new WorkingCompany { Id = 3, Name = "Compunnel Healthcare" });
                workingcompany.Add(new WorkingCompany { Id = 4, Name = "JobleticsPro" });
                workingcompany.Add(new WorkingCompany { Id = 5, Name = "Compunnel India" });
                workingcompany.Add(new WorkingCompany { Id = 6, Name = "Compunnel Canada" });
                workingcompany.Add(new WorkingCompany { Id = 7, Name = "LMG Healthcare" });

                var Payrollcom = new List<PayrollComp>();
                Payrollcom.Add(new PayrollComp { Id = 1, Name = "Compunnel Inc" });
                Payrollcom.Add(new PayrollComp { Id = 2, Name = "Infopro Learning Inc" });
                Payrollcom.Add(new PayrollComp { Id = 3, Name = "Compunnel Healthcare" });
                Payrollcom.Add(new PayrollComp { Id = 4, Name = "JobleticsPro" });
                Payrollcom.Add(new PayrollComp { Id = 5, Name = "Compunnel India" });
                Payrollcom.Add(new PayrollComp { Id = 6, Name = "Compunnel Canada" });
                Payrollcom.Add(new PayrollComp { Id = 7, Name = "LMG Healthcare" });

                var status = new List<EmpStatus>();
                status.Add(new EmpStatus { Id = 1, Name = "Active" });
                status.Add(new EmpStatus { Id = 2, Name = "Inactive" });

                var type = new List<EmpType>();
                type.Add(new EmpType { Id = 1, Name = "Counsultant" });
                type.Add(new EmpType { Id = 2, Name = "Customer Contact" });
                type.Add(new EmpType { Id = 3, Name = "In-House Employee" });
                type.Add(new EmpType { Id = 4, Name = "Job Seeker" });
                type.Add(new EmpType { Id = 5, Name = "Sub-Contractor" });

                var batchids = new List<BatchId>();
                batchids.Add(new BatchId { Id = 1, Name = "0" });
                batchids.Add(new BatchId { Id = 2, Name = "100" });
                batchids.Add(new BatchId { Id = 3, Name = "200" });
                batchids.Add(new BatchId { Id = 4, Name = "Referral Emp" });
                batchids.Add(new BatchId { Id = 5, Name = "300" });

                var departments = new List<Department>();
                departments.Add(new Department { Id = 1, Name = "Sales" });
                departments.Add(new Department { Id = 2, Name = "Recruitment" });
                departments.Add(new Department { Id = 3, Name = "Legal" });
                departments.Add(new Department { Id = 4, Name = "HR" });
                departments.Add(new Department { Id = 5, Name = "Accountinvg" });
                departments.Add(new Department { Id = 6, Name = "Custom Projects" });

                var hr = new List<HRRepresentative>();
                hr.Add(new HRRepresentative { Id = 1, Name = "Ajay Singh" });
                hr.Add(new HRRepresentative { Id = 2, Name = "Akshay Kumar" });
                hr.Add(new HRRepresentative { Id = 3, Name = "Alok Mishra" });
                hr.Add(new HRRepresentative { Id = 4, Name = "Aman Srivastava" });
                hr.Add(new HRRepresentative { Id = 5, Name = "Amit Gaur" });

                var recruiters = new List<ActualRecruiter>();
                recruiters.Add(new ActualRecruiter { Id = 1, Name = "Ajay Singh" });
                recruiters.Add(new ActualRecruiter { Id = 2, Name = "Akshay Kumar" });
                recruiters.Add(new ActualRecruiter { Id = 3, Name = "Alok Mishra" });
                recruiters.Add(new ActualRecruiter { Id = 4, Name = "Aman Srivastava" });
                recruiters.Add(new ActualRecruiter { Id = 5, Name = "Amit Gaur" });

                var locations = new List<WorkingLocation>();
                locations.Add(new WorkingLocation { Id = 1, Name = "Noida" });
                locations.Add(new WorkingLocation { Id = 2, Name = "Goa" });
                locations.Add(new WorkingLocation { Id = 3, Name = "Jaipur" });
                locations.Add(new WorkingLocation { Id = 4, Name = "Pune" });
                locations.Add(new WorkingLocation { Id = 5, Name = "California" });

                var empVM = new EmployeeAddEditViewModel
                {
                    Cities = cities,
                    companies = workingcompany,
                    PayrollCompany = Payrollcom,
                    Status = status,
                    Type = type,
                    BatchIds = batchids,
                    Departments = departments,
                    HR = hr,
                    Recruiters = recruiters,
                    Locations = locations
                };

                return View("Index", empVM);

            }

            return Content("Ok");
        }
    }
}

        
        
    
