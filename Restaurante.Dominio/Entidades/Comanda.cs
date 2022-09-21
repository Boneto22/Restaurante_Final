using System;

namespace Restaurante.Dominio {
   
    public class Comanda{
      public int id {get; set;}       
      public Mesa mesa {get; set;}
      public Persona persona {get; set;}
    }   
}