using Estadistica;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Banco;
class Program
{

    static void Main(string[] args)
    {
        bool continuar = true;
        List<double> listaNumeros = new List<double>();
        Calculadora calculadora = new Calculadora(listaNumeros);


        do
        {

            try
            {

                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Calcular media");
                Console.WriteLine("2. Calcular mediana");
                Console.WriteLine("3. Calcular moda");
                Console.WriteLine("4. Calcular desviación estándar");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("\n");
                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("------------------------->Media<-------------------");
                        calculadora.CantidadDeNumeros();
                        Console.WriteLine("El resultado de la media es: " + calculadora.CalcularMedia());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("------------------------->Mediana<-------------------");
                        calculadora.CantidadDeNumeros();
                        Console.WriteLine("El resultado de la mediana es: " + calculadora.CalcularMediana());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("------------------------->Moda<-------------------");
                        calculadora.CantidadDeNumeros();
                        Console.WriteLine("El resultado de la moda es: " + calculadora.CalcularModa());
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        Console.WriteLine("------------------------->Desviacion Estandar<-------------------");
                        calculadora.CantidadDeNumeros();
                        Console.WriteLine("El resultado de la desviasion estandar es: " + calculadora.CalcularDesviacionEstandar());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine(" Ha salido, vuelva pronto...");
                        Console.ReadKey();
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");

                        break;
                }

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
}