using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversoresdeUnidad
{
    public partial class Form1 : Form
    {
        Conversioness objConversor = new Conversioness();
        public Form1()

        {

            InitializeComponent();

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = objConversor.convertir(cboTipo.SelectedIndex, cboDe.SelectedIndex,
                    cboA.SelectedIndex, double.Parse(txtCantidad.Text)).ToString();

                //  errorProvider1.SetError(txtCantidad, "");
            }
            catch (Exception ex)
            {
                // errorProvider1.SetError(txtCantidad, "Por favor digite la cantidad");
                MessageBox.Show("Ingrese los valores correspondiente.","Conversores",
                  MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboDe.Items.Clear();
                cboA.Items.Clear();
                cboDe.Items.AddRange(objConversor.conversor[cboTipo.SelectedIndex]);
                cboA.Items.AddRange(objConversor.conversor[cboTipo.SelectedIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo fue mal, por favor intentelo mas tarde...", ex.Message + "Conversores",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}







