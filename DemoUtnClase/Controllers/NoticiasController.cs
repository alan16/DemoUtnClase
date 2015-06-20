using DemoUtnClase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoUtnClase.Controllers
{
    public class NoticiasController : Controller
    {
        //
        // GET: /Noticias/
        private NoticiasContex dbNoticias = new NoticiasContex();

        public ActionResult Index()
        {
            var noticias = dbNoticias.noticias.ToList();
            return View(noticias);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NoticiasViewmodel noticia) 
        {
            if (ModelState.IsValid) {
                                
                Noticias not = GetNoticia(noticia);
                dbNoticias.noticias.Add(not);
                dbNoticias.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View("Index", "Home");
            }           
            
        }

        private Models.Noticias GetNoticia(Models.NoticiasViewmodel noticia)
        {
            Noticias not = new Noticias();
            not.Id = noticia.Id;
            not.Titulo = noticia.Titulo;
            not.Subtitulo = noticia.Subtitulo;
            return not;
        }

        //GET /Noticia/Edit/5
        [HttpGet]
        public ActionResult Edit(int id) {

            //var noticia = dbNoticias.noticias.Find(id);
            Noticias noticia2 = (from n in dbNoticias.noticias select n).Where(s => s.Id == id).FirstOrDefault();            
            return View(noticia2);
        }

        [HttpPost]
        public ActionResult Edit(Noticias noticia) 
        {
            if (ModelState.IsValid)
            {
                dbNoticias.Entry(noticia).State = EntityState.Modified;
                dbNoticias.SaveChanges();
                return RedirectToAction("Index");
                
            }

            return View(noticia);
        }

	}
}