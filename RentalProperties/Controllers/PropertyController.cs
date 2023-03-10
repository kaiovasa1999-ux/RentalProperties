using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RentalProperties.Data;
using RentalProperties.Models.Property;

namespace RentalProperties.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHost;

        public PropertyController(ApplicationDbContext _db, IWebHostEnvironment webHost)
        {
            this._db = _db;
            this._webHost = webHost;
        }
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddNewPropertyInputModel input)
        {
            var filePath = Path.GetTempFileName();
            var files = input.Images;
            foreach (var item in files)
            {
                if (!item.FileName.EndsWith(".jpg"))
                {
                    this.ModelState.AddModelError(item.FileName, "Invalid fail extension");
                }
            }
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                foreach (var item in files)
                {
                    await item.CopyToAsync(fs);
                }
            };

            return this.RedirectToAction("ThankYou");

        }

        public IActionResult ThankYou()
        {
            return this.View();
        }

        public IActionResult Edit(AddNewPropertyInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            return this.RedirectToAction("ThankYou");
        }

        public IActionResult Image()
        {
            return this.PhysicalFile(this._webHost.WebRootPath + @"/Images",".png");
        }
    }
}
