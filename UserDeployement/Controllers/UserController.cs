using CsvHelper.Configuration;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserDeployement.DataDb;
using UserDeployement.Entities;

namespace UserDeployement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _uctx;

            public UserController(UserDbContext uctx)
            {
            _uctx = uctx;   
            }

        [HttpPost]
        [Route("upload")]
        public  IActionResult Upload(IFormFile file)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> ImportFromExcel(IFormFile formFile)
        {
            var data = new MemoryStream();
            await formFile.CopyToAsync(data);

            data.Position = 0;
            TextReader reader = new StreamReader(data);

            var csvReader = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null
            });

            var Name = csvReader.GetField(0).ToString();
            var dep = "cccccccccc";
            var pos = "bbbbbbbbbbb";

            await _uctx.Users.AddAsync(new User
            {
            });
            _uctx.SaveChanges();

            return Ok(Name);
        }
    }
}
