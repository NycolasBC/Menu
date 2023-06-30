using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_POO03
{
    internal class Campanha
    {
        public int id { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime DataFin { get; set; }
        public Premio Premio { get; set; }
        public List<Vendedor> ListaVendedores { get; set; } = new List<Vendedor>();


        public Campanha CadastrarCampanha()
        {
            Campanha campanha = new Campanha();

            Random random = new Random();
            int novoId = random.Next(1000, 9999);

            campanha.id = novoId;

            Random randomDatas = new Random();

            int intervaloDias = randomDatas.Next(1, 365);

            campanha.DataIni = DateTime.Now;
            DateTime dataFuturaAleatoria = campanha.DataIni.AddDays(intervaloDias);
            campanha.DataFin = dataFuturaAleatoria;

            Console.WriteLine($"\nA data inicial será de: {campanha.DataIni}");
            Console.WriteLine($"E data final será de: {campanha.DataFin}");

            return campanha;
        }

        public Vendedor CadastrarVendedor()
        {
            Vendedor vendedor = new Vendedor();

            Console.Write("\nQual será o CPF do vendedor? ");
            vendedor.CPF = Console.ReadLine();

            Console.Write("\nQual será o nome do vendedor? ");
            vendedor.Nome = Console.ReadLine();

            return vendedor;
        }

        public Premio CadastrarPremio()
        {
            Premio premio = new Premio();

            Random random = new Random();
            int novoId = random.Next(1000, 9999);

            premio.Codigo = novoId;
            Console.WriteLine($"\nO código será: {premio.Codigo}");

            Console.Write("\nQual será a descrição do prêmio? ");
            premio.Descricao = Console.ReadLine();

            return premio;
        }

        public void PrintarVendedores()
        {
            foreach (Vendedor vendedores in ListaVendedores)
            {
                Console.WriteLine($"\nCPF: {vendedores.CPF}");
                Console.WriteLine($"Nome: {vendedores.Nome}");
            }
        }
    }
}
