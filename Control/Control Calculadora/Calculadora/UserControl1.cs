using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            txtRes.ReadOnly = true;

           

        }
        /// <summary>
        /// Propiedades que utilizo en el proyecto metodos
        /// </summary>
        public String num1 { get { return txtNum1.Text; } set { txtNum1.Text = value; } }
        public String num2 { get { return txtNum2.Text; } set { txtNum2.Text = value; } }
        public String res { get { return txtRes.Text; } set { txtRes.Text = value; } }
        private void UserControl1_Load(object sender, EventArgs e)
        {

            validarCampos();

        }
        /// <ValidarCampos>
        /// 
        /// La funcion de este metodo es verificar si la longitud del textbox1 y textbox2 es mayor o igual a 2, 
        /// si cumple con esta condicion  se habilitan los botones btnSuma, btnResta, btnDivicion y btnMultiplicar,
        /// si no cumple la condicion n se habilitan los botones>

        public void validarCampos()
        {
            if(String.IsNullOrEmpty(txtNum1.Text) | String.IsNullOrEmpty(txtNum2.Text))
            {
                OcultarBotones();
            }
            else
            {
                btnDivision.Enabled = true;
                btnMultiplicar.Enabled = true;
                btnResta.Enabled = true;
                btnSuma.Enabled = true;
            }
        }

        /// <OcultarBotones>
        /// 
        /// Este metodo se encarga de desabilitar los botones para que no se puedan seleccionar cuando 
        /// el textbox1 o el textbox2 sea menor de 2 su longitud>

        public void OcultarBotones()
        {
            btnDivision.Enabled = false;
            btnMultiplicar.Enabled = false;
            btnResta.Enabled = false;
            btnSuma.Enabled = false;
        }
        /// <btnSuma>
        /// 
        /// Realiza la suma de los valores que recibe el textbox1 y el textbox2, en este metodo hay 3 variables
        /// enteras y 3 string, la variable num 1 y num2 reciben el valor que se ingreso en los textbox con la propiedad 
        /// .Text, despues a las variables numero1 y numero2 se les asigan el valor de las variables num1 y num2
        /// pero realizando un parseo int para poder sumar los valores,despues a la variable resultado se le 
        /// asigna el valor de la operacion numero1 + numero2, despues a la variable res se le asigna el valor 
        /// de resultado.ToString() para pasarle el valor, despues al textboxRes le mandamos el valor de 
        /// la variable res y por ultimo solo limpiamos el textbox1 y el textbox2>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = txtNum1.Text;
            num2 = txtNum2.Text;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 + numero2;
            res = resultado.ToString();
            txtRes.Text = res;
            txtNum1.Text = "";
            txtNum2.Text = "";
            OcultarBotones();


        }
        /// <btnResta>
        /// 
        /// Realiza la suma de los valores que recibe el textbox1 y el textbox2, en este metodo hay 3 variables
        /// enteras y 3 string, la variable num 1 y num2 reciben el valor que se ingreso en los textbox con la propiedad 
        /// .Text, despues a las variables numero1 y numero2 se les asigan el valor de las variables num1 y num2
        /// pero realizando un parseo int para poder sumar los valores,despues a la variable resultado se le 
        /// asigna el valor de la operacion numero1 - numero2, despues a la variable res se le asigna el valor 
        /// de resultado.ToString() para pasarle el valor, despues al textboxRes le mandamos el valor de 
        /// la variable res y por ultimo solo limpiamos el textbox1 y el textbox2>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnResta_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = txtNum1.Text;
            num2 = txtNum2.Text;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 - numero2;
           res = resultado.ToString();
            txtRes.Text = res;
            txtNum1.Text = "";
            txtNum2.Text = "";
            OcultarBotones();

        }
        /// <btnDivision>
        /// 
        /// Realiza la suma de los valores que recibe el textbox1 y el textbox2, en este metodo hay 3 variables
        /// enteras y 3 string, la variable num 1 y num2 reciben el valor que se ingreso en los textbox con la propiedad 
        /// .Text, despues a las variables numero1 y numero2 se les asigan el valor de las variables num1 y num2
        /// pero realizando un parseo int para poder sumar los valores,despues a la variable resultado se le 
        /// asigna el valor de la operacion numero1 / numero2, despues a la variable res se le asigna el valor 
        /// de resultado.ToString() para pasarle el valor, despues al textboxRes le mandamos el valor de 
        /// la variable res y por ultimo solo limpiamos el textbox1 y el textbox2>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = txtNum1.Text;
            num2 = txtNum2.Text;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 / numero2;
             res = resultado.ToString();
            txtRes.Text = res;
            txtNum1.Text = "";
            txtNum2.Text = "";
            OcultarBotones();
        }
        /// <btnMultiplicar>
        /// 
        /// Realiza la suma de los valores que recibe el textbox1 y el textbox2, en este metodo hay 3 variables
        /// enteras y 3 string, la variable num 1 y num2 reciben el valor que se ingreso en los textbox con la propiedad 
        /// .Text, despues a las variables numero1 y numero2 se les asigan el valor de las variables num1 y num2
        /// pero realizando un parseo int para poder sumar los valores,despues a la variable resultado se le 
        /// asigna el valor de la operacion numero1 * numero2, despues a la variable res se le asigna el valor 
        /// de resultado.ToString() para pasarle el valor, despues al textboxRes le mandamos el valor de 
        /// la variable res y por ultimo solo limpiamos el textbox1 y el textbox2>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = txtNum1.Text;
            num2 = txtNum2.Text;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 * numero2;
             res = resultado.ToString();
            txtRes.Text = res;
            txtNum1.Text = "";
            txtNum2.Text = "";
            OcultarBotones();
        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
           
        }

        /// <txtNum1_KeyPress>
        /// 
        /// Verifica que solo se pueden ingresar digitos al textbox1, ya que si no se ingresa un digito, 
        /// no se muesta en el textbox1>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            validarCampos();
        }
        /// <txtNum2_KeyPress>
        /// 
        /// Verifica que solo se pueden ingresar digitos al textbox2, ya que si no se ingresa un digito, 
        /// no se muesta en el textbox2>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            validarCampos();
        }

        
    }
}
