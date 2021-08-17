using System.Web.Mvc;
using WebApplication1.Repository;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Common objRepo = new Common();

            var appRefStatus = objRepo.GetAppRefData(1800);

            var empVM = new EmployeeAddEditViewModel
            {
                StatusList = appRefStatus
            };
            
            return View(empVM);
        }
    }
}