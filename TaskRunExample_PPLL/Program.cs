using System;
using System.Threading.Tasks;

namespace Task_Run
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Tarea iniciada.");

            // ask.Run para ejecutar un cálculo con números grandes
            long result = await Task.Run(() =>
            {
                long sum = 0;
                Console.WriteLine($"Iniciando cálculo en un hilo separado...");
                for (long i = 0; i < 1_000_000; i++) 
                {
                    sum += i * 2;
                }
                Console.WriteLine($"Cálculo finalizado en el hilo secundario.");
                return sum; // Retorno el resultado del hilo principal
            });

            // Resultado en el hilo principal
            Console.WriteLine($"La suma total calculada es: {result}");
            Console.WriteLine("Tarea completada.");
        }
    }
}
