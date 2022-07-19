using Downgradedatabase.Data;
using Downgradedatabase.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Downgradedatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student1Controller : ControllerBase
    {
        private readonly Student1context _context;
        public Student1Controller(Student1context context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("ADD")]

        public async Task<IActionResult> addstudent1(Student1 s )
        {
            await _context.AddAsync(s);

            await _context.SaveChangesAsync();  

            return Ok();
        }


        [HttpGet]
        [Route("get-all")]

        public async Task<IActionResult> getstudent1()
        {
          var result=  await _context.student1.ToListAsync();

            return Ok(result);  

        }


    }
}
