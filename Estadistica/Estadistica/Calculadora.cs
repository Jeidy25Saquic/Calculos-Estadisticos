using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    public class Calculadora
    {

        public double CalcularMedia(List<double> numeros)
        {

            double suma = 0;
            foreach (var numero in numeros)
            {
                suma = numero + suma;
            }

            double Media = suma / numeros.Count;
            return Media;
        }

        public double CalcularMediana(List<double> numeros)
        {
            // Ordena la lista de números de menor a mayor
            numeros.Sort();

            int cantidadNumeros = numeros.Count;
            double mediana;

            if (cantidadNumeros % 2 == 0)
            {
                // Si la cantidad de números es par
                int indiceMitad1 = cantidadNumeros / (2 - 1);
                int indiceMitad2 = cantidadNumeros / 2;
                mediana = (numeros[indiceMitad1] + numeros[indiceMitad2]) / 2;
            }
            else
            {
                // Si la cantidad de números es impar
                int indiceCentral = cantidadNumeros / 2;
                mediana = numeros[indiceCentral];
            }

            return mediana;


        }

        public double CalcularDesviacionEstandar(List<double> numeros)
        {
            /*Paso 1: calcular la media.
          Paso 2: calcular el cuadrado de la distancia a la media para cada dato.
          Paso 3: sumar los valores que resultaron del paso 2.
          Paso 4: dividir entre el número de datos.
          Paso 5: sacar la raíz cuadrada.*/
            double sumaDiferenciasCuadrados = 0;
            foreach (double numero in numeros)
            {
                double diferencia = numero - CalcularMedia(numeros);
                sumaDiferenciasCuadrados = sumaDiferenciasCuadrados + (diferencia * diferencia);
            }

            // Calcula la desviación estándar
            double DesviacionEstandar = Math.Sqrt(sumaDiferenciasCuadrados / (numeros.Count - 1)); // (n-1)
            return DesviacionEstandar;

        }
        public double CalcularModa(List<double> numeros)
        {
            // Ordenar la lista de números
            numeros.Sort();

            double moda = numeros[0]; // Supongamos que el primer número es la moda inicial
            int maxConteo = 1; // Conteo inicial

            int conteoActual = 1; // Conteo para el número actual
            for (int i = 1; i < numeros.Count; i++)
            {
                if (numeros[i] == numeros[i - 1])
                {
                    // Si el número actual es igual al anterior, incrementar el conteo
                    conteoActual++;
                }
                else
                {
                    // Si no, verificar si es la nueva moda
                    if (conteoActual > maxConteo)
                    {
                        maxConteo = conteoActual;
                        moda = numeros[i - 1];
                    }

                    // Restablecer el conteo para el nuevo número
                    conteoActual = 1;
                }
            }

            // Verificar si el último número es la moda
            if (conteoActual > maxConteo)
            {
                moda = numeros[numeros.Count - 1];
            }


            return moda;


        }
    }
}


       
