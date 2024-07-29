using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    public class Calculadora
    {
        public List<double> Numeros { get; set; }

        public Calculadora(List<double> numeros)
        {
            Numeros = numeros;
        }
        public void CantidadDeNumeros()
        {
            // List<double> numeros = new List<double>();
            bool continuar = true;
            int cantidad = 0;

            do
            {
                try
                {
                    Console.WriteLine("Cuantos numeros desea Ingresar");
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    ListaDeNumeros(cantidad);
                    continuar = false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error,intentalo de nuevo...");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }



            } while (continuar == true);

        }


        public void ListaDeNumeros(int cantidad)
        {

            int contador = 0;
            double numero = 0;

            do
            {
                try
                {
                    Console.Write("Ingrese un numero: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    Numeros.Add(numero);
                    contador++;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error,intentalo de nuevo...");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (contador < cantidad);

        }


        public double CalcularMedia()
        {

            double suma = 0;
            foreach (var numero in Numeros)
            {
                suma = numero + suma;
            }

            double Media = suma / Numeros.Count;
            return Media;
        }

        public double CalcularMediana()
        {
            // Ordena la lista de números de menor a mayor
            Numeros.Sort();

            int cantidadNumeros = Numeros.Count;
            double mediana;

            if (cantidadNumeros % 2 == 0)
            {
                // Si la cantidad de números es par
                int indiceMitad1 = cantidadNumeros / (2 - 1);
                int indiceMitad2 = cantidadNumeros / 2;
                mediana = (Numeros[indiceMitad1] + Numeros[indiceMitad2]) / 2;
            }
            else
            {
                // Si la cantidad de números es impar
                int indiceCentral = cantidadNumeros / 2;
                mediana = Numeros[indiceCentral];
            }

            return mediana;


        }

        public double CalcularDesviacionEstandar()
        {
            /*Paso 1: calcular la media.
          Paso 2: calcular el cuadrado de la distancia a la media para cada dato.
          Paso 3: sumar los valores que resultaron del paso 2.
          Paso 4: dividir entre el número de datos.
          Paso 5: sacar la raíz cuadrada.*/
            double sumaDiferenciasCuadrados = 0;
            foreach (double numero in Numeros)
            {
                double diferencia = numero - CalcularMedia();
                sumaDiferenciasCuadrados = sumaDiferenciasCuadrados + (diferencia * diferencia);
            }

            // Calcula la desviación estándar
            double DesviacionEstandar = Math.Sqrt(sumaDiferenciasCuadrados / (Numeros.Count - 1)); // (n-1)
            return DesviacionEstandar;

        }
        public double CalcularModa()
        {
            // Ordenar la lista de números
            Numeros.Sort();

            double moda = Numeros[0];
            int maxConteo = 1; // Conteo inicial

            int conteoActual = 1;
            for (int i = 1; i < Numeros.Count; i++)
            {
                if (Numeros[i] == Numeros[i - 1])
                {
                    // Si el número actual es igual al anterior, incrementar el conteo
                    conteoActual++;
                }
                else
                {
                    // Si no verificar si es la nueva moda
                    if (conteoActual > maxConteo)
                    {
                        maxConteo = conteoActual;
                        moda = Numeros[i - 1];
                    }

                    // Restablecer el conteo 
                    conteoActual = 1;
                }
            }

            // Verificar si el último número es la moda
            if (conteoActual > maxConteo)
            {
                moda = Numeros[Numeros.Count - 1];
            }


            return moda;


        }
    }

}

