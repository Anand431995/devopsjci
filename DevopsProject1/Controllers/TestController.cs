using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevopsProject1.Data;
using DevopsProject1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevopsProject1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public Student EmployeeDetails()
        {
            DataContext db = new DataContext();
            return (from n in db.Student where n.Id == 2 select n).FirstOrDefault();
        }
    }
}