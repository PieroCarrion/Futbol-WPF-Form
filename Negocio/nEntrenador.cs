using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio {
    public class nEntrenador {
        private dEntrenador Entrenador = new dEntrenador();
        public string registrarEntrenador(string dniEntrenador, string nombre, int edad, string descripcion) {
            eEntrenador aux = new eEntrenador {
                dni = dniEntrenador,
                nombreEntrenador = nombre,
                edadEntrenador = edad,
                descripcionEntrenador = descripcion
            };
            if (Entrenador.buscarEntrenador(dniEntrenador) == null) {
                return Entrenador.insertarEntrenador(aux);
            } else {
                return "El Entrenador ya existe";
            }
        }
        public string modificarEntrenador(string dniEntrenador, string nombre, int edad, string descripcion, int idAModificar) {
            eEntrenador aux = new eEntrenador {
                dni = dniEntrenador,
                nombreEntrenador = nombre,
                edadEntrenador = edad,
                descripcionEntrenador = descripcion
            };
            return Entrenador.modificarEntrenador(aux, idAModificar);
        }
        public string eliminarEntrenador(string idEntrenador) {
            if (Entrenador.buscarEntrenador(idEntrenador) == null) {
                return Entrenador.eliminarEntrenador(idEntrenador);
            } else {
                return "El Entrenador no existe";
            }
        }
        public eEntrenador buscarEntrenador(string idEntrenador) {
            return Entrenador.buscarEntrenador(idEntrenador);
        }
        public List<eEntrenador> listarEntrenadores() {
            return Entrenador.listarEntrenadors();
        }
    }
}
