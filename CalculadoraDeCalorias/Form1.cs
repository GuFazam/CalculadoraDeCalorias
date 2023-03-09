using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeCalorias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbAtividade.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Por favor prencha todos os campos acima", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResultado.Clear();
                cmbAtividade.Focus();
            }
            else if (textBoxPeso.TextLength == 0)
            {
                MessageBox.Show("Por favor prencha todos os campos acima", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPeso.Clear();
                textBoxPeso.Focus();
            }
            else
            {
                //textBoxResultado.Text = Convert.ToInt32(numericUpDownTempo.Value * textBoxPeso.Text);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxPeso.Text = " ";
            numericUpDownTempo.Value = 1;
            cmbAtividade.SelectedIndex.Equals(-1);
        }
    }
}
