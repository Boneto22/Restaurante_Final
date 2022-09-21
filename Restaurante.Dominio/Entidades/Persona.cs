using System;
using Restaurante.Dominio;
namespace Restaurante.Dominio{

    public class Persona{ 
      public  int id {get; set;}
      public  string documento {get; set;}
      public  string nombre {get; set;}
      public  string apellido {get; set;}
      public  string email {get; set;}
      public  string telefono {get; set;}
      TipoPersona tipopersona {get; set;}
      Estado Estado {get; set;}
      Tipos Tipo {get; set;}
    }
}