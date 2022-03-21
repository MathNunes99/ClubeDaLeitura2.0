using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Reserva
    {
        public string strDataDaReserva,reservadaAo,revistaReservada;

        public void RegistrarReservas()
        {
            double dias = 3;
            while (dias > 3 || dias < 0)
            {
                Console.Clear();
                Console.WriteLine("Reservando revista...");
                Console.WriteLine();

                Console.WriteLine("Reservar para o dia, dd/mm/aaaa");
                strDataDaReserva = Console.ReadLine();
                TimeSpan diferenca = Convert.ToDateTime(strDataDaReserva) - DateTime.Today;
                dias = diferenca.TotalDays;
                if (dias > 3 || dias < 0)
                {
                    Console.WriteLine("Reserve a revista num prazo maximo de 2 dias");
                    Console.ReadLine();
                }
            }
            
            
        }
    }
}
