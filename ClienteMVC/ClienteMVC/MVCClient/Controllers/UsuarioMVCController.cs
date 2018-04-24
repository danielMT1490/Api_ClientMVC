using ClienteMVC.ApiService;
using MVCClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClient.Controllers
{
    public class UsuarioMVCController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioMVCController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }
        // GET: UsuarioMVC
        public ActionResult Index()
        {
            return View();
        }

        // GET: UsuarioMVC/Details/5
        public ActionResult Details()
        {
            var model = this._usuarioService.GetAsync();
            return View(model.Result);
        }

        // GET: UsuarioMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioMVC/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var usuario = new UsuarioServiceModel(collection["Id"],collection["Nombre"],collection["Apellido"]);
                this._usuarioService.SetAsync(usuario);
                return RedirectToAction("Detail");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
