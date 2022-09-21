using System;

namespace Restaurante.Dominio { 
    
    public class Detal_Asignacion { 
      public  int id {get; set;}    
      public Asignacion asignacion {get; set;}
      public Mesa mesa {get; set;}
    }
}