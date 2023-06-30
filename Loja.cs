using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO03
{
    internal class Loja
    {
        public static void MenuGeral()
        {
            Campanha campanhaControlador = new Campanha();
            List<Campanha> Listacampanha = new List<Campanha>();

            bool loopAplicacao = true;

            while (loopAplicacao)
            {
                Console.Clear();
                Console.WriteLine("-------------- MENU GERAL --------------");
                Console.WriteLine("\n\n1 - Cadastrar Vendedor" + "\n2 - Cadastrar Prêmio" + "\n3 - Cadastrar Campanha" + "\n4 - Listar Vendedores" + "\n5 - Listar Campanhas" + "\n6 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();
                            if (Listacampanha.Count == 0)
                            {
                                Console.WriteLine("\nCadastre uma campanha primeiro!");
                            }
                            else
                            {
                                Vendedor novoVendedor = campanhaControlador.CadastrarVendedor();

                                Console.Write("\nQual o id da campanha que ele será cadastrado? ");

                                foreach (Campanha campanhas in Listacampanha)
                                {
                                    Console.WriteLine($"\nID: {campanhas.id}");
                                    Console.WriteLine($"Data de inicio: {campanhas.DataIni}");
                                    Console.WriteLine($"Data final: {campanhas.DataFin}");
                                }
                                int idCampanha = Convert.ToInt32(Console.ReadLine());

                                Campanha campanhaEscolhida = Listacampanha.Find(f => f.id == idCampanha);

                                if (campanhaEscolhida != null)
                                {
                                    campanhaEscolhida.ListaVendedores.Add(novoVendedor);
                                }
                                else
                                {
                                    Console.WriteLine("\nEssa campanha não existe");
                                }
                            }
                                             
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            if (Listacampanha.Count == 0)
                            {
                                Console.WriteLine("\nCadastre uma campanha primeiro!");
                            }
                            else
                            {
                                Premio novoPremio = campanhaControlador.CadastrarPremio();

                                Console.Write("\nQual o id da campanha que ele será cadastrado? ");

                                foreach (Campanha campanhas in Listacampanha)
                                {
                                    Console.WriteLine($"\nID: {campanhas.id}");
                                    Console.WriteLine($"Data de inicio: {campanhas.DataIni}");
                                    Console.WriteLine($"Data final: {campanhas.DataFin}");
                                }
                                int idCampanha = Convert.ToInt32(Console.ReadLine());

                                Campanha campanhaEscolhida = Listacampanha.Find(f => f.id == idCampanha);

                                if (campanhaEscolhida != null)
                                {
                                    campanhaEscolhida.Premio = novoPremio;
                                }
                                else
                                {
                                    Console.WriteLine("\nEssa campanha não existe");
                                }
                            }

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Campanha novaCampanha = campanhaControlador.CadastrarCampanha();

                            Listacampanha.Add(novaCampanha);
                            Console.WriteLine("\nCampanha cadastrada com sucesso :)");

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();                     
                            if (Listacampanha.Count == 0)
                            {
                                Console.WriteLine("\nCadastre uma campanha primeiro!");
                            }
                            else
                            {
                                Console.Write("\nQual o id da campanha que será mostrado os vendedores? ");

                                foreach (Campanha campanhas in Listacampanha)
                                {
                                    Console.WriteLine($"\nID: {campanhas.id}");
                                    Console.WriteLine($"Data de inicio: {campanhas.DataIni}");
                                    Console.WriteLine($"Data final: {campanhas.DataFin}");
                                }
                                int idCampanha = Convert.ToInt32(Console.ReadLine());

                                Campanha campanhaEscolhida = Listacampanha.Find(f => f.id == idCampanha);

                                if (campanhaEscolhida != null)
                                {
                                    campanhaEscolhida.PrintarVendedores();
                                }
                                else
                                {
                                    Console.WriteLine("\nEssa campanha não existe");
                                }
                            }
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 5:
                        {
                            Console.Clear();
                            if (Listacampanha.Count == 0)
                            {
                                Console.WriteLine("\nCadastre uma campanha primeiro!");
                            }
                            else
                            {
                                foreach (Campanha campanhas in Listacampanha)
                                {
                                    Console.WriteLine($"\nID: {campanhas.id}");
                                    Console.WriteLine($"Data de inicio: {campanhas.DataIni}");
                                    Console.WriteLine($"Data final: {campanhas.DataFin}");
                                }
                            }
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 6:
                        {
                            loopAplicacao = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nValor inválido!");
                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }
                }
            }

            Console.WriteLine("\nFim da aplicação! :)");
        }
    }
}
