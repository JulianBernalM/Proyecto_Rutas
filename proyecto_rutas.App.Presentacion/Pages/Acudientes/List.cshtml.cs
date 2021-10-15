using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using proyecto_rutas.App.Dominio;
using proyecto_rutas.App.Persistencia.AppRepositorios;


namespace proyecto_rutas.App.Presentacion.Pages
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorioAcudiente _appContext;
        public IEnumerable<Acudiente> acudientes {get; set;}   
        public string searchString;

        public ListModel()
        {
            this._appContext = new RepositorioAcudiente(new proyecto_rutas.App.Persistencia.AppRepositorios.AppContext());
        }
       
        public void OnGet(string filtroBusqueda)
        {
            acudientes = _appContext.GetAllAcudientes(searchString);          
        }
        public IActionResult OnPost (string? searchString)
        {
            if (!ModelState.IsValid)
            {
                return Page ();
            }
            acudientes = _appContext.GetAllAcudientes (searchString);
            return Page ();
        }
    }
}

