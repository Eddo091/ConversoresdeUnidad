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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMon_Click(object sender, EventArgs e)
        {
            try
            {
                double Cantidad = double.Parse(txtmon.Text), dolar = 1.00, euro = 1.13, Quet = 0.013, lemp = 0.041,
                    cordoba = 0.031, CR = 605.36, SV = 0.11, respuesta = 0,
                moneda = 0;
                switch (cboDeMon.SelectedIndex)
                {

                    case 0://DOLAR

                        moneda = Cantidad * dolar;
                        break;
                    case 1://EURO
                        moneda = Cantidad * euro;
                        break;
                    case 2://QUETZAL
                        moneda = Cantidad * Quet;
                        break;
                    case 3://LEMPIRA
                        moneda = Cantidad * lemp;
                        break;
                    case 4://CORDOBA
                        moneda = Cantidad * cordoba;
                        break;
                    case 5://CR
                        moneda = Cantidad * CR;
                        break;
                    case 6://SV
                        moneda = Cantidad * SV;
                        break;

                }


                switch (cboAMon.SelectedIndex)
                {
                    case 0://DOLAR

                        respuesta = moneda / dolar;
                        break;
                    case 1://EURO
                        respuesta = moneda / euro;
                        break;
                    case 2://QUETZAL
                        respuesta = moneda / Quet;
                        break;
                    case 3://LEMPIRA
                        respuesta = moneda / lemp;
                        break;
                    case 4://CORDOBA
                        respuesta = moneda / cordoba;
                        break;
                    case 5://CR
                        respuesta = moneda / CR;
                        break;
                    case 6://SV
                        respuesta = moneda / SV;
                        break;

                }
                lblRespMo.Text = "Total: " + respuesta;
            }
            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor Moneda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //longitud
        private void BtnLong_Click(object sender, EventArgs e)
        {
            try
            {

                string from, to;

                from =cboDeLong.SelectedItem.ToString() ;
                to = cboALong.SelectedItem.ToString();

               
                double Cantidad = double.Parse(txtlong.Text), METRO = 1, CM = 100, Pulg = 0.393701, Yardas = 0.0109361,
                    varas = 1.430828, ft = 0.0328084, kms = 1000, millas = 1609.344, respuesta = 0,
                dato = 0;

                

                switch (cboDeLong.SelectedIndex)
                {

                    case 0://METRO
                        if (from == "Metro" && to == "Cm")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) * 100);

                        }
                        if (from == "METRO" && to == "Pulg")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) * 39.37);

                        }
                        if (from == "METRO" && to == "Yardas")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) * 1.094);

                        }
                        if (from == "METRO" && to == "varas")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) * 1.430828);

                        }
                        
                        if (from == "METRO" && to == "ft")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) * 3.281);

                        }
                        if (from == "METRO" && to == "kms")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 1000);

                        }
                        if (from == "METRO" && to == "millas")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 1609);

                        }
                        break;
                    case 1://CM
                        if (from == "CM" && to == "METRO")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 100);

                        }
                        if (from == "CM" && to == "Pulg")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 2.54);

                        }
                        if (from == "CM" && to == "Yardas")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 91.44);

                        }
                        if (from == "CM" && to == "varas")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 1.430828);

                        }
                        if (from == "CM" && to == "ft")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 30.48);

                        }
                        if (from == "CM" && to == "kms")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 100000);

                        }
                        if (from == "CM" && to == "millas")
                        {
                            lblRespLong.Text = Convert.ToString(Convert.ToInt32(txtlong.Text) / 160934);

                        }
                        break;
                    case 2://PULGADA
                        dato = Cantidad / Pulg * Cantidad;
                        break;
                    case 3://YARDA
                        dato = Cantidad / Yardas * Cantidad;
                        break;
                    case 4://VARA
                        dato = Cantidad / varas * Cantidad;
                        break;
                    case 5://PIES
                        dato = Cantidad / ft * Cantidad;
                        break;
                    case 6://KMS
                        dato = Cantidad / kms * Cantidad;
                        break;
                    case 7://MILLAS
                        dato = Cantidad / millas * Cantidad;
                        break;
                }


                switch (cboALong.SelectedIndex)
                {

                    case 0://METRO
                        if (cboDeLong.SelectedIndex == 1)
                            respuesta = dato / METRO * dato;
                        else
                            respuesta = dato * METRO / dato;
                        break;
                    case 1://CM
                        if (cboDeLong.SelectedIndex == 0)
                            respuesta = dato * CM / dato;
                        else
                            respuesta = dato / CM * dato;
                        break;
                    case 2://PULG

                        respuesta = dato / Pulg * dato;
                        break;
                    case 3://YARDA
                        respuesta = dato / Yardas * dato;
                        break;
                    case 4://VARA
                        respuesta = dato / varas * dato;
                        break;
                    case 5://PIE
                        respuesta = dato / ft * dato;
                        break;
                    case 6://KMS
                        respuesta = dato / kms * dato;
                        break;
                    case 7://MILLA
                        respuesta = dato / millas * dato;
                        break;

                }

                lblRespLong.Text = "Total: " + respuesta;
            }
            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor longitud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //masa
        private void btnPeso_Click(object sender, EventArgs e)
        {
            try
            {

                double Cantidad = double.Parse(txtpeso.Text), gramo = 100, ML = 1000, onza = 28.35, Kg = 1000,
                    libras = 453.592, quintal = 100, respuesta = 0,
                dato = 0; 
                switch (cboDePes.SelectedIndex)
                {
                    case 0://GRAMOS

                        dato = Cantidad * gramo / Cantidad;
                        break;
                    case 1://ML
                        dato = Cantidad * ML / Cantidad;
                        break;
                    case 2://ONZA
                        dato = Cantidad * onza / Cantidad;
                        break;
                    case 3://KG
                        dato = Cantidad * Kg / Cantidad;
                        break;
                    case 4://LIBRA
                        dato = Cantidad * libras / Cantidad;
                        break;
                    case 5://QUINTAL
                        dato = Cantidad * quintal / Cantidad;
                        break;

                }

                switch (cboAPes.SelectedIndex)
                {
                    case 0://GRAMOS

                        respuesta = dato / gramo * dato;
                        break;
                    case 1://ML
                        respuesta = dato / ML * dato;
                        break;
                    case 2://ONZA
                        respuesta = dato / onza * dato;
                        break;
                    case 3://KG
                        respuesta = dato / Kg * dato;
                        break;
                    case 4://LIBRA
                        respuesta = dato / libras * dato;
                        break;
                    case 5://QUINTAL
                        respuesta = dato / quintal * dato;
                        break;

                }

                lblRespPeso.Text = "Total: " + respuesta;


            }
            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor masa(peso)",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            } 


        }
        //temperatura
        private void btnTemp_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                double temp = double.Parse(txtTemp.Text), C = 32, F = 9 / 5, k = 273.15, datotemp = 0, respuesta = 0;

                switch (cboDeTemp.SelectedIndex)
                {

                    case 0://C


                        break;
                    case 1://F

                        break;
                    case 2://K

                        break;


                }

                switch (cboATemp.SelectedIndex)
                {
                    case 0://C
                        if (cboDeTemp.SelectedIndex == 1)
                            respuesta = (datotemp - C) * F;
                        if (cboDeTemp.SelectedIndex == 2)
                            respuesta = datotemp - k;

                        break;
                    case 1://F
                        if (cboDeTemp.SelectedIndex == 0)
                            respuesta = (datotemp * F) + C;
                        if (cboDeTemp.SelectedIndex == 2)
                            respuesta = (datotemp - k) * F + C;

                        break;
                    case 2://K

                        if (cboDeTemp.SelectedIndex == 0)
                            respuesta = (datotemp + k);
                        if (cboDeTemp.SelectedIndex == 1)
                            respuesta = (datotemp - C) * F + k;

                        break;
                }
                lblRespTemp.Text = "Temp: " + respuesta + "\n";

            }



            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor temperatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void BtnAlmacenaje_Click(object sender, EventArgs e)
        {
           
            try
            {
                double Alma = double.Parse(txtAlma.Text),Bit=8, Byte=1, KB = 1024, MB = 1048576, GB = 1073741824,TB= 1099511627776, PB= 1125899906842624,EB= 1152921504606846976 , datoAlma = 0, respuesta = 0;

                switch (cboDeAlma.SelectedIndex)
                {

                    case 0://BIT
                        datoAlma = Alma * Bit / Alma;

                        break;
                    case 1://BYTE
                        datoAlma = Alma; //* Byte / Alma;
                        break;
                    case 2://KB
                        datoAlma = Alma * KB / Alma;
                        break;
                    case 3://MB
                        datoAlma = Alma * MB / Alma;

                        break;
                    case 4://GB
                        datoAlma = Alma * GB / Alma;
                        break;
                    case 5://TB
                        datoAlma = Alma * TB / Alma;
                        break;
                    case 6://PB
                        datoAlma = Alma * PB / Alma;
                        break;
                    case 7://EB
                        datoAlma = Alma * EB / Alma;
                        break;
                   



                }

                switch (cboAAlma.SelectedIndex)
                {
                    case 0://BIT
                        datoAlma = Alma / Bit * Alma;

                        break;
                    case 1://BYTE
                        datoAlma = Alma / Byte * Alma;

                        break;
                    case 2://KB

                        datoAlma = Alma / KB * Alma;

                        break;
                    case 3://MB
                        datoAlma = Alma / MB * Alma;

                        break;
                    case 4://GB
                        datoAlma = Alma / GB * Alma;

                        break;
                    case 5://TB
                        datoAlma = Alma / TB * Alma;


                        break;
                    case 6://PB
                        datoAlma = Alma / PB * Alma;

                        break;
                    case 7://EB
                        datoAlma = Alma / EB*Alma;
                        break;
                   
                }
                lblAlmacenaje.Text = "Total: " + respuesta + "\n";

            }



            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor temperatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
    }
}

