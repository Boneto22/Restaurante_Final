using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Restaurante.Dominio;
using Restaurante.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace Restaurante.App.WebApp
{
    public class CreateModel : PageModel
    {

        private IPersona_Repository _personaRepository = new Persona_Repository( new Restaurante.Persistencia.AppContext());       public void OnGet()
        {
        }
        // Donde se lee lo que envía del FRONT END
        public void OnPost(){ 

            var Documento = Request.Form["Documento"];
            var Nombre = Request.Form["Nombre"];
            var Apellidos = Request.Form["Apellidos"];
            var Email = Request.Form["Email"];
            var Telefono = Request.Form["Telefono"];
            var Estados = Request.Form["Estados"];
            var Tipopersona = Request.Form["Tipopersona"];

            // Validación de datos
            var persona = new Persona{
                documento = Documento,
                nombre = Nombre,
                apellido = Apellidos,
                email = Email,
                telefono = Telefono,
               // Estado = (Estados == 0? Estados.Activo : Estados.Inactivo),
                //tipopersona = TipoPersona
            };
            var result = _personaRepository.AdicionaPersona(persona);
            if ( result > 0){
                Console.WriteLine("Se registra la persona con éxito");
            }else {
               Console.WriteLine(" No se pudo registrar"); 
            }
        }
    }
}

