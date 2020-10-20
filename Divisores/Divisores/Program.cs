using System;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup startup = new Startup();

            using (var scope = startup.ServiceProvider.CreateScope())
            {
                var divisoresService = scope.ServiceProvider.GetRequiredService<DivisoresService>();

                int numero = 5;

                var divisoresPrimos = divisoresService.ListarDivisoresPrimos(numero);

                Console.WriteLine(string.Join(", ", divisoresPrimos));

                var divisores = divisoresService.ListarDivisores(numero);

                Console.WriteLine(string.Join(", ", divisores));
            }
        }
    }
}
