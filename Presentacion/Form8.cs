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
    public partial class Form8 : Form {
        nEntrenador nEntrenador = new nEntrenador();
        public Form8() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox2.Text.Count() == 8) {
                if (textBox1.Text != "" && textBox3.Text != "" && textBox6.Text != "") {
                    MessageBox.Show(nEntrenador.registrarEntrenador(textBox2.Text, textBox1.Text, Convert.ToInt32(textBox3.Text), textBox6.Text));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox6.Clear();
                    textBox1.Focus();
                }
            } else {
                MessageBox.Show("INGRESE UN DNI VALIDO");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsLetter(e.KeyChar)) {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            } else {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            } else {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            if (Char.IsDigit(e.KeyChar)) {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar)) {
                e.Handled = false;
            } else {
                e.Handled = true;
            }
        }
    }
}
