using System;

namespace Restaurante.Dominio { 
   
    public class Factura { 
      public int id {get; set;}
      public Decimal precio {get; set;}
      public Comanda idcomanda {get; set;}
      public Persona persona {get; set;}
      public Mesa mesa {get; set;} 

    }
}