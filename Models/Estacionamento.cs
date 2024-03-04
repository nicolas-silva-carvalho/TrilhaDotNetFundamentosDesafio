using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial = 0;
        public decimal PrecoPorHora = 0;
        public List<string> Carros = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoPorHora = precoPorHora;
        }

        public void Adicionar()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string carroEstacionamento = Console.ReadLine();

            if (carroEstacionamento != null)
            {
                Carros.Add(carroEstacionamento);
            }
            else 
            {
                Console.WriteLine("Digite uma placa válida!");
            }
            Console.WriteLine("Pressione uma tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public void Remover()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string carroRemover = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            string final = Console.ReadLine();
            decimal precoFinal = PrecoInicial + (PrecoPorHora * Convert.ToInt32(final));
            Console.WriteLine($"O veículo {carroRemover} foi removido e o preço total foi de: {precoFinal} R$.");
            Console.WriteLine("Pressione uma tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            Carros.Remove(carroRemover);
        }

        public void Listar()
        {
            Console.Clear();

            if (Carros.Count > 0)
            {
                System.Console.WriteLine("=== Veículos Cadastrados ====");
                foreach (var item in Carros)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não possui nenhum carro cadastrado no estacionamento.");
                Console.WriteLine("Pressione uma tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}