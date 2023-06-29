using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO03
{
    internal class Menu
    {
        public static void MenuGeral()
        {
            bool loopAplicacao = true;

            while (loopAplicacao)
            {
                Console.Clear();
                Console.WriteLine("-------------- MENU GERAL --------------");
                Console.WriteLine("\n\n1 - Opção 1" + "\n2 - Opção 2" + "\n3 - Opção 3" + "\n4 - Opção 4" + "\n5 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.Clear();

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 4:
                        {
                            Console.Clear();

                            Console.WriteLine("\nAperte ENTER para continuar...");
                            Console.ReadLine();
                            break;
                        }

                    case 5:
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
