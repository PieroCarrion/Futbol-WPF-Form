using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
namespace Datos {
    public class dJugador {
        DataBase db = new DataBase();
        public string insertarJugador(eJugador Jugador) {
            try {
                string insert = string.Format("INSERT INTO tabla_Jugadores (dni,nombre,partidosJugados,trofeosObtenidos,talla,peso,edad,posicionDeJuego) VALUES ('{0}','{1}',{2},{3},{4},{5},{6},'{7}')", Jugador.DNI, Jugador.NombreCompleto, Jugador.partidosJugados, Jugador.trofeosObtenidos,Jugador.talla,Jugador.peso,Jugador.edad,Jugador.posicionDeJuego);
                SqlCommand cmd = new SqlCommand(insert, db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Jugador Registrado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string modificarJugador(eJugador Jugador, string idJugador) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE tabla_Jugadores SET dni = '{0}', nombre = '{1}', partidosJugados = {2}, trofeosObtenidos = {3},talla = {4},peso = {5},edad = {6},posicionDeJuego = {7} WHERE dni = '{8}' ", Jugador.DNI, Jugador.NombreCompleto, Jugador.partidosJugados, Jugador.trofeosObtenidos, Jugador.talla, Jugador.peso, Jugador.edad, Jugador.posicionDeJuego, idJugador), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Jugador Modificado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string eliminarJugador(string idJugador) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM tabla_Jugadores WHERE dni = '{0}'", idJugador), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Jugador Eliminado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public eJugador buscarJugador(string idJugador) {
            eJugador aux = null;
            try {
                SqlCommand cmd = new SqlCommand(string.Format("SELECT dni,nombre,partidosJugados,trofeosObtenidos,talla,peso,edad,posicionDeJuego FROM tabla_Jugadores WHERE dni='{0}'", idJugador), db.conectaDB());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    aux = new eJugador();
                    aux.DNI= (string)reader["dni"];
                    aux.NombreCompleto = (string)reader["nombre"];
                    aux.partidosJugados = (int)reader["partidosJugados"];
                    aux.trofeosObtenidos = (int)reader["trofeosObtenidos"];
                    aux.talla = (decimal)reader["talla"];
                    aux.peso = (decimal)reader["peso"];
                    aux.edad = (int)reader["edad"];
                    aux.posicionDeJuego = (string)reader["posicionDeJuego"];
                }
                reader.Close();
                return aux;
            } catch (SqlException ex) {
                return null;
            } finally {
                db.desconectaDB();
            }
        }
        public List<eJugador> listarJugadores() {
            List<eJugador> listaJugadores = new List<eJugador>();
            eJugador aux = null;
            try {
                SqlCommand cmd = new SqlCommand("SELECT dni,nombre,partidosJugados,trofeosObtenidos,talla,peso,edad,posicionDeJuego FROM tabla_Jugadores", db.conectaDB());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    aux = new eJugador();
                    aux.DNI = (string)reader["dni"];
                    aux.NombreCompleto = (string)reader["nombre"];
                    aux.partidosJugados = (int)reader["partidosJugados"];
                    aux.trofeosObtenidos = (int)reader["trofeosObtenidos"];
                    aux.talla = (decimal)reader["talla"];
                    aux.peso = (decimal)reader["peso"];
                    aux.edad = (int)reader["edad"];
                    aux.posicionDeJuego = (string)reader["posicionDeJuego"];
                    listaJugadores.Add(aux);
                }
                reader.Close();
                return listaJugadores;
            } catch (SqlException ex) {
                return null;
            } finally {
                db.desconectaDB();
            }
        }
    }
}
