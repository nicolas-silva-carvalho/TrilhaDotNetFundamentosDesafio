Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial:");
string precoInicial;
precoInicial = Console.ReadLine();
int precoInicialHora = Convert.ToInt32(precoInicial);


string precoPorHora;
Console.WriteLine("Digite o preço por hora:");
precoPorHora = Console.ReadLine();
int horaPreco = Convert.ToInt32(precoPorHora);
Console.Clear();

List<string> carros = new List<string>();

string opcao;
bool inicio = true;
while (inicio)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 Encerrar");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo:");
            string carroEstacionamento = Console.ReadLine();
            carros.Add(carroEstacionamento);
            Console.WriteLine("Pressione uma tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            break;

        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            string carroRemover = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            string final = Console.ReadLine();
            int precoFinal = precoInicialHora + (horaPreco * Convert.ToInt32(final));
            Console.WriteLine($"O veículo {carroRemover} foi removido e o preço total foi de: {precoFinal} R$.");
            Console.WriteLine("Pressione uma tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            carros.Remove(carroRemover);
            break;

        case "3":
            if (carros.Count > 0)
            {
                Console.Clear();
                foreach (var item in carros)
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

            break;

        case "4":
            inicio = false;
            Console.WriteLine("Estacionamento encerrado!");
            break;
    }
};