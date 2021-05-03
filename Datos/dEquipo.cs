using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
namespace Datos {
    public class dEquipo {
        DataBase db = new DataBase();
        public string insertarEquipo(eEquipo Equipo) {
            try {
                string insert = string.Format("INSERT INTO tabla_Equipos (idEquipo,idEntrenador,idJugador,nombreCategoria) VALUES ('{0}','{1}','{2}','{3}')", Equipo.idEquipo, Equipo.idEntrenador, Equipo.idJugador, Equipo.NombreCategoria);
                SqlCommand cmd = new SqlCommand(insert, db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Equipo Registrado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string modificarEquipoEntrenador(eEquipo Equipo,int idEquipo ,int idEntrenador) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE tabla_Equipos SET idEntrenador = '{0}', idJugador = '{1}', nombreCategoria = '{2}' WHERE idEquipo = '{3}' ", Equipo.idEntrenador, Equipo.idJugador, Equipo.NombreCategoria, idEntrenador), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Equipo Modificado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string modificarEquipoJugadores(eEquipo Equipo, int idEquipo,int idJugador) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE tabla_Equipos SET idEquipo = {0}, idEntrenador = {1}, idJugador = '{2}', nombreCategoria = '{3}' WHERE idEquipo = '{4}' ", Equipo.idEquipo, Equipo.idEntrenador, Equipo.idJugador, Equipo.NombreCategoria, idEquipo), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Equipo Modificado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string eliminarEquipo(string idEquipo) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM tabla_Equipos WHERE idEquipo = '{0}'", idEquipo), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Equipo Eliminado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public List<eEquipo> buscarEquipo(string idEquipo) {
            List<eEquipo> listaEquipo = new List<eEquipo>();
            eEquipo aux = null;
            try {
                SqlCommand cmd = new SqlCommand(string.Format("SELECT idEquipo,idEntrenador,idJugador,nombreCategoria FROM tabla_Equipos WHERE idEquipo='{0}'", idEquipo), db.conectaDB());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    aux = new eEquipo();
                    aux.idEquipo = (string)reader["idEquipo"];
                    aux.idEntrenador = (string)reader["idEntrenador"];
                    aux.idJugador = (string)reader["idJugador"] ;
                    aux.NombreCategoria = (string)reader["nombreCategoria"];
                    listaEquipo.Add(aux);
                }
                reader.Close();
                return listaEquipo;
            } catch (SqlException ex) {
                return null;
            } finally {
                db.desconectaDB();
            }
        }
        public List<eEquipo> listarEquipos() {
            List<eEquipo> listaEquipo = new List<eEquipo>();
            eEquipo aux = null;
            try {
                SqlCommand cmd = new SqlCommand("SELECT idEquipo,idEntrenador,idJugador,nombreCategoria FROM tabla_Equipos", db.conectaDB());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    aux = new eEquipo();
                    aux.idEquipo = (string)reader["idEquipo"];
                    aux.idEntrenador = (string)reader["idEntrenador"];
                    aux.idJugador = (string)reader["idJugador"];
                    aux.NombreCategoria = (string)reader["nombreCategoria"];
                    listaEquipo.Add(aux);
                }
                reader.Close();
                return listaEquipo;
            } catch (SqlException ex) {
                return null;
            } finally {
                db.desconectaDB();
            }
        }

    }
}
