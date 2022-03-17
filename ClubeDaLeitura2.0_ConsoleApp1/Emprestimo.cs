using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Emprestimo
    {
        public string strDataAbertura,emprestadoAo,revistaEmprestada;
        public void RegistrarEmprestimo()
        {
            Console.Clear();
            Console.WriteLine("Emprestando revista...");
            Console.WriteLine();

            Console.WriteLine("Data do Emprestimo, dd/mm/aaaa");
            strDataAbertura = Console.ReadLine();
            
        }
    }
}
