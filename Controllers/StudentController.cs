using CollegeApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return CollegeRepository.Students;
        }
        [HttpGet("{id}")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
        }
        public Student GetStudentByName(string name) 
        {
           return CollegeRepository.Students.Where(n => n.Name == name).FirstOrDefault();
        }
        public bool DeleteStudentById(int id) 
        {
          var student = CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.Students.Remove(student);
            return true;
        }
    }
}
