using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio {
    public class nEquipo {
        private dEquipo Equipo = new dEquipo();
        public bool registrarEquipo(string nombre,string nombreCategoria, string idEntrenador, List<eJugador> listaJugadores) {

            eEquipo aux = null;
            bool flag = true;
            foreach (eJugador jugador in listaJugadores) {
                aux = new eEquipo {
                    idEquipo = nombre,
                    NombreCategoria = nombreCategoria,
                    idEntrenador = idEntrenador,
                    idJugador = jugador.DNI
                };
                if(Equipo.insertarEquipo(aux) == "Equipo Registrado") {
                    flag = true;
                }
                else{
                    flag = false;
                    break;
                }
                aux = null;
            }
            return flag;
        }
        public bool existeJugadorEnOtroEquipo(string idJugador) {
            bool flag = false;
            foreach ( eEquipo equipo in Equipo.listarEquipos()) {
                if (equipo.idJugador == idJugador) {
                    flag = true;
                    break;
                } else {
                    flag = false;
                }
            }
            return flag;
        }
        public string eliminarEquipo(string idEquipo) {
            if (Equipo.buscarEquipo(idEquipo) == null) {
                return Equipo.eliminarEquipo(idEquipo);
            } else {
                return "El Equipo no existe";
            }
        }
        public List<eEquipo> buscarEquipo(string idEquipo) {
            return Equipo.buscarEquipo(idEquipo);
        }
        public List<eEquipo> listarEquipos() {
            return Equipo.listarEquipos();
        }
        public List<eEquipo> listarNombresEquipos() {
            List<eEquipo> lista = new List<eEquipo>();
            eEquipo aux = new eEquipo(); ;
            foreach (eEquipo equipo in Equipo.listarEquipos()) {
                if (equipo.idEquipo != aux.idEquipo) {
                    aux = equipo;
                    lista.Add(equipo);
                }
            }

            return lista;
        }
    }
}
