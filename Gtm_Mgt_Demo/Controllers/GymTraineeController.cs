using Gtm_Mgt_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [HttpGet]
        public IActionResult SaveTraineeInfo(int Id)
        {
            #region Blood Group
            GymTrainee gymTrainee = new GymTrainee();
            List<SelectListItem> OJList = new List<SelectListItem>();

            var BGL = dbcontext.BloodGroups.ToList();
            foreach (var item in BGL)
            {
                OJList.Add(new SelectListItem() { Text = item.BloodGroupName, Value = item.BloodGroupID.ToString() });
            }
            //view bag
            ViewBag.BGL = OJList;
            #endregion

            #region Training Level
            TrainingLevel trainingLevel = new TrainingLevel();
            List<SelectListItem> OJTList = new List<SelectListItem>();

            var TLL = dbcontext.TrainingLevels.ToList();
            foreach (var item in TLL)
            {
                OJTList.Add(new SelectListItem() { Text = item.TrainingLevelName, Value = item.TrainingLevelID.ToString() });
            }
            //view bag
            ViewBag.TLL = OJTList;
            #endregion

            #region Height Input
            List<SelectListItem>HeightList = new List<SelectListItem>();
            HeightList.Add(new SelectListItem() { Text = "4' ", Value = "4' " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' ", Value = "4' " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 1''  ", Value = "4' 1''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 2''  ", Value = "4' 2''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 3''  ", Value = "4' 3''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 4''  ", Value = "4' 4''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 5''  ", Value = "4' 5''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 6''  ", Value = "4' 6''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 7''  ", Value = "4' 7''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 8''  ", Value = "4' 8''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 9''  ", Value = "4' 9''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 10'' ", Value = "4' 10'' " });
            HeightList.Add(new SelectListItem() { Text = "---> 4' 11'' ", Value = "4' 11'' " });

            HeightList.Add(new SelectListItem() { Text = "5' ", Value = "5' " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' ", Value = "5' " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 1''  ", Value = "5' 1''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 2''  ", Value = "5' 2''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 3''  ", Value = "5' 3''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 4''  ", Value = "5' 4''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 5''  ", Value = "5' 5''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 6''  ", Value = "5' 6''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 7''  ", Value = "5' 7''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 8''  ", Value = "5' 8''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 9''  ", Value = "5' 9''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 10'' ", Value = "5' 10'' " });
            HeightList.Add(new SelectListItem() { Text = "---> 5' 11'' ", Value = "5' 11'' " });

            HeightList.Add(new SelectListItem() { Text = "6' ", Value = "6' " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' ", Value = "6' " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 1''  ", Value = "6' 1''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 2''  ", Value = "6' 2''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 3''  ", Value = "6' 3''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 4''  ", Value = "6' 4''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 5''  ", Value = "6' 5''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 6''  ", Value = "6' 6''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 7''  ", Value = "6' 7''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 8''  ", Value = "6' 8''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 9''  ", Value = "6' 9''  " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 10'' ", Value = "6' 10'' " });
            HeightList.Add(new SelectListItem() { Text = "---> 6' 11'' ", Value = "6' 11'' " });

            ViewBag.Height_TL = HeightList;
            #endregion
            return View();
        }
        
        [HttpPost]
        public async Task <IActionResult> SaveTraineeInfo([Bind("TraineeId,FirstName,LastName,Age,Height,Weight,Gender,Address,BloodGroupID,TrainingLevelID,MonthlyFee,ImageFile")] GymTrainee gymTrainee)
        {
            if (ModelState.IsValid)
            {
                //modelState valid nam records will be saved to database
                //code is related to the image
                //මොන මගුලක්ද මේ🤮
                //වැඩ කරන් නති උනාම දෙන්න හිතෙනවා😒
                //කාපන් මාව

                string wwwRootPath = webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(gymTrainee.ImageFile.FileName);
                string extension = Path.GetExtension(gymTrainee.ImageFile.FileName);
                gymTrainee.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                using(var fileStream = new FileStream(path,FileMode.Create))
                {
                    await gymTrainee.ImageFile.CopyToAsync(fileStream);
                }
                //this code is related to image end

                gymTrainee.CreationDate = System.DateTime.Now;
                dbcontext.Add(gymTrainee);
                await dbcontext.SaveChangesAsync();
                RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
