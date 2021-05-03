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
    public partial class Form5 : Form
    {
        nJugador jugador = new nJugador();
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            ListViewItem item;
            foreach (eJugador jugador in jugador.listarJugadores()) {
                item = new ListViewItem();
                item = listView1.Items.Add(jugador.DNI);
                item.SubItems.Add(jugador.NombreCompleto);
                item.SubItems.Add(jugador.partidosJugados.ToString());
                item.SubItems.Add(jugador.trofeosObtenidos.ToString());
                item.SubItems.Add(jugador.talla.ToString());
                item.SubItems.Add(jugador.peso.ToString());
                item.SubItems.Add(jugador.edad.ToString());
                item.SubItems.Add(jugador.posicionDeJuego);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
