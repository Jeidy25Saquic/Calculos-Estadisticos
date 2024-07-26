using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    public class Numeros
    {


        public static List<double> numeros = new List<double>();
        public void CantidadDeNumeros()
        {
           // List<double> numeros = new List<double>();
            bool continuar = true;
            int cantidad = 0;

            do {
                try
                {
                    Console.WriteLine("Cuantos numeros desea Ingresar");
                    cantidad=Convert.ToInt32(Console.ReadLine());
                   
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
                
            
            
            } while (continuar==true);
            
        }
       

        public void ListaDeNumeros( int cantidad)
      {     
           
            int contador = 0;
            double numero = 0;
           
            do
            {  
                try
                {
                    Console.Write("Ingrese un numero: ");
                    numero= Convert.ToInt32(Console.ReadLine());
                    numeros.Add(numero);
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

    }
}
