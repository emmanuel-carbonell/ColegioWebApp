using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPract.Models;
using System.IO;


//Laalalalalaalla


namespace WebAppPract.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }

        public ActionResult Resultados(Estudiante estudi, HttpPostedFileBase foto)
        {
            string nombreFoto = Path.GetFileName(foto.FileName);

            string rutaFoto = Path.Combine(Server.MapPath("/Images"), nombreFoto);

            foto.SaveAs(rutaFoto);

            ViewBag.picture = nombreFoto;

          
            return View(estudi);
        }

       
        
        
        public ActionResult ProcesaFoto(string foto)
        {
            string ruta = ControllerContext.HttpContext.Server.MapPath("/Ïmages");


            return File(Path.Combine(ruta, foto) ,"image");
        }

    
    
    
    
    
    
    
    
    
    
    }







}