using sistemaInventarioWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace sistemaInventarioWeb.Controllers
{
    public class MarcasController : Controller
    {
        private ventasdbEntities db = new ventasdbEntities();
        //GET
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Marca marca)
        {
            db.Marca.Add(marca);
            db.SaveChanges();
            return View();
        }
        public ActionResult Index()
        {
            var listaMarcas = db.Marca.ToList();
            return View(listaMarcas);
        }
        //variable int? significa que puede ser nulo 
        public ActionResult Edit(int? id)
        {
            if(id != null)
            {
                var marca = db.Marca.Find(id);
                if(marca != null)
                    return View(marca);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Marca marca)
        {
            //editamos con los datos enviados
            db.Entry(marca).State = EntityState.Modified;
            //guardo los cambios en la db
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                var marca = db.Marca.Find(id);
                if (marca != null)
                    return View(marca);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var marca = db.Marca.Find(id);
            if(marca != null)
            {
                //quitar el registro de la marca
                db.Marca.Remove(marca);
                //guardar los cambios
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}