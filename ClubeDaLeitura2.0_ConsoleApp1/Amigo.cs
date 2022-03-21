using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Amigo
    {
        public string nomeDoAmigo, nomeDoResponsavel, contatoDoAmigo, enderecoDoAmigo;
        public bool temEmprestimo = false;
        public bool possuiReserva = false;
        public void RegistrarAmigo()
        {
            Console.Clear();
            Console.WriteLine("Registrando novo Amigo...");
            Console.WriteLine();

            Console.WriteLine("Digite o NOME do amigo");
            nomeDoAmigo = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o NOME DO RESPONSÁVEL");
            nomeDoResponsavel = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o CONTATO do amigo");
            contatoDoAmigo = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o ENDEREÇO do amigo");
            enderecoDoAmigo = Console.ReadLine().ToUpper();

        }
        
    }
}
