using System;

namespace Restaurante.Dominio {

    public class Detal_comanda { 
      public  int id {get; set;}
      public  int cant {get; set;}
      public  Menu menu {get; set;} 
      public Comanda comanda {get; set;} 
    }   
       

}