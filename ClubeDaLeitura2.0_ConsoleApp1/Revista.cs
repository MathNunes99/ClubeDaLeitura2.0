using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Revista
    {
        public string nomeDaRevista, anoDaRevista, tipoDaRevista;
        public bool disponivelParaEmprestimo = true;

        public void RegistrarRevista()
        {
            Console.Clear();
            Console.WriteLine("Registrando Revista...");
            Console.WriteLine();

            Console.WriteLine("Digite o NOME da revista");
            nomeDaRevista = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o ANO da revista");
            anoDaRevista = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o TIPO da revista");
            tipoDaRevista = Console.ReadLine().ToUpper();

            Console.Clear();
        }
    }
}
