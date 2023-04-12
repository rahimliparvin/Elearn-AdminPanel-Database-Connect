using ELEARN.Data;
using ELEARN.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELEARN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> courses = await _context.Courses.Where(m=>!m.SoftDelete).Include(m=>m.Author).Include(m=>m.CourseImages).ToListAsync();

            return View(courses);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Course course = await _context.Courses.Where(m => m.Id == id).Include(m => m.Author).Include(m => m.CourseImages).FirstOrDefaultAsync();

            if (course == null) return NotFound();

            return View(course);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
