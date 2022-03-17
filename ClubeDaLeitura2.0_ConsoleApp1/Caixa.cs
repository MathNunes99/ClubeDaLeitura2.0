using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Caixa
    {
        public string corDaCaixa, etiquetaDaCaixa, numeroDaCaixa;
        public Revista[] revistas;

        public void NovaCaixa()
        {
            Console.Clear();
            Console.WriteLine("Criando nova caixa...");
            Console.WriteLine();

            Console.WriteLine("Digite a COR da caixa");
            corDaCaixa = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a ETIQUETA da caixa");
            etiquetaDaCaixa = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o NUMERO da caixa");
            numeroDaCaixa = Console.ReadLine().ToUpper();
        }

    }
}
