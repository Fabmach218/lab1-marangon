using Microsoft.AspNetCore.Mvc;
using lab1_marangon.Models;
using lab1_marangon.Data;
using System.Linq;


namespace lab1_marangon.Controllers
{
    public class VideoGameController:Controller
    {
        private readonly ApplicationDbContext _context;

        public VideoGameController(ApplicationDbContext context){
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.DataVideoGame.ToList());
        }

        public IActionResult Create(){
            return View();
        }
    }
}