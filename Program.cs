using Juego;
using System;
using System.Collections.Generic;

namespace Clase2
{
  class Program
    {
        static void Main(string[] args)
        {
            Arma cañon = new Arma("Cañon", 1000, 20);

            Jugador jugador1 = new Jugador("Marcelo", 38, true);

            Arma revolver = new Arma("revolver", 1000, 1);
            Arma pistola = new Arma("pistola", 1000, 1);

            List<Arma> Armas = new List<Arma>() {revolver, pistola};

            jugador1.Armas = Armas;

            jugador1.Armas.Add(cañon);
            
            // if (boton x presionado) {
              jugador1.Disparar("pistola");
            // }



            Console.WriteLine(revolver.Balas);
            
           
            // revolver.Disparar();
            // revolver.Disparar();
            // revolver.Disparar();
            // revolver.Disparar();


            // Console.WriteLine(revolver.Balas);

            // revolver.SumarBalas(150);

            // Console.WriteLine(revolver.Balas);
        }
    }
    
}
