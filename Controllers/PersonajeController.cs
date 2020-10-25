using Microsoft.AspNetCore.Mvc;
using VisitorPatron.Models.DataBase;
using VisitorPatron.Models.Clases;
using VisitorPatron.Models;
using System.Linq;

namespace VisitorPatron.Controllers
{
    public class PersonajeController : Controller
    {

        public PersonajeContext cnx;
        public PersonajeController(PersonajeContext cnx)
        {
            this.cnx = cnx;
        }

        public ActionResult Index(){
            return View(cnx.Personajes.ToList());
        }



        [HttpGet]
        public ActionResult Create(){
            return View();
        }

        [HttpPost]
        public ActionResult Create(string tipo){
            
            switch(tipo){
                case "1":
                    Guerrero g = new Guerrero();
                    Personaje p = new Personaje();

                    p.Arma = g.Arma;
                    
                    cnx.Personajes.Add(p);

                    TempData["Success"] = "Guerrero creado...";
                    break;
                case "2":
                    Mago m = new Mago();
                    Personaje p1 = new Personaje();

                    p1.Arma = m.Arma;
                    
                    cnx.Personajes.Add(p1);

                    TempData["Success"] = "Mago creado...";
                    break;
                
                 
                default:

                    TempData["Error"] = "Ha ocurrido un error...";
                    break;
            }

            cnx.SaveChanges();
            return RedirectToAction("Index","Personaje");
        }
    }
}