using Microsoft.AspNetCore.Mvc;
using StudentManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudents()
        {
            return Ok(studentRepository.GetStudents());
        }
    }
}
