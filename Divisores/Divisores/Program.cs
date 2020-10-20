using Microsoft.Extensions.DependencyInjection;
using System;
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

                Console.WriteLine("Digite um número inteiro(natural):");

                string entradaUsuario = Console.ReadLine();

                int numero;
                bool numeroValido = int.TryParse(entradaUsuario, out numero);

                if (numeroValido && numero >= 0)
                {
                    var divisoresPrimos = divisoresService.ListarDivisoresPrimos(numero);

                    Console.WriteLine("Divisores Primos:");
                    Console.WriteLine(string.Join(", ", divisoresPrimos));

                    var divisores = divisoresService.ListarDivisores(numero);

                    Console.WriteLine("Divisores:");
                    Console.WriteLine(string.Join(", ", divisores));
                }
                else
                {
                    Console.WriteLine("Número inválido ou menor que 0");
                }
            }
        }
    }
}
