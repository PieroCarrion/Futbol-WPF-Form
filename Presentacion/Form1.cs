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
namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ingresarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            fmr.ShowDialog();
        }

        private void ingresarClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fmr = new Form2();
            fmr.ShowDialog();
        }

        private void listarJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fmr = new Form4();
            fmr.ShowDialog();
        }

        private void listarJugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 fmr = new Form5();
            fmr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void listarJugadoresPorPosicionDeJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fmr = new Form7();
            fmr.ShowDialog();
        }
        private void totalDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nJugador nJugador = new nJugador();
            int total = 0;
            if (nJugador.listarJugadores()!=null) {
                foreach (eJugador jugador in nJugador.listarJugadores()) {
                    total += 1;
                }
            }
           MessageBox.Show("Total de jugadores:" + " " + total.ToString());

        }
        private void ingresarEntrenadorToolStripMenuItem_Click(object sender, EventArgs e) {
            Form8 x = new Form8();
            x.ShowDialog();

        }
    }
}
