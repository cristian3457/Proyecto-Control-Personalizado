using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculadora;

namespace Metodos
{/// <summary>
/// NO SUPE COMO LLAMAR LOS METODOS DE ESTA CLASE EN LA CLASE DE USERCONTROL1 PARA UTILIZAR ESTOS METODOS
/// </summary>
    public class Class1
    {
        /// Metodo suma>
        ///  
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
        /// </summary>
        /// <param name="calc"></param>
        public static void suma(UserControl1 calc)
        {

            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = calc.num1;
            num2 = calc.num2;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 + numero2;
            res = resultado.ToString();
            calc.res = res;
            calc.num1= "";
            calc.num2= "";
          
        }
        /// Metodo resta>
        ///  
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
        /// </summary>
        /// <param name="calc"></param>
        public static void resta(UserControl1 calc)
        {

            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = calc.num1;
            num2 = calc.num2;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 - numero2;
            res = resultado.ToString();
            calc.res = res;
            calc.num1 = "";
            calc.num2 = "";

        }
        /// Metodo division>
        ///  
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
        /// </summary>
        /// <param name="calc"></param>
        public static void division(UserControl1 calc)
        {

            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = calc.num1;
            num2 = calc.num2;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 / numero2;
            res = resultado.ToString();
            calc.res = res;
            calc.num1 = "";
            calc.num2 = "";

        }
        /// Metodo multiplicar>
        ///  
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
        /// </summary>
        /// <param name="calc"></param>
        public static void multiplicar(UserControl1 calc)
        {

            int numero1;
            int numero2;
            int resultado;
            String res;
            String num1;
            String num2;
            num1 = calc.num1;
            num2 = calc.num2;
            numero1 = int.Parse(num1);
            numero2 = int.Parse(num2);
            resultado = numero1 * numero2;
            res = resultado.ToString();
            calc.res = res;
            calc.num1 = "";
            calc.num2 = "";

        }
    }
}
