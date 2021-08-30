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

        [HttpPost]
        public IActionResult Create(VideoGame objVideoGame){
            
            _context.Add(objVideoGame);
            _context.SaveChanges();
            ViewData["Message"] = "¡¡¡El videojuego se registró exitosamente!!!";
            return View();
            
        }

        public IActionResult Update(int id){
            VideoGame objVideoGame = _context.DataVideoGame.Find(id);
            if(objVideoGame == null){
                return NotFound();
            }
            return View(objVideoGame);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("id,nombre,categoria,precio,descuento")] VideoGame objVideoGame){
            
            _context.Update(objVideoGame);
            _context.SaveChanges();
            ViewData["Message"] = "¡¡¡El videojuego se editó exitosamente!!!";
            return View();
            
        }

    }
}