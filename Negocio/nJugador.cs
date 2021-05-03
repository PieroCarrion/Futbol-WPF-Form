using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio {
    public class nJugador {
        private dJugador jugador = new dJugador();
        public string registrarJugador(string nombre, string dni, int partidosJugados, int trofeosObtenidos, decimal talla, decimal peso, int edad, string posicionJuego) {
            eJugador aux = new eJugador {
                NombreCompleto = nombre,
                DNI = dni,
                partidosJugados = partidosJugados,
                trofeosObtenidos = trofeosObtenidos,
                talla = talla,
                peso = peso,
                edad = edad,
                posicionDeJuego = posicionJuego
            };
            if (jugador.buscarJugador(dni) == null) {
                return jugador.insertarJugador(aux);
            } else {
                return "El jugador ya existe";
            }
        }
        public string modificarJugador(string nombre, string dni, int partidosJugados, int trofeosObtenidos, decimal talla, decimal peso, int edad, string posicionJuego, string idAModificar) {
            eJugador aux = new eJugador {
                NombreCompleto = nombre,
                DNI = dni,
                partidosJugados = partidosJugados,
                trofeosObtenidos = trofeosObtenidos,
                talla = talla,
                peso = peso,
                edad = edad,
                posicionDeJuego = posicionJuego
            };
            return jugador.modificarJugador(aux,idAModificar);
        }
        public string eliminarJugador(string idJugador) {
            if (jugador.buscarJugador(idJugador) == null) {
                return jugador.eliminarJugador(idJugador);
            }else {
                return "El jugador no existe";
            }
        }
        public List<eJugador> listarJugadoresxPosicion(string pos) {
            List<eJugador> lista = new List<eJugador>();
            foreach (eJugador jugador in jugador.listarJugadores()) {
                if (jugador.posicionDeJuego == pos) {
                    lista.Add(jugador);
                }
            }
            return lista;
        }
        public eJugador buscarJugador(string idJugador) {
            return jugador.buscarJugador(idJugador);
        }
        public List<eJugador> listarJugadores() {
            return jugador.listarJugadores();
        }
    }
}
