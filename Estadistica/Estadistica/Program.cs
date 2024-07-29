class Program
{
    static List<double> Numeros = new List<double>();


    static void Main(string[] args)
    {
        bool continuar = true;
        do
        {

            try
            {
                Numeros.Clear();
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
                        CantidadDeNumeros();
                        Console.WriteLine("El resultado de la media es: " + CalcularMedia());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("------------------------->Mediana<-------------------");
                        CantidadDeNumeros();
                        Console.WriteLine("El resultado de la mediana es: " + CalcularMediana());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("------------------------->Moda<-------------------");
                        CantidadDeNumeros();
                        Console.WriteLine("El resultado de la moda es: " + CalcularModa());
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        Console.WriteLine("------------------------->Desviacion Estandar<-------------------");
                        CantidadDeNumeros();
                        Console.WriteLine("El resultado de la desviasion estandar es: " + CalcularDesviacionEstandar());
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
    // Termina Main
    static void CantidadDeNumeros()
    {

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




    static void ListaDeNumeros(int cantidad)
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

    static double CalcularMedia()
    {

        double suma = 0;
        foreach (var numero in Numeros)
        {
            suma = numero + suma;
        }

        double Media = suma / Numeros.Count;
        return Media;
    }

    static double CalcularMediana()
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

    static double CalcularDesviacionEstandar()
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
    static double CalcularModa()
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












