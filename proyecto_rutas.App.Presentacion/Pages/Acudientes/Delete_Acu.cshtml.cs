using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using proyecto_rutas.App.Dominio;
using proyecto_rutas.App.Persistencia.AppRepositorios;
using proyecto_rutas.App.Dominio.Entidades;

namespace proyecto_rutas.App.Presentacion.Pages
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioAcudiente _appContext;

        [BindProperty]
        public Acudiente acudiente  { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new RepositorioAcudiente(new proyecto_rutas.App.Persistencia.AppRepositorios.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int acudienteId)
        {
            acudiente = _appContext.GetAcudiente(acudienteId);
            if(acudiente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
        
        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(acudiente.id > 0)
            {
               _appContext.DeleteAcudiente(acudiente.id);
            }
            return Page();
        }
    }
}

