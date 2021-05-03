using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
namespace Presentacion {
    public partial class Form7 : Form
    {
        nEquipo nEquipo = new nEquipo();
        nJugador nJugador = new nJugador();
        
        public Form7()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex != -1) {
                listView2.Items.Clear();
                ListViewItem item;
                if (nJugador.listarJugadoresxPosicion(comboBox1.SelectedItem.ToString()) != null) {
                    foreach (eJugador jugador in nJugador.listarJugadoresxPosicion(comboBox1.SelectedItem.ToString())) {
                        item = new ListViewItem();
                        item = listView2.Items.Add(jugador.DNI);
                        item.SubItems.Add(jugador.NombreCompleto);
                        item.SubItems.Add(jugador.partidosJugados.ToString());
                        item.SubItems.Add(jugador.trofeosObtenidos.ToString());
                        item.SubItems.Add(jugador.talla.ToString());
                        item.SubItems.Add(jugador.peso.ToString());
                        item.SubItems.Add(jugador.edad.ToString());
                        item.SubItems.Add(jugador.posicionDeJuego);
                    }
                }
                
            }
        }
    }
}
