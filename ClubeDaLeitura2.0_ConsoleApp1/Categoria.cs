using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Categoria
    {
        public string nomeDaCategoria, RevistaCategoria;
        public int quantidadeDeDiasDeEmprestimo;

        public void NovaCategoria()
        {
            Console.Write("Nome da Categoria: ");
            nomeDaCategoria = Console.ReadLine();            
            Console.Write("Dias a ser emprestado");
            int.TryParse(Console.ReadLine(), out quantidadeDeDiasDeEmprestimo);

        }
    }
}
