using System.Collections.Generic;

namespace Juego
{
  public class Jugador {
    public string Name { get; set; }
    public int Edad { get; set; }
    public bool Activo { get; set; }

    public List<Arma> Armas { get; set; }

    public Jugador(string name, int edad, bool activo) {
      Name = name;
      Edad = edad;
      Activo = activo;
    }

    public void Disparar(string armaName) {
      Armas.Find(arma => arma.Name == armaName).Disparar();
    }
    public string getDatos() {
      return "nombre jugador: " + Name + " edad: " + Edad + " activo: " + Activo;
    }
  }

  public class Arma {
    public string Name { get; set; }
    public int Balas { get; set; }

    private int Cant { get; set; }

    public Arma(string name, int balas, int cant) {
      Name = name;
      Balas = balas;
      Cant = cant;
    }
    public void Disparar() {
      Balas = Balas - Cant;
      if (Balas <= 10) {
        // TODO: 
        // avisar al user;
        // ofrecer comprar balas
      }
    }
    public void SumarBalas(int cantidadBalas) {
      Balas += cantidadBalas;
    }
  }
}