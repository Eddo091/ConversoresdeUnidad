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
        //Moneda
        private void BtnMon_Click(object sender, EventArgs e)
        {
            //limpiar txtbox
            txtAlma.Text = "";
            txtlong.Text = "";
            txtpeso.Text = "";
            txtTemp.Text = "";
            //limpiar lbl
            lblAlmacenaje.Text = "";
            lblRespLong.Text = "";
            lblRespPeso.Text = "";
            lblRespTemp.Text = "";
            try
            {

                string from, to;

                from = cboDeMon.SelectedItem.ToString();
                to = cboAMon.SelectedItem.ToString();
                double Cantidad = double.Parse(txtmon.Text), 
                moneda = 0;
                switch (cboDeMon.SelectedIndex)
                {

                    case 0://DOLAR
                        if (from == "Dolar" && to == "Euro")
                        {
                            moneda = Cantidad / 1.09;
                        }
                        if (from == "Dolar" && to == "Quetzal")
                        {
                            moneda = Cantidad / 0.13;
                        }
                        if (from == "Dolar" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.040;
                        }
                        if (from == "Dolar" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.030;
                        }
                        if (from == "Dolar" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.0018;
                        }
                        if (from == "Dolar" && to == "Colon SV")
                        {
                            moneda = Cantidad / 0.11;
                        }
                        break;
                    case 1://EURO
                        if (from == "Euro" && to == "Dolar")
                        {
                            moneda = Cantidad / 0.92;
                        }
                        if (from == "Euro" && to == "Quetzal")
                        {
                            moneda = Cantidad / 0.12;
                        }
                        if (from == "Euro" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.037;
                        }
                        if (from == "Euro" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.027;
                        }
                        if (from == "Euro" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.0016;
                        }
                        if (from == "Euro" && to == "Colon SV")
                        {
                            moneda = Cantidad / 0.10;
                        }
                        break;
                    case 2://QUETZAL
                        if (from == "Quetzal" && to == "Dolar")
                        {
                            moneda = Cantidad / 5.79;
                        }
                        if (from == "Quetzal" && to == "Euro")
                        {
                            moneda = Cantidad / 8.34;
                        }
                        if (from == "Quetzal" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.31;
                        }
                        if (from == "Quetzal" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.32;
                        }
                        if (from == "Quetzal" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.013;
                        }
                        if (from == "Quetzal" && to == "Colon SV")
                        {
                            moneda = Cantidad / 0.87;
                        }
                        break;
                    case 3://LEMPIRA
                        if (from == "Lempira" && to == "Dolar")
                        {
                            moneda = Cantidad / 24.72;
                        }
                        if (from == "Lempira" && to == "Euro")
                        {
                            moneda = Cantidad / 26.87;
                        }
                        if (from == "Lempira" && to == "Quetzal")
                        {
                            moneda = Cantidad / 3.22;
                        }
                        if (from == "Lempira" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.73;
                        }
                        if (from == "Lempira" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.043;
                        }
                        if (from == "Lempira" && to == "Colon SV")
                        {
                            moneda = Cantidad / 2.82;
                        }
                        break;
                    case 4://CORDOBA
                        if (from == "Cordoba" && to == "Dolar")
                        {
                            moneda = Cantidad / 33.86;
                        }
                        if (from == "Cordoba" && to == "Euro")
                        {
                            moneda = Cantidad / 36.80;
                        }
                        if (from == "Cordoba" && to == "Quetzal")
                        {
                            moneda = Cantidad / 4.42;
                        }
                        if (from == "Cordoba" && to == "Lempira")
                        {
                            moneda = Cantidad / 1.37;
                        }
                        if (from == "Cordoba" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.059;
                        }
                        if (from == "Cordoba" && to == "Colon SV")
                        {
                            moneda = Cantidad / 3.86;
                        }
                        break;
                    case 5://CR
                        if (from == "Peso CR" && to == "Dolar")
                        {
                            moneda = Cantidad / 571.08;
                        }
                        if (from == "Peso CR" && to == "Euro")
                        {
                            moneda = Cantidad / 620.79;
                        }
                        if (from == "Peso CR" && to == "Quetzal")
                        {
                            moneda = Cantidad / 74.48;
                        }
                        if (from == "Peso CR" && to == "Lempira")
                        {
                            moneda = Cantidad / 74.48;
                        }
                        if (from == "Peso CR" && to == "Cordoba")
                        {
                            moneda = Cantidad / 16.87;
                        }
                        if (from == "Peso CR" && to == "Colon SV")
                        {
                            moneda = Cantidad / 64.83;
                        }
                        break;
                    case 6://SV
                        if (from == "Colon SV" && to == "Dolar")
                        {
                            moneda = Cantidad / 8.78;
                        }
                        if (from == "Colon SV" && to == "Euro")
                        {
                            moneda = Cantidad / 9.55;
                        }
                        if (from == "Colon SV" && to == "Quetzal")
                        {
                            moneda = Cantidad / 1.15;
                        }
                        if (from == "Colon SV" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.35;
                        }
                        if (from == "Colon SV" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.26;
                        }
                        if (from == "Colon SV" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.015;
                        }
                        break;

                }


                switch (cboAMon.SelectedIndex)
                {
                    case 0://DOLAR
                        if (from == "Dolar" && to == "Euro")
                        {
                            moneda = Cantidad / 1.09;
                        }
                        if (from == "Dolar" && to == "Quetzal")
                        {
                            moneda = Cantidad / 0.13;
                        }
                        if (from == "Dolar" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.040;
                        }
                        if (from == "Dolar" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.030;
                        }
                        if (from == "Dolar" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.0018;
                        }
                        if (from == "Dolar" && to == "Colon SV")
                        {
                            moneda = Cantidad / 0.11;
                        }
                        break;
                    case 1://EURO
                        if (from == "Euro" && to == "Dolar")
                        {
                            moneda = Cantidad / 0.92;
                        }
                        if (from == "Euro" && to == "Quetzal")
                        {
                            moneda = Cantidad / 0.12;
                        }
                        if (from == "Euro" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.037;
                        }
                        if (from == "Euro" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.027;
                        }
                        if (from == "Euro" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.0016;
                        }
                        if (from == "Euro" && to == "Colon SV")
                        {
                            moneda = Cantidad / 0.10;
                        }
                        break;
                    case 2://QUETZAL
                        if (from == "Quetzal" && to == "Dolar")
                        {
                            moneda = Cantidad / 5.79;
                        }
                        if (from == "Quetzal" && to == "Euro")
                        {
                            moneda = Cantidad / 8.34;
                        }
                        if (from == "Quetzal" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.31;
                        }
                        if (from == "Quetzal" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.32;
                        }
                        if (from == "Quetzal" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.013;
                        }
                        if (from == "Quetzal" && to == "Colon SV")
                        {
                            moneda = Cantidad / 0.87;
                        }
                        break;
                    case 3://LEMPIRA
                        if (from == "Lempira" && to == "Dolar")
                        {
                            moneda = Cantidad / 24.72;
                        }
                        if (from == "Lempira" && to == "Euro")
                        {
                            moneda = Cantidad / 26.87;
                        }
                        if (from == "Lempira" && to == "Quetzal")
                        {
                            moneda = Cantidad / 3.22;
                        }
                        if (from == "Lempira" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.73;
                        }
                        if (from == "Lempira" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.043;
                        }
                        if (from == "Lempira" && to == "Colon SV")
                        {
                            moneda = Cantidad / 2.82;
                        }
                        break;
                    case 4://CORDOBA
                        if (from == "Cordoba" && to == "Dolar")
                        {
                            moneda = Cantidad / 33.86;
                        }
                        if (from == "Cordoba" && to == "Euro")
                        {
                            moneda = Cantidad / 36.80;
                        }
                        if (from == "Cordoba" && to == "Quetzal")
                        {
                            moneda = Cantidad / 4.42;
                        }
                        if (from == "Cordoba" && to == "Lempira")
                        {
                            moneda = Cantidad / 1.37;
                        }
                        if (from == "Cordoba" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.059;
                        }
                        if (from == "Cordoba" && to == "Colon SV")
                        {
                            moneda = Cantidad / 3.86;
                        }
                        break;
                    case 5://CR
                        if (from == "Peso CR" && to == "Dolar")
                        {
                            moneda = Cantidad / 571.08;
                        }
                        if (from == "Peso CR" && to == "Euro")
                        {
                            moneda = Cantidad / 620.79;
                        }
                        if (from == "Peso CR" && to == "Quetzal")
                        {
                            moneda = Cantidad / 74.48;
                        }
                        if (from == "Peso CR" && to == "Lempira")
                        {
                            moneda = Cantidad / 74.48;
                        }
                        if (from == "Peso CR" && to == "Cordoba")
                        {
                            moneda = Cantidad / 16.87;
                        }
                        if (from == "Peso CR" && to == "Colon SV")
                        {
                            moneda = Cantidad / 64.83;
                        }
                        break;
                    case 6://SV
                        if (from == "Colon SV" && to == "Dolar")
                        {
                            moneda = Cantidad / 8.78;
                        }
                        if (from == "Colon SV" && to == "Euro")
                        {
                            moneda = Cantidad / 9.55;
                        }
                        if (from == "Colon SV" && to == "Quetzal")
                        {
                            moneda = Cantidad / 1.15;
                        }
                        if (from == "Colon SV" && to == "Lempira")
                        {
                            moneda = Cantidad / 0.35;
                        }
                        if (from == "Colon SV" && to == "Cordoba")
                        {
                            moneda = Cantidad / 0.26;
                        }
                        if (from == "Colon SV" && to == "Peso CR")
                        {
                            moneda = Cantidad / 0.015;
                        }
                        break;


                }
                lblRespMo.Text = "Total: " + moneda;
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
            //limpiar txtbox
            txtAlma.Text = "";
            txtmon.Text = "";
            txtpeso.Text = "";
            txtTemp.Text = "";
            //limpiar lbl
            lblAlmacenaje.Text = "";
            lblRespMo.Text = "";
            lblRespPeso.Text = "";
            lblRespTemp.Text = "";
            try
            {

                string from, to;

                from =cboDeLong.SelectedItem.ToString() ;
                to = cboALong.SelectedItem.ToString();

               
                double Cantidad = double.Parse(txtlong.Text),
                dato = 0;

                

                switch (cboDeLong.SelectedIndex)
                {

                    case 0://METRO
                        if (from == "Metro" && to == "Cm")
                        {
                            dato = Cantidad * 100;

                        }
                    
                        if (from == "Metro" && to == "Pulg")
                        {
                            dato = Cantidad  * 39.37;

                        }
                        if (from == "Metro" && to == "Yardas")
                        {
                            dato = Cantidad * 1.094;

                        }
                        if (from == "Metro" && to == "Varas")
                        {
                            dato = Cantidad * 1.430828;

                        }
                        
                        if (from == "Metro" && to == "Pies")
                        {
                            dato = Cantidad * 3.281;

                        }
                        if (from == "Metro" && to == "KMS")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Metro" && to == "Millas")
                        {
                            dato = Cantidad / 1609;

                        }
                        break;
                    case 1://CM
                        if (from == "Cm" && to == "Metro")
                        {
                            dato = Cantidad / 100;

                        }
                        if (from == "Cm" && to == "Pulg")
                        {
                            dato = Cantidad / 2.54;

                        }
                        if (from == "Cm" && to == "Yardas")
                        {
                            dato = Cantidad / 91.44;

                        }
                        if (from == "Cm" && to == "Varas")
                        {
                            dato = Cantidad / 1.430828;

                        }
                        if (from == "Cm" && to == "Pies")
                        {
                            dato = Cantidad / 30.48;

                        }
                        if (from == "Cm" && to == "KMS")
                        {
                            dato = Cantidad / 100000;

                        }
                        if (from == "Cm" && to == "Millas")
                        {
                            dato = Cantidad / 160934;

                        }
                        break;
                    case 2://PULGADA
                        if (from == "Pulg" && to == "Metro")
                        {
                            dato = Cantidad / 39.37;

                        }
                        if (from == "Pulg" && to == "cm")
                        {
                            dato = Cantidad * 2.54;

                        }
                        if (from == "Pulg" && to == "Yardas")
                        {
                            dato = Cantidad / 36;

                        }
                        if (from == "Pulg" && to == "Varas")
                        {
                            dato = Cantidad / 1.430828;

                        }
                        if (from == "Pulg" && to == "Pies")
                        {
                            dato = Cantidad / 12;

                        }
                        if (from == "Pulg" && to == "KMS")
                        {
                            dato = Cantidad / 39370;

                        }
                        if (from == "Pulg" && to == "Millas")
                        {
                            dato = Cantidad / 39370;

                        }
                        break;
                    case 3://YARDA
                        if (from == "Yardas" && to == "Metro")
                        {
                            dato = Cantidad / 1.094;

                        }
                        if (from == "Yardas" && to == "Cm")
                        {
                            dato = Cantidad * 91.44;

                        }
                        if (from == "Yardas" && to == "Pulg")
                        {
                            dato = Cantidad * 36;

                        }
                        if (from == "Yardas" && to == "Vara")
                        {
                            dato = Cantidad * 1.430828;

                        }
                        if (from == "Yardas" && to == "Pies")
                        {
                            dato = Cantidad * 3;

                        }
                        if (from == "Yardas" && to == "KMS")
                        {
                            dato = Cantidad / 1094;

                        }
                        if (from == "Yardas" && to == "Millas")
                        {
                            dato = Cantidad / 1760;

                        }
                        break;
                    case 4://VARA
                        if (from == "Vara" && to == "Metro")
                        {
                            dato = Cantidad / 1.193;

                        }
                        if (from == "Vara" && to == "Cm")
                        {
                            dato = Cantidad / 83.5905;

                        }
                        if (from == "Vara" && to == "Pulg")
                        {
                            dato = Cantidad / 32.9096;

                        }
                        if (from == "Vara" && to == "Yardas")
                        {
                            dato = Cantidad / 0.91415682414698;

                        }
                        if (from == "Vara" && to == "Pies")
                        {
                            dato = Cantidad / 2.7424704724409;

                        }
                        if (from == "Vara" && to == "KMS")
                        {
                            dato = Cantidad / 0.000835905;

                        }
                        if (from == "Vara" && to == "Millas")
                        {
                            dato = Cantidad / 0.00051940728644715;

                        }
                        break;
                    case 5://PIES
                        if (from == "Pies" && to == "Metros")
                        {
                            dato = Cantidad / 3.281;

                        }
                        if (from == "Pies" && to == "Cm")
                        {
                            dato = Cantidad * 30.48;
                            
                        }

                        if (from == "Pies" && to == "Pulg")
                        {
                            dato = Cantidad * 12;

                        }
                        if (from == "Pies" && to == "Yardas")
                        {
                            dato = Cantidad / 3;

                        }
                        if (from == "Pies" && to == "Varas")
                        {
                            dato = Cantidad / 0.364634737201;

                        }
                        if (from == "Pies" && to == "KMS")
                        {
                            dato = Cantidad / 3281;

                        }
                        if (from == "Pies" && to == "Millas")
                        {
                            dato = Cantidad / 5280;

                        }
                        break;
                    case 6://KMS
                        if (from == "KMS" && to == "Metros")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "KMS" && to == "Cm")
                        {
                            dato = Cantidad * 100000;

                        }
                        if (from == "KMS" && to == "Pulg")
                        {
                            dato = Cantidad * 100000;

                        }
                        if (from == "KMS" && to == "Yardas")
                        {
                            dato = Cantidad * 1094;

                        }
                        if (from == "KMS" && to == "Pies")
                        {
                            dato = Cantidad * 3281;

                        }
                        if (from == "KMS" && to == "Varas")
                        {
                            dato = Cantidad / 0.000835905;

                        }
                        if (from == "KMS" && to == "Millas")
                        {
                            dato = Cantidad / 1.609;

                        }
                        break;
                    case 7://MILLAS
                        if (from == "Millas" && to == "Metros")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Cm")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Pulg")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Yardas")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Varas")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Pies")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "KMS")
                        {
                            dato = Cantidad * 1609;

                        }
                        break;
                }


                switch (cboALong.SelectedIndex)
                {

                    case 0://METRO
                        if (from == "Metro" && to == "Cm")
                        {
                            dato = Cantidad * 100;

                        }

                        if (from == "Metro" && to == "Pulg")
                        {
                            dato = Cantidad * 39.37;

                        }
                        if (from == "Metro" && to == "Yardas")
                        {
                            dato = Cantidad * 1.094;

                        }
                        if (from == "Metro" && to == "Varas")
                        {
                            dato = Cantidad * 1.430828;

                        }

                        if (from == "Metro" && to == "Pies")
                        {
                            dato = Cantidad * 3.281;

                        }
                        if (from == "Metro" && to == "KMS")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Metro" && to == "Millas")
                        {
                            dato = Cantidad / 1609;

                        }
                        break;
                    case 1://CM
                        if (from == "Cm" && to == "Metro")
                        {
                            dato = Cantidad / 100;

                        }
                        if (from == "Cm" && to == "Pulg")
                        {
                            dato = Cantidad / 2.54;

                        }
                        if (from == "Cm" && to == "Yardas")
                        {
                            dato = Cantidad / 91.44;

                        }
                        if (from == "Cm" && to == "Varas")
                        {
                            dato = Cantidad / 1.430828;

                        }
                        if (from == "Cm" && to == "Pies")
                        {
                            dato = Cantidad / 30.48;

                        }
                        if (from == "Cm" && to == "KMS")
                        {
                            dato = Cantidad / 100000;

                        }
                        if (from == "Cm" && to == "Millas")
                        {
                            dato = Cantidad / 160934;

                        }
                        break;
                    case 2://PULGADA
                        if (from == "Pulg" && to == "Metro")
                        {
                            dato = Cantidad / 39.37;

                        }
                        if (from == "Pulg" && to == "cm")
                        {
                            dato = Cantidad * 2.54;

                        }
                        if (from == "Pulg" && to == "Yardas")
                        {
                            dato = Cantidad / 36;

                        }
                        if (from == "Pulg" && to == "Varas")
                        {
                            dato = Cantidad / 1.430828;

                        }
                        if (from == "Pulg" && to == "Pies")
                        {
                            dato = Cantidad / 12;

                        }
                        if (from == "Pulg" && to == "KMS")
                        {
                            dato = Cantidad / 39370;

                        }
                        if (from == "Pulg" && to == "Millas")
                        {
                            dato = Cantidad / 39370;

                        }
                        break;
                    case 3://YARDA
                        if (from == "Yardas" && to == "Metro")
                        {
                            dato = Cantidad / 1.094;

                        }
                        if (from == "Yardas" && to == "Cm")
                        {
                            dato = Cantidad * 91.44;

                        }
                        if (from == "Yardas" && to == "Pulg")
                        {
                            dato = Cantidad * 36;

                        }
                        if (from == "Yardas" && to == "Vara")
                        {
                            dato = Cantidad * 1.430828;

                        }
                        if (from == "Yardas" && to == "Pies")
                        {
                            dato = Cantidad * 3;

                        }
                        if (from == "Yardas" && to == "KMS")
                        {
                            dato = Cantidad / 1094;

                        }
                        if (from == "Yardas" && to == "Millas")
                        {
                            dato = Cantidad / 1760;

                        }
                        break;
                    case 4://VARA
                        if (from == "Vara" && to == "Metro")
                        {
                            dato = Cantidad / 1.193;

                        }
                        if (from == "Vara" && to == "Cm")
                        {
                            dato = Cantidad / 83.5905;

                        }
                        if (from == "Vara" && to == "Pulg")
                        {
                            dato = Cantidad / 32.9096;

                        }
                        if (from == "Vara" && to == "Yardas")
                        {
                            dato = Cantidad / 0.91415682414698;

                        }
                        if (from == "Vara" && to == "Pies")
                        {
                            dato = Cantidad / 2.7424704724409;

                        }
                        if (from == "Vara" && to == "KMS")
                        {
                            dato = Cantidad / 0.000835905;

                        }
                        if (from == "Vara" && to == "Millas")
                        {
                            dato = Cantidad / 0.00051940728644715;

                        }
                        break;
                    case 5://PIES
                        if (from == "Pies" && to == "Metros")
                        {
                            dato = Cantidad / 3.281;

                        }
                        if (from == "Pies" && to == "Cm")
                        {
                            dato = Cantidad * 30.48;

                        }

                        if (from == "Pies" && to == "Pulg")
                        {
                            dato = Cantidad * 12;

                        }
                        if (from == "Pies" && to == "Yardas")
                        {
                            dato = Cantidad / 3;

                        }
                        if (from == "Pies" && to == "Varas")
                        {
                            dato = Cantidad / 0.364634737201;

                        }
                        if (from == "Pies" && to == "KMS")
                        {
                            dato = Cantidad / 3281;

                        }
                        if (from == "Pies" && to == "Millas")
                        {
                            dato = Cantidad / 5280;

                        }
                        break;
                    case 6://KMS
                        if (from == "KMS" && to == "Metros")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "KMS" && to == "Cm")
                        {
                            dato = Cantidad * 100000;

                        }
                        if (from == "KMS" && to == "Pulg")
                        {
                            dato = Cantidad * 100000;

                        }
                        if (from == "KMS" && to == "Yardas")
                        {
                            dato = Cantidad * 1094;

                        }
                        if (from == "KMS" && to == "Pies")
                        {
                            dato = Cantidad * 3281;

                        }
                        if (from == "KMS" && to == "Varas")
                        {
                            dato = Cantidad / 0.000835905;

                        }
                        if (from == "KMS" && to == "Millas")
                        {
                            dato = Cantidad / 1.609;

                        }
                        break;
                    case 7://MILLAS
                        if (from == "Millas" && to == "Metros")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Cm")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Pulg")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Yardas")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Varas")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "Pies")
                        {
                            dato = Cantidad * 1609;

                        }
                        if (from == "Millas" && to == "KMS")
                        {
                            dato = Cantidad * 1609;

                        }
                        break;
                }

                lblRespLong.Text = "Total: " + dato;
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
            //limpiar txtbox
            txtAlma.Text = "";
            txtmon.Text = "";
            txtlong.Text = "";
            txtTemp.Text = "";
            //limpiar lbl
            lblAlmacenaje.Text = "";
            lblRespMo.Text = "";
            lblRespLong.Text = "";
            lblRespTemp.Text = "";
            try

            {
                string from, to;

                from = cboDePes.SelectedItem.ToString();
                to = cboAPes.SelectedItem.ToString();

                double Cantidad = double.Parse(txtpeso.Text), 
                dato = 0; 
                switch (cboDePes.SelectedIndex)
                {
                    case 0://GRAMOS

                        if (from == "Gramos" && to == "Miligramo")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "Gramos" && to == "Microgramo")
                        {
                            dato = Cantidad * 1e+6;

                        }
                        if (from == "Gramos" && to == "Kilogramos")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Gramos" && to == "Libras")
                        {
                            dato = Cantidad / 454;

                        }
                        if (from == "Gramos" && to == "Onzas")
                        {
                            dato = Cantidad / 28.35;

                        }
                        break;
                    case 1://Miligramos
                        if (from == "Miligramo" && to == "Gramo")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Miligramo" && to == "Microgramo")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "Miligramo" && to == "Kilogramos")
                        {
                            dato = Cantidad / 1e+6;

                        }
                        if (from == "Miligramo" && to == "Libras")
                        {
                            dato = Cantidad / 453592;

                        }
                        if (from == "Miligramo" && to == "Onzas")
                        {
                            dato = Cantidad / 28350;

                        }
                        break;
                    case 2://Microgramos
                        if (from == "Microgramos" && to == "Gramos")
                        {
                            dato = Cantidad / 1e+6;

                        }
                        if (from == "Microgramos" && to == "Miligramo")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Microgramos" && to == "Kilogramos")
                        {
                            dato = Cantidad / 1e+9;

                        }
                        if (from == "Microgramos" && to == "Libras")
                        {
                            dato = Cantidad / 4.536e+8;

                        }
                        if (from == "Microgramos" && to == "Onzas")
                        {
                            dato = Cantidad / 2.835e+7;

                        }
                        break;
                    case 3://KG
                        if (from == "Kilogramos" && to == "Gramos")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "Kilogramos" && to == "Miligramos")
                        {
                            dato = Cantidad * 1e+6;

                        }
                        if (from == "Kilogramos" && to == "Microgramos")
                        {
                            dato = Cantidad * 1e+9 ;

                        }
                        if (from == "Kilogramos" && to == "Libras")
                        {
                            dato = Cantidad * 2.205;

                        }
                        if (from == "Kilogramos" && to == "Onzas")
                        {
                            dato = Cantidad * 35.274;

                        }
                        break;
                    case 4://LIBRA
                        if (from == "Libras" && to == "Gramos")
                        {
                            dato = Cantidad * 454;

                        }
                        if (from == "Libras" && to == "Miligramos")
                        {
                            dato = Cantidad * 453592;

                        }
                        if (from == "Libras" && to == "Microgramos")
                        {
                            dato = Cantidad * 4.536e+8;

                        }
                        if (from == "Libras" && to == "Kilogramos")
                        {
                            dato = Cantidad / 2.205;

                        }
                        if (from == "Libras" && to == "Onzas")
                        {
                            dato = Cantidad * 16;

                        }
                        break;
                    case 5://Onza
                        if (from == "Onzas" && to == "Gramos")
                        {
                            dato = Cantidad * 28.35;

                        }
                        if (from == "Onzas" && to == "Miligramos")
                        {
                            dato = Cantidad * 28350;

                        }
                        if (from == "Onzas" && to == "Microgramos")
                        {
                            dato = Cantidad * 2.835e+7;

                        }
                        if (from == "Onzas" && to == "Kilogramos")
                        {
                            dato = Cantidad / 35.274;

                        }
                        if (from == "Onzas" && to == "Libras")
                        {
                            dato = Cantidad / 16;

                        }
                        break;

                }

                switch (cboAPes.SelectedIndex)
                {
                    case 0://GRAMOS

                        if (from == "Gramos" && to == "Miligramo")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "Gramos" && to == "Microgramo")
                        {
                            dato = Cantidad * 1e+6;

                        }
                        if (from == "Gramos" && to == "Kilogramos")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Gramos" && to == "Libras")
                        {
                            dato = Cantidad / 454;

                        }
                        if (from == "Gramos" && to == "Onzas")
                        {
                            dato = Cantidad / 28.35;

                        }
                        break;
                    case 1://Miligramos
                        if (from == "Miligramo" && to == "Gramo")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Miligramo" && to == "Microgramo")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "Miligramo" && to == "Kilogramos")
                        {
                            dato = Cantidad / 1e+6;

                        }
                        if (from == "Miligramo" && to == "Libras")
                        {
                            dato = Cantidad / 453592;

                        }
                        if (from == "Miligramo" && to == "Onzas")
                        {
                            dato = Cantidad / 28350;

                        }
                        break;
                    case 2://Microgramos
                        if (from == "Microgramos" && to == "Gramos")
                        {
                            dato = Cantidad / 1e+6;

                        }
                        if (from == "Microgramos" && to == "Miligramo")
                        {
                            dato = Cantidad / 1000;

                        }
                        if (from == "Microgramos" && to == "Kilogramos")
                        {
                            dato = Cantidad / 1e+9;

                        }
                        if (from == "Microgramos" && to == "Libras")
                        {
                            dato = Cantidad / 4.536e+8;

                        }
                        if (from == "Microgramos" && to == "Onzas")
                        {
                            dato = Cantidad / 2.835e+7;

                        }
                        break;
                    case 3://KG
                        if (from == "Kilogramos" && to == "Gramos")
                        {
                            dato = Cantidad * 1000;

                        }
                        if (from == "Kilogramos" && to == "Miligramos")
                        {
                            dato = Cantidad * 1e+6;

                        }
                        if (from == "Kilogramos" && to == "Microgramos")
                        {
                            dato = Cantidad * 1e+9;

                        }
                        if (from == "Kilogramos" && to == "Libras")
                        {
                            dato = Cantidad * 2.205;

                        }
                        if (from == "Kilogramos" && to == "Onzas")
                        {
                            dato = Cantidad * 35.274;

                        }
                        break;
                    case 4://LIBRA
                        if (from == "Libras" && to == "Gramos")
                        {
                            dato = Cantidad * 454;

                        }
                        if (from == "Libras" && to == "Miligramos")
                        {
                            dato = Cantidad * 453592;

                        }
                        if (from == "Libras" && to == "Microgramos")
                        {
                            dato = Cantidad * 4.536e+8;

                        }
                        if (from == "Libras" && to == "Kilogramos")
                        {
                            dato = Cantidad / 2.205;

                        }
                        if (from == "Libras" && to == "Onzas")
                        {
                            dato = Cantidad * 16;

                        }
                        break;
                    case 5://Onza
                        if (from == "Onzas" && to == "Gramos")
                        {
                            dato = Cantidad * 28.35;

                        }
                        if (from == "Onzas" && to == "Miligramos")
                        {
                            dato = Cantidad * 28350;

                        }
                        if (from == "Onzas" && to == "Microgramos")
                        {
                            dato = Cantidad * 2.835e+7;

                        }
                        if (from == "Onzas" && to == "Kilogramos")
                        {
                            dato = Cantidad / 35.274;

                        }
                        if (from == "Onzas" && to == "Libras")
                        {
                            dato = Cantidad / 16;

                        }
                        break;
                }

                lblRespPeso.Text = "Total: " + dato;


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
            //limpiar txtbox
            txtAlma.Text = "";
            txtlong.Text = "";
            txtpeso.Text = "";
            txtmon.Text = "";
            //limpiar lbl
            lblAlmacenaje.Text = "";
            lblRespLong.Text = "";
            lblRespPeso.Text = "";
            lblRespMo.Text = "";
            try
            {
                double temp = double.Parse(txtTemp.Text), datotemp = 0;
                string from, to;

                from = cboDeTemp.SelectedItem.ToString();
                to = cboATemp.SelectedItem.ToString();
                switch (cboDeTemp.SelectedIndex)
                {

                    case 0://C
                        if (from == "Celcius" && to == "Farenheit")
                        {
                            datotemp = (temp * 9/5)+32;

                        }
                        if (from == "Celcius" && to == "Kelvin")
                        {
                            datotemp = temp +273.15;

                        }

                        break;
                    case 1://F
                        if (from == "Farenheit" && to == "Celcius")
                        {
                            datotemp = (temp -32)*5/9;

                        }
                        if (from == "Farenheit" && to == "Kelvin")
                        {
                            datotemp = (temp - 32) * 5 / 9 + 273.15;

                        }


                        break;
                    case 2://K
                        if (from == "Kelvin" && to == "Celcius")
                        {
                            datotemp = temp -  273.15;

                        }
                        if (from == "Kelvin" && to == "Farenheit")
                        {
                            datotemp = (temp - 273.15)*9/5+32;

                        }


                        break;


                }

                switch (cboATemp.SelectedIndex)
                {
                    case 0://C
                        if (from == "Celcius" && to == "Farenheit")
                        {
                            datotemp = (temp * 9 / 5) + 32;

                        }
                        if (from == "Celcius" && to == "Kelvin")
                        {
                            datotemp = temp + 273.15;

                        }

                        break;
                    case 1://F
                        if (from == "Farenheit" && to == "Celcius")
                        {
                            datotemp = (temp - 32) * 5 / 9;

                        }
                        if (from == "Farenheit" && to == "Kelvin")
                        {
                            datotemp = (temp - 32) * 5 / 9 + 273.15;

                        }


                        break;
                    case 2://K
                        if (from == "Kelvin" && to == "Celcius")
                        {
                            datotemp = temp - 273.15;

                        }
                        if (from == "Kelvin" && to == "Farenheit")
                        {
                            datotemp = (temp - 273.15) * 9 / 5 + 32;

                        }


                        break;
                }
                lblRespTemp.Text = "Temp: " + datotemp + "\n";

            }



            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor temperatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //Almacenaje
        private void BtnAlmacenaje_Click(object sender, EventArgs e)
        {
            //limpiar txtbox
            txtmon.Text = "";
            txtlong.Text = "";
            txtpeso.Text = "";
            txtTemp.Text = "";
            //limpiar lbl
            lblRespMo.Text = "";
            lblRespLong.Text = "";
            lblRespPeso.Text = "";
            lblRespTemp.Text = "";
            try
            {
                double Alma = double.Parse(txtAlma.Text), datoAlma = 0;
                string from, to;

                from = cboDeAlma.SelectedItem.ToString();
                to = cboAAlma.SelectedItem.ToString();
                switch (cboDeAlma.SelectedIndex)
                {

                    case 0://BIT
                        if (from == "Bit" && to == "Byte")
                        {
                            datoAlma = Alma / 8;

                        }
                        if (from == "Bit" && to == "KB")
                        {
                            datoAlma = Alma / 8000;

                        }
                        if (from == "Bit" && to == "MB")
                        {
                            datoAlma = Alma / 8e+6;

                        }
                        if (from == "Bit" && to == "GB")
                        {
                            datoAlma = Alma / 8e+9;

                        }
                        if (from == "Bit" && to == "TB")
                        {
                            datoAlma = Alma / 8e+12;

                        }
                        if (from == "Bit" && to == "PB")
                        {
                            datoAlma = Alma / 8e+15;

                        }
                     

                       
                        break;
                    case 1://BYTE
                        if (from == "Byte" && to == "Bit")
                        {
                            datoAlma = Alma * 8;

                        }
                        if (from == "Byte" && to == "KB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        if (from == "Byte" && to == "MB")
                        {
                            datoAlma = Alma / 1e+6;

                        }
                        if (from == "Byte" && to == "GB")
                        {
                            datoAlma = Alma / 1e+9;

                        }
                        if (from == "Byte" && to == "TB")
                        {
                            datoAlma = Alma / 1e+12;

                        }
                        if (from == "Byte" && to == "PB")
                        {
                            datoAlma = Alma / 1e+15;

                        }
                        break;
                    case 2://KB
                        if (from == "KB" && to == "Bit")
                        {
                            datoAlma = Alma * 8000;

                        }
                        if (from == "KB" && to == "Byte")
                        {
                            datoAlma = Alma * 1000;

                        }
                        if (from == "KB" && to == "MB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        if (from == "KB" && to == "GB")
                        {
                            datoAlma = Alma / 1e+6;

                        }
                        if (from == "KB" && to == "TB")
                        {
                            datoAlma = Alma / 1e+9;

                        }
                        if (from == "KB" && to == "PB")
                        {
                            datoAlma = Alma / 1e+12;

                        }
                        break;
                    case 3://MB
                        if (from == "MB" && to == "Bit")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "MB" && to == "Byte")
                        {
                            datoAlma = Alma * 125000;

                        }
                        if (from == "MB" && to == "KB")
                        {
                            datoAlma = Alma * 125;

                        }
                        if (from == "MB" && to == "GB")
                        {
                            datoAlma = Alma / 8000;

                        }
                        if (from == "MB" && to == "TB")
                        {
                            datoAlma = Alma / 8e+6;

                        }
                        if (from == "MB" && to == "PB")
                        {
                            datoAlma = Alma / 8e+9;

                        }

                        break;
                    case 4://GB
                        if (from == "GB" && to == "Bit")
                        {
                            datoAlma = Alma * 8e+9;

                        }
                        if (from == "GB" && to == "Byte")
                        {
                            datoAlma = Alma * 1e+9;

                        }
                        if (from == "GB" && to == "KB")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "GB" && to == "MB")
                        {
                            datoAlma = Alma / 8000;

                        }
                        if (from == "GB" && to == "TB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        if (from == "GB" && to == "PB")
                        {
                            datoAlma = Alma / 1e+6;

                        }
                        break;
                    case 5://TB
                        if (from == "TB" && to == "Bit")
                        {
                            datoAlma = Alma * 8e+12;

                        }
                        if (from == "TB" && to == "Byte")
                        {
                            datoAlma = Alma * 1e+12;

                        }
                        if (from == "TB" && to == "KB")
                        {
                            datoAlma = Alma * 1e+9;

                        }
                        if (from == "TB" && to == "MB")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "TB" && to == "GB")
                        {
                            datoAlma = Alma * 1000;

                        }
                        if (from == "TB" && to == "PB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        break;
                    case 6://PB
                        if (from == "PB" && to == "Bit")
                        {
                            datoAlma = Alma * 8e+15;

                        }
                        if (from == "PB" && to == "Byte")
                        {
                            datoAlma = Alma * 1e+15;

                        }
                        if (from == "PB" && to == "KB")
                        {
                            datoAlma = Alma * 1e+12;

                        }
                        if (from == "PB" && to == "MB")
                        {
                            datoAlma = Alma * 1e+9;

                        }
                        if (from == "PB" && to == "GB")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "PB" && to == "TB")
                        {
                            datoAlma = Alma * 1000;

                        }
                        break;
                   



                }

                switch (cboAAlma.SelectedIndex)
                {
                    case 0://BIT
                        if (from == "Bit" && to == "Byte")
                        {
                            datoAlma = Alma / 8;

                        }
                        if (from == "Bit" && to == "KB")
                        {
                            datoAlma = Alma / 8000;

                        }
                        if (from == "Bit" && to == "MB")
                        {
                            datoAlma = Alma / 8e+6;

                        }
                        if (from == "Bit" && to == "GB")
                        {
                            datoAlma = Alma / 8e+9;

                        }
                        if (from == "Bit" && to == "TB")
                        {
                            datoAlma = Alma / 8e+12;

                        }
                        if (from == "Bit" && to == "PB")
                        {
                            datoAlma = Alma / 8e+15;

                        }



                        break;
                    case 1://BYTE
                        if (from == "Byte" && to == "Bit")
                        {
                            datoAlma = Alma * 8;

                        }
                        if (from == "Byte" && to == "KB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        if (from == "Byte" && to == "MB")
                        {
                            datoAlma = Alma / 1e+6;

                        }
                        if (from == "Byte" && to == "GB")
                        {
                            datoAlma = Alma / 1e+9;

                        }
                        if (from == "Byte" && to == "TB")
                        {
                            datoAlma = Alma / 1e+12;

                        }
                        if (from == "Byte" && to == "PB")
                        {
                            datoAlma = Alma / 1e+15;

                        }
                        break;
                    case 2://KB
                        if (from == "KB" && to == "Bit")
                        {
                            datoAlma = Alma * 8000;

                        }
                        if (from == "KB" && to == "Byte")
                        {
                            datoAlma = Alma * 1000;

                        }
                        if (from == "KB" && to == "MB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        if (from == "KB" && to == "GB")
                        {
                            datoAlma = Alma / 1e+6;

                        }
                        if (from == "KB" && to == "TB")
                        {
                            datoAlma = Alma / 1e+9;

                        }
                        if (from == "KB" && to == "PB")
                        {
                            datoAlma = Alma / 1e+12;

                        }
                        break;
                    case 3://MB
                        if (from == "MB" && to == "Bit")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "MB" && to == "Byte")
                        {
                            datoAlma = Alma * 125000;

                        }
                        if (from == "MB" && to == "KB")
                        {
                            datoAlma = Alma * 125;

                        }
                        if (from == "MB" && to == "GB")
                        {
                            datoAlma = Alma / 8000;

                        }
                        if (from == "MB" && to == "TB")
                        {
                            datoAlma = Alma / 8e+6;

                        }
                        if (from == "MB" && to == "PB")
                        {
                            datoAlma = Alma / 8e+9;

                        }

                        break;
                    case 4://GB
                        if (from == "GB" && to == "Bit")
                        {
                            datoAlma = Alma * 8e+9;

                        }
                        if (from == "GB" && to == "Byte")
                        {
                            datoAlma = Alma * 1e+9;

                        }
                        if (from == "GB" && to == "KB")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "GB" && to == "MB")
                        {
                            datoAlma = Alma / 8000;

                        }
                        if (from == "GB" && to == "TB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        if (from == "GB" && to == "PB")
                        {
                            datoAlma = Alma / 1e+6;

                        }
                        break;
                    case 5://TB
                        if (from == "TB" && to == "Bit")
                        {
                            datoAlma = Alma * 8e+12;

                        }
                        if (from == "TB" && to == "Byte")
                        {
                            datoAlma = Alma * 1e+12;

                        }
                        if (from == "TB" && to == "KB")
                        {
                            datoAlma = Alma * 1e+9;

                        }
                        if (from == "TB" && to == "MB")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "TB" && to == "GB")
                        {
                            datoAlma = Alma * 1000;

                        }
                        if (from == "TB" && to == "PB")
                        {
                            datoAlma = Alma / 1000;

                        }
                        break;
                    case 6://PB
                        if (from == "PB" && to == "Bit")
                        {
                            datoAlma = Alma * 8e+15;

                        }
                        if (from == "PB" && to == "Byte")
                        {
                            datoAlma = Alma * 1e+15;

                        }
                        if (from == "PB" && to == "KB")
                        {
                            datoAlma = Alma * 1e+12;

                        }
                        if (from == "PB" && to == "MB")
                        {
                            datoAlma = Alma * 1e+9;

                        }
                        if (from == "PB" && to == "GB")
                        {
                            datoAlma = Alma * 1e+6;

                        }
                        if (from == "PB" && to == "TB")
                        {
                            datoAlma = Alma * 1000;

                        }
                        break;



                }
                lblAlmacenaje.Text = "Total: " + datoAlma + "\n";

            }



            catch (Exception error)
            {
                MessageBox.Show("Por favor ingrese solo numero: " + error.Message, "Conversor temperatura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
    }
}

