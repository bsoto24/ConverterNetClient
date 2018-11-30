using System;
using System.Net;
using Newtonsoft.Json;

namespace netdemo
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Cambio de moneda de euro a sol\n");

            Console.WriteLine("\nIngrese el monto y luego presione Enter.\n");

            double monto = Console.Read();

            Console.WriteLine("El monto en soles es: " + eurosASoles(monto));

        }


        public static double eurosASoles(double cantidad){

            return cantidad*obtenerCambioEuroASol();

        }

        public static double obtenerCambioEuroASol(){

            string url = "http://localhost:8000/currency-exchange/from/EUR/to/PEN";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
            return m.conversionMultiple;

        }

    }

}