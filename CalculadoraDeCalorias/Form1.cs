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
                MessageBox.Show("Por favor escolha uma atividade valida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxResultado.Clear();
                cmbAtividade.Focus();
            }
            else if (textBoxPeso.Text == "")
            {
                MessageBox.Show("Por favor insira seu peso em KG", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPeso.Clear();
                textBoxPeso.Focus();
            }
            else if (Convert.ToInt32(textBoxPeso.Text) < 1 || Convert.ToInt32(textBoxPeso.Text) > 200)
            {
                MessageBox.Show("Peso deve estar entre 1kg e 200kg", "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxResultado.Clear();
                textBoxPeso.Focus();
            }
            else
            {
               switch (cmbAtividade.SelectedItem)
                {
                    case "Caminhada":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    case "Natação":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    case "Futbol":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    case "Basketball":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    case "Volei":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    case "Pedalar de Bike":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    case "Correr":
                        textBoxResultado.Text = (Convert.ToDecimal(textBoxPeso.Text) * numericUpDownTempo.Value * 2).ToString();
                        break;

                    default:
                        MessageBox.Show("Escolha uma opção válida");
                        break;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbAtividade.ResetText();
            textBoxPeso.Clear();
            numericUpDownTempo.Value = 1;
            textBoxResultado.Clear();
            cmbAtividade.Focus();
        }
    }
}
