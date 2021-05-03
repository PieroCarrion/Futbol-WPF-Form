using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
namespace Presentacion {
    public partial class Form2 : Form
    {
        nJugador nJugador = new nJugador();
        nEntrenador nEntrenador = new nEntrenador();
        nEquipo nEquipo = new nEquipo();
        List<eJugador> jugadores;
        List<eJugador> jugadoresEquipo;
        ListViewItem item;
        eJugador jugadorAux = new eJugador();
        public Form2()
        {
            InitializeComponent();
            jugadores = nJugador.listarJugadores();
        }
        void listar() {
            listBox1.DataSource = jugadores;
            listBox1.DisplayMember = "NombreCompleto";
            listBox1.ValueMember = "DNI";
            comboBox2.DataSource = nEntrenador.listarEntrenadores();
            comboBox2.DisplayMember = "nombreEntrenador";
            comboBox2.ValueMember = "dni";
        }
        private void Form2_Load(object sender, EventArgs e) { 
            jugadoresEquipo = new List<eJugador>();
            listar();
            comboBox2.SelectedIndex = -1;
            listBox1.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (jugadoresEquipo.Count() > 0) {
                if (textBox1.Text!="" && comboBox2.SelectedIndex != -1 &&  comboBox1.SelectedIndex != -1) {
                    if (nEquipo.registrarEquipo(textBox1.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedValue.ToString(), jugadoresEquipo)) {
                        MessageBox.Show("Equipo Registrado");
                        comboBox1.SelectedIndex = -1;
                        comboBox2.SelectedIndex = -1;
                        listView2.Items.Clear();
                    } else {
                        MessageBox.Show("error");
                    }
                } else {
                    MessageBox.Show("Complete los espacios en Blanco");
                }
            } else {
                MessageBox.Show("No hay jugadores seleccionados");
            }
            listBox1.SelectedIndex = -1;

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e) {
            jugadorAux = nJugador.buscarJugador(listBox1.SelectedValue.ToString());
            if (!jugadoresEquipo.Exists(delegate (eJugador jugador) { return jugador.DNI == jugadorAux.DNI; })) {
                listView2.Items.Clear();
                jugadoresEquipo.Add(jugadorAux);
                foreach (eJugador jugador in jugadoresEquipo) {
                    item = new ListViewItem();
                    item = listView2.Items.Add(jugador.DNI);
                    item.SubItems.Add(jugador.NombreCompleto);
                    item.SubItems.Add(jugador.posicionDeJuego);
                }
                listBox1.SelectedIndex = -1;
            } else {
                MessageBox.Show("El jugador ya pertenece a un equipo");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsLetter(e.KeyChar)) {
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            } 
            else {
                e.Handled = true;
            }
        }
    }
}
