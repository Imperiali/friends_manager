using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoa;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Amigos> listaAmigos = new List<Amigos>();           

            bool comecar = true;

            Console.WriteLine("==========================================================");
            Console.WriteLine("                   Aniversariantes! v2.0                  ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("             Bem vindo ao sistema de amigos!              ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            while (comecar)
            {


                var opcaoSelecionada = "";
                var opcoes = new string[] { "1", "2", "3" };

                while (!opcoes.Contains(opcaoSelecionada))
                {
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("                 Escolha uma função !                     ");
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine(" 1 - Verificar amigos");
                    Console.WriteLine(" 2 - Adicionar amigos");
                    Console.WriteLine(" 3 - Sair");
                    Console.WriteLine("==========================================================");

                    opcaoSelecionada = Console.ReadLine();

                }

                switch (opcaoSelecionada)
                {
                    case "1":
                        var nome = "";
                        var esse = "";
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("                   Verificar amigos!                      ");
                        Console.WriteLine("----------------------------------------------------------");

                        if (listaAmigos.Count == 0)
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            Console.WriteLine("                Nenhum amigo encontrado!!                 ");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                            opcaoSelecionada = "2";
                        }
                        else
                        {
                            
                            while (string.IsNullOrWhiteSpace(nome))
                            {

                                Console.WriteLine("Qual o nome do seu amigo??");

                                nome = Console.ReadLine();
                            }

                            var resultados = new List<Amigos>();

                            foreach (Amigos n in listaAmigos)
                            {
                                if (n.NomeCompleto().Contains(nome))
                                {                                                                      
                                    resultados.Add(n);
                                }
                            }

                            if (resultados.Count == 0)
                            {
                                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                Console.WriteLine("Não foram encontrados amigos com esse nome!");
                                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            }
                            else
                            {
                                foreach (var resultado in resultados)
                                {

                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"{resultado.NomeCompleto()}");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                                }

                                while (string.IsNullOrWhiteSpace(esse))
                                {

                                    Console.WriteLine("Qual destes é o que você procura??");

                                    esse = Console.ReadLine();

                                    foreach(var resultado in resultados)
                                    {
                                        if (resultado.NomeCompleto().Contains(esse))
                                        {
                                            Console.WriteLine(resultado.Nome);
                                            Console.WriteLine(resultado.Sobrenome);
                                            Console.WriteLine(resultado.Aniversario.Date);
                                            Console.WriteLine($"Faltam {(int)resultado.ContagemParaAniversario().TotalDays} dias para o aniversário de {resultado.NomeCompleto()}");
                                        }
                                        
                                    }

                                }
                                

                            }


                        }

                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("     Aperte enter para sair      ");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        Console.ReadLine();

                        Console.Clear();
                        break;
                    case "2":
                        var novoNome = "";
                        var novoSobrenome = "";
                        var aniversarioDigitado = "";

                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("                   Adicionar amigos!                      ");
                        Console.WriteLine("----------------------------------------------------------");

                        while (string.IsNullOrWhiteSpace(novoNome))
                        {
                            Console.WriteLine("Qual o nome do seu amigo??");

                            novoNome = Console.ReadLine();
                        }

                        while (string.IsNullOrWhiteSpace(novoSobrenome))
                        {
                            Console.WriteLine("Qual o sobrenome do seu amigo??");

                            novoSobrenome = Console.ReadLine();
                        }

                        while (string.IsNullOrWhiteSpace(aniversarioDigitado))
                        {

                            Console.WriteLine("Quando é o aniversario do seu amigo??[dd/MM/AAAA]");

                            aniversarioDigitado = Console.ReadLine();

                        }

                        DateTime aniversario = Convert.ToDateTime(aniversarioDigitado);
                        
                        Amigos amigo = new Amigos(novoNome, novoSobrenome, aniversario);
                        listaAmigos.Add(amigo);

                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine(" Amigo adicionado com Sucesso!!  ");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("     Aperte enter para sair      ");
                        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                        Console.ReadLine();

                        Console.Clear();
                        break;
                    case "3":
                        comecar = false;
                        break;
                    default:

                        break;
                }
            }
        }        
    }
}
