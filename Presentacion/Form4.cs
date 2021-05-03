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
    public partial class Form4 : Form
    {
        nEquipo nEquipo = new nEquipo();
        nJugador nJugador = new nJugador();
        eEquipo aux = new eEquipo();
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            if (nEquipo.listarEquipos() != null) {
                comboBox1.DataSource = nEquipo.listarNombresEquipos();
                comboBox1.DisplayMember = "idEquipo";
                comboBox1.ValueMember = "idEquipo";
                comboBox1.SelectedIndex = -1;
            } else {
                MessageBox.Show("No hay equipos");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) {
                listView2.Items.Clear();
                ListViewItem item;
                eJugador aux = null;
                foreach (eEquipo equipo in nEquipo.buscarEquipo(comboBox1.SelectedValue.ToString())) {
                    item = new ListViewItem();
                    aux = new eJugador();
                    aux = nJugador.buscarJugador(equipo.idJugador);
                    item = listView2.Items.Add(aux.DNI);
                    item.SubItems.Add(aux.NombreCompleto);
                    item.SubItems.Add(aux.partidosJugados.ToString());
                    item.SubItems.Add(aux.trofeosObtenidos.ToString());
                    item.SubItems.Add(aux.talla.ToString());
                    item.SubItems.Add(aux.peso.ToString());
                    item.SubItems.Add(aux.edad.ToString());
                    item.SubItems.Add(aux.posicionDeJuego);
                }
            }
        }
    }
}
