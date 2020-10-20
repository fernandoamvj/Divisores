using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class DivisoresService
    {
        public List<int> ListarDivisores(int numero)
        {
            var divisores = new List<int>();

            int max = (int)Math.Sqrt(numero);

            for (int divisor = 1; divisor <= max; ++divisor)
            {
                if (numero % divisor == 0)
                {
                    divisores.Add(divisor);
                    if (divisor != numero / divisor)
                    {
                        divisores.Add(numero / divisor);
                    }
                }
            }

            return divisores.OrderBy(i => i).ToList();
        }

        public IEnumerable<int> ListarDivisoresPrimos(int numero)
        {
            var numerosPrimos = this.ListarNumerosPrimos(numero + 1).ToList();

            foreach (var numeroPrimo in numerosPrimos)
            {
                if (numero % numeroPrimo == 0)
                {
                    yield return numeroPrimo;
                }
            }
        }

        private IEnumerable<int> ListarNumerosPrimos(int numero)
        {
            //O algoritmo utilizado para encontrar os primos eu implementei com base no algoritmo: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
            BitArray riscados = new BitArray(numero);

            int raiz = (int)Math.Sqrt(numero);

            for (int p = 2; p <= raiz; ++p)
            {
                if (riscados[p])
                {
                    continue;
                }

                yield return p;

                //Todos os multiplos do primo menor que o numero serão riscados ou seja não são primos
                for (int i = p * p; i < numero; i += p)
                    riscados[i] = true;
            }
            //Os números que não foram riscados logo são primos 
            for (int p = raiz + 1; p < numero; ++p)
            {
                if (!riscados[p]) yield return p;
            }
        }
    }
}
