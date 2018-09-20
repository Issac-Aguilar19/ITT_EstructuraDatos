using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T05._AguilarZendejasIssacIssai
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long Ope = 0;
                Console.WriteLine("Iniciando operacion...");
                Console.ReadKey();
                for (int i = 1; i < 1000000; i++)
                {
                    Ope += i;
                }
                Stopwatch Tiem = new Stopwatch();
                Tiem.Start();
                Console.WriteLine("El resultado es: {0}", Ope);
                Console.WriteLine("Tiempo de ejecucion de {0} milisegundos", Tiem.Elapsed.TotalMilliseconds.ToString());
                Tiem.Stop();
                Console.ReadKey();

            }
            catch(OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
