using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura2._0_ConsoleApp1
{
    internal class Menu
    {

        Caixa[] caixas = new Caixa[10];
        Amigo[] amigos = new Amigo[100];
        Emprestimo[] listaDeEmprestimos = new Emprestimo[100];
        Reserva[] reservas = new Reserva[100];
        Categoria[] categorias = new Categoria[100];
        public int contadorDaReserva = 0;
        public int contadorDaLista = 0;
        public int contadorCategoria = 0;
        static DateTime[] dataDeAberturaDoChamado = new DateTime[100];
        static DateTime[] tempoDeReserva = new DateTime[100];
        public void MenuInicial()
        {
            string opcao = "";
            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("Clube da leitura");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para Acessar Revistas");
                Console.WriteLine("Digite 2 para Acessar Caixas");
                Console.WriteLine("Digite 3 para Acessar Amigos");
                Console.WriteLine("Digite 4 para Emprestar Revista");
                Console.WriteLine("Digite 5 para Ver Emprestimos");
                Console.WriteLine("Digite 6 para Devolver a revista");
                Console.WriteLine("Digite 7 para Reservar uma revista");
                Console.WriteLine("Digite 8 para ver Reservas");
                Console.WriteLine();
                Console.WriteLine("Digite 0 para ENCERRAR o programa");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuRevista();
                        break;
                    case "2":
                        MenuCaixa();
                        break;
                    case "3":
                        MenuAmigos();
                        break;
                    case "4":
                        EmprestarRevista();
                        break;
                    case "5":
                        VerEmprestimos();
                        break;
                    case "6":
                        DevolverRevista();
                        break;
                    case "7":
                        ReservarRevista();
                        break;
                    case "8":
                        VerReservas();
                        break;
                }
                
            }

        }
        //metodo revista
        public void MenuRevista()
        {
            string opcao = "";
            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("Menu Revista");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para Cadastrar uma Revista");
                Console.WriteLine();
                Console.WriteLine("Digite 0 para SAIR do Menu");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":                        
                        RegistrarRevistaNaCaixa();
                        break;                    

                }
            }
        }
        public void RegistrarRevistaNaCaixa()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (caixas[i] != null)
                {
                    Console.WriteLine("Digite " + i + " - Caixa " + caixas[i].corDaCaixa + " - " + caixas[i].etiquetaDaCaixa);
                    Console.WriteLine();                    

                }
                else
                {                    
                    break;
                }
            }
            Console.WriteLine("Digite a caixa que deseja armazenar a revista");
            Console.WriteLine();
            Console.Write("opcao: ");
            
            int.TryParse(Console.ReadLine(), out int opcao);

            if (caixas[opcao] != null)
            {
                Revista revista = new Revista();
                Console.Clear();
                Console.WriteLine("Essa revista é novidade?");
                Console.WriteLine("escreva 'sim' se for novidade");

                string opcaoNovidade = Console.ReadLine();
                if (opcaoNovidade == "sim")
                {
                    revista.ehNovidade = true;
                }
                revista.RegistrarRevista();
                Console.Clear();
                
                Categoria categoria = new Categoria();
                categoria.NovaCategoria();
                if (revista.ehNovidade == true && categoria.quantidadeDeDiasDeEmprestimo > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Revistas que são novidades não podem ser emprestadas por mais de 3 dias");
                    Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (caixas[opcao].revistas[i] == null)
                        {
                            caixas[opcao].revistas[i] = revista;
                            categorias[contadorCategoria] = categoria;
                            break;
                        }
                    }
                }
                             
            }            
        }
        //metodo caixa
        public void MenuCaixa()
        {
            string opcao = "";
            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("Menu Caixa");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para Cadastrar uma nova Caixa");
                Console.WriteLine();
                Console.WriteLine("Digite 0 para SAIR do Menu");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarCaixa();
                        break;

                }
            }
        }
        public void RegistrarCaixa()
        {
            Caixa caixa = new Caixa();
            caixa.NovaCaixa();
            caixa.revistas = new Revista[10];
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                {
                    caixas[i] = caixa;
                    break;
                }
            }
        }
        //metodo amigos
        public void MenuAmigos()
        {
            string opcao = "";
            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("Menu Amigos");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para Cadastrar um novo Amigo");
                Console.WriteLine();
                Console.WriteLine("Digite 0 para SAIR do Menu");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarAmigo();
                        break;

                }
            }
        }
        public void RegistrarAmigo()
        {
            Amigo amigo = new Amigo();
            amigo.RegistrarAmigo();

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                {
                    amigos[i] = amigo;
                    break;
                }
            }
        }
        //metodo Emprestimo
        public void EmprestarRevista()
        {
            Console.Clear();
            Console.WriteLine("Lista de amigos");
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine(i + " - " + amigos[i].nomeDoAmigo + " - Possui emprestimo: " + amigos[i].temEmprestimo);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Qual amigo deseja emprestimo: ");
            int.TryParse(Console.ReadLine(), out int opcaoAmigo);
            Console.Clear();
            //Escolher Caixa
            if (amigos[opcaoAmigo].temEmprestimo == true)
            {
                Console.WriteLine(amigos[opcaoAmigo].nomeDoAmigo + " Já possui um emprestimo: ");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                for (int i = 0; i < caixas.Length; i++)
                {
                    if (caixas[i] != null)
                    {
                        Console.WriteLine(i + " - Caixa de: " + caixas[i].etiquetaDaCaixa);
                        Console.WriteLine();
                        for (int j = 0; j < caixas[i].revistas.Length; j++)
                        {
                            if (caixas[i].revistas[j] != null)
                            {
                                Console.WriteLine(caixas[i].revistas[j].nomeDaRevista);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    else
                    {
                        break;
                    }
                    
                }
                Console.WriteLine();
                Console.Write("Escolha a Caixa que deseja acessar: ");
                int.TryParse(Console.ReadLine(), out int opcaoCaixa);

                Console.Clear();
                //Escolher Revista
                Console.WriteLine(caixas[opcaoCaixa].etiquetaDaCaixa);
                Console.WriteLine();

                for (int j = 0; j < caixas[opcaoCaixa].revistas.Length; j++)
                {
                    if (caixas[opcaoCaixa].revistas[j] != null)
                    {
                        Console.WriteLine(j + " - "+ caixas[opcaoCaixa].revistas[j].nomeDaRevista);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.Write("Digite o numero da revista: ");
                int.TryParse(Console.ReadLine(), out int opcaoRevista);

                int contadorTeste = 0;
                while(amigos[opcaoAmigo].nomeDoAmigo != reservas[contadorTeste].reservadaAo)
                {
                    contadorTeste++;
                    if (contadorTeste > reservas.Length)
                    {
                        break;
                    }
                    else if (amigos[opcaoAmigo].nomeDoAmigo != reservas[contadorTeste].reservadaAo)
                    {
                        caixas[opcaoCaixa].revistas[opcaoRevista].possuiReserva = false;
                        break;
                    }
                }
                if (caixas[opcaoCaixa].revistas[opcaoRevista].disponivelParaEmprestimo == false || caixas[opcaoCaixa].revistas[opcaoRevista].possuiReserva == true)
                {
                    Console.Clear();
                    Console.WriteLine("Revista não está Disponivel no momento");
                    Console.ReadLine();
                }
                else
                {
                    caixas[opcaoCaixa].revistas[opcaoRevista].disponivelParaEmprestimo = false;
                    amigos[opcaoAmigo].temEmprestimo = true;
                    Emprestimo emprestimo = new Emprestimo();
                    emprestimo.RegistrarEmprestimo();
                    listaDeEmprestimos[contadorDaLista] = emprestimo;
                    listaDeEmprestimos[contadorDaLista].emprestadoAo = amigos[opcaoAmigo].nomeDoAmigo;
                    listaDeEmprestimos[contadorDaLista].revistaEmprestada = caixas[opcaoCaixa].revistas[opcaoRevista].nomeDaRevista;
                    dataDeAberturaDoChamado[contadorDaLista] = Convert.ToDateTime(listaDeEmprestimos[contadorDaLista].strDataAbertura);
                    contadorDaLista++;
                }
            }            
        }
        public void VerEmprestimos()
        {
            Console.Clear();
            for (int j = 0; j < amigos.Length; j++)
            {
                if (amigos[j] != null)
                {
                    Console.WriteLine(amigos[j].nomeDoAmigo + " - Possui emprestimo: " + amigos[j].temEmprestimo);                    
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < listaDeEmprestimos.Length; i++)
            {
                                                
                if (listaDeEmprestimos[i] != null)
                {
                    TimeSpan diferenca = DateTime.Today - dataDeAberturaDoChamado[i];
                    double dias = diferenca.TotalDays;
                    Console.WriteLine(listaDeEmprestimos[i].revistaEmprestada + " Emprestada ao " + listaDeEmprestimos[i].emprestadoAo + " fazem " + dias + " dias.");
                }
                else
                {
                    break;
                }
                
            }
            Console.ReadLine();
            
        }
        public void DevolverRevista()
        {
            Console.Clear();
            Console.WriteLine("Lista de amigos");
            
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null && amigos[i].temEmprestimo == true)
                {
                    Console.WriteLine(i + " - " + amigos[i].nomeDoAmigo + " - Possui emprestimo: " + amigos[i].temEmprestimo);
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine();
            Console.Write("Qual amigo deseja devolver: ");
            int.TryParse(Console.ReadLine(), out int opcaoAmigo);            

            Console.Clear();
            //Escolher Caixa


            Console.Clear();
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] != null)
                {
                    Console.WriteLine(i + " - Caixa de: " + caixas[i].etiquetaDaCaixa);
                    Console.WriteLine();
                    for (int j = 0; j < caixas[i].revistas.Length; j++)
                    {
                        if (caixas[i].revistas[j] != null)
                        {
                            Console.WriteLine(caixas[i].revistas[j].nomeDaRevista);
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine();
            Console.Write("Escolha a Caixa que deseja acessar: ");
            int.TryParse(Console.ReadLine(), out int opcaoCaixa);

            Console.Clear();
            //Escolher Revista
            if (caixas[opcaoCaixa] != null)
            {
                Console.WriteLine(caixas[opcaoCaixa].etiquetaDaCaixa);
                Console.WriteLine();

                for (int j = 0; j < caixas[opcaoCaixa].revistas.Length; j++)
                {
                    if (caixas[opcaoCaixa].revistas[j] != null)
                    {
                        Console.WriteLine(j + " - " + caixas[opcaoCaixa].revistas[j].nomeDaRevista);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.Write("Digite o numero da revista a ser devolvida: ");
                int.TryParse(Console.ReadLine(), out int opcaoRevista);

                if (caixas[opcaoCaixa].revistas[opcaoRevista].disponivelParaEmprestimo == true)
                {
                    Console.Clear();
                    Console.WriteLine("Revista ja consta como disponivel");
                    Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < tempoDeReserva.Length; i++)
                    {
                        if (categorias[i].RevistaCategoria == caixas[opcaoCaixa].revistas[opcaoRevista].nomeDaRevista)
                        {
                            TimeSpan diferenca = DateTime.Today - dataDeAberturaDoChamado[i];
                            double dias = diferenca.TotalDays;

                            if (dias > categorias[i].quantidadeDeDiasDeEmprestimo)
                            {
                                Console.WriteLine("Revista devolvida com atraso, cobrar MULTA");
                                Console.ReadLine();
                                break;
                            }
                        }
                    }
                    

                    caixas[opcaoCaixa].revistas[opcaoRevista].disponivelParaEmprestimo = true;
                    amigos[opcaoAmigo].temEmprestimo = false;
                }
            }
            


        }
        //metodo reserva
        public void ReservarRevista()
        {
            Console.Clear();
            Console.WriteLine("Lista de amigos");
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine(i + " - " + amigos[i].nomeDoAmigo + " - Possui reserva: " + amigos[i].possuiReserva);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Qual amigo deseja reservar: ");
            int.TryParse(Console.ReadLine(), out int opcaoAmigo);
            Console.Clear();
            //Escolher Caixa
            if (amigos[opcaoAmigo].possuiReserva == true)
            {
                Console.WriteLine(amigos[opcaoAmigo].nomeDoAmigo + " Já possui uma reserva: ");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                for (int i = 0; i < caixas.Length; i++)
                {
                    if (caixas[i] != null)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(i + " - Caixa de: " + caixas[i].etiquetaDaCaixa);
                        Console.WriteLine("------------------------------------------");
                        for (int j = 0; j < caixas[i].revistas.Length; j++)
                        {
                            if (caixas[i].revistas[j] != null)
                            {
                                Console.WriteLine(caixas[i].revistas[j].nomeDaRevista);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    else
                    {
                        break;
                    }

                }
                Console.WriteLine("------------------------------------");
                Console.Write("Escolha a Caixa que deseja acessar: ");
                int.TryParse(Console.ReadLine(), out int opcaoCaixa);

                Console.Clear();
                //Escolher Revista
                Console.WriteLine(caixas[opcaoCaixa].etiquetaDaCaixa);
                Console.WriteLine("---------------------------------");

                for (int j = 0; j < caixas[opcaoCaixa].revistas.Length; j++)
                {
                    if (caixas[opcaoCaixa].revistas[j] != null)
                    {
                        Console.WriteLine(j + " - " + caixas[opcaoCaixa].revistas[j].nomeDaRevista);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("----------------------------");
                Console.Write("Digite o numero da revista: ");
                int.TryParse(Console.ReadLine(), out int opcaoRevista);

                
                if (caixas[opcaoCaixa].revistas[opcaoRevista].possuiReserva == true)
                {
                    Console.Clear();
                    Console.WriteLine("Revista reservada");
                    Console.ReadLine();
                }
                else
                {
                    caixas[opcaoCaixa].revistas[opcaoRevista].possuiReserva = true;
                    amigos[opcaoAmigo].possuiReserva = true;
                    Reserva reserva = new Reserva();
                    reserva.RegistrarReservas();
                    reservas[contadorDaReserva] = reserva;
                    reservas[contadorDaReserva].reservadaAo = amigos[opcaoAmigo].nomeDoAmigo;
                    reservas[contadorDaReserva].revistaReservada = caixas[opcaoCaixa].revistas[opcaoRevista].nomeDaRevista;
                    tempoDeReserva[contadorDaReserva] = Convert.ToDateTime(reservas[contadorDaReserva].strDataDaReserva);
                    contadorDaReserva++;
                }
            }
        }
        public void VerReservas()
        {
            Console.Clear();
            for (int i = 0; i < caixas.Length; i++)
            {                
                if(reservas[i] != null)
                {
                    Console.WriteLine(reservas[i].revistaReservada + " Reservada para: " + reservas[i].reservadaAo);
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Deseja realizar o emprestimo de alguma revista?");
            Console.WriteLine("Escreva 'sim' para realizar o emprestimo");
            string opcao = Console.ReadLine();
            if (opcao == "sim")
            {
                EmprestarRevista();
            }

        }
        //metodo categoria
        
    }
}
