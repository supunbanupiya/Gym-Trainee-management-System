using Gtm_Mgt_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gtm_Mgt_Demo.Controllers
{
    public class GymTraineeController : Controller
    {
        private readonly GymDbContext dbcontext;
        private readonly IWebHostEnvironment webHostEnvironment;

        public GymTraineeController(GymDbContext dbcontext,IWebHostEnvironment webHostEnvironment)
        {
            this.dbcontext = dbcontext;
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult SaveTraineeInfo(int Id)
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
