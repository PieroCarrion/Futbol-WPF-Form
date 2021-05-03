using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
namespace Datos {
    public class dEntrenador {
        DataBase db = new DataBase();
        public string insertarEntrenador(eEntrenador Entrenador) {
            try {
                string insert = string.Format("INSERT INTO tabla_Entrenadores (dni,nombre,edad,descripcion) VALUES ('{0}','{1}',{2},'{3}')", Entrenador.dni,Entrenador.nombreEntrenador, Entrenador.edadEntrenador, Entrenador.descripcionEntrenador);
                SqlCommand cmd = new SqlCommand(insert, db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Entrenador Registrado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string modificarEntrenador(eEntrenador Entrenador, int dni) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE tabla_Entrenadores SET nombre = '{0}', edad = {1}, descripcion = '{2}' WHERE dni = '{3}' ", Entrenador.nombreEntrenador, Entrenador.edadEntrenador, Entrenador.descripcionEntrenador,dni), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Entrenador Modificado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public string eliminarEntrenador(string dni) {
            try {
                SqlCommand cmd = new SqlCommand(string.Format("DELETE FROM tabla_Entrenadores WHERE dni = '{0}'", dni), db.conectaDB());
                cmd.ExecuteNonQuery();
                return "Entrenador Eliminado";
            } catch (SqlException ex) {
                return ex.Message;
            } finally {
                db.desconectaDB();
            }
        }
        public eEntrenador buscarEntrenador(string dni) {
            eEntrenador aux = null;
            try {
                SqlCommand cmd = new SqlCommand(string.Format("SELECT dni, nombre, edad, descripcion FROM tabla_Entrenadores WHERE dni= '{0}'", dni), db.conectaDB());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    aux = new eEntrenador();
                    aux.dni = (string)reader["dni"];
                    aux.nombreEntrenador = (string)reader["nombre"]; 
                    aux.edadEntrenador= (int)reader["edad"];
                    aux.descripcionEntrenador = (string)reader["descripcion"];
                }
                reader.Close();
                return aux;
            } catch (SqlException ex) {
                return null;
            } finally {
                db.desconectaDB();
            }
        }
        public List<eEntrenador> listarEntrenadors() {
            List<eEntrenador> listaEntrenador = new List<eEntrenador>();
            eEntrenador aux = null;
            try {
                SqlCommand cmd = new SqlCommand("SELECT dni, nombre, edad, descripcion FROM tabla_Entrenadores", db.conectaDB());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    aux = new eEntrenador();
                    aux = new eEntrenador();
                    aux.dni = (string)reader["dni"];
                    aux.nombreEntrenador = (string)reader["nombre"];
                    aux.edadEntrenador = (int)reader["edad"];
                    aux.descripcionEntrenador = (string)reader["descripcion"];
                    listaEntrenador.Add(aux);
                }
                reader.Close();
                return listaEntrenador;
            } catch (SqlException ex) {
                return null;
            } finally {
                db.desconectaDB();
            }
        }
    }
}
