using DioFundamentos.Models;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial:");
string precoInicial;
precoInicial = Console.ReadLine();
decimal precoInicialHora = Convert.ToDecimal(precoInicial);


string precoPorHoraTexto;
Console.WriteLine("Digite o preço por hora:");
precoPorHoraTexto = Console.ReadLine();
decimal precoPorHora = Convert.ToDecimal(precoPorHoraTexto);

Estacionamento estacionamento = new Estacionamento(precoInicialHora, precoPorHora);
Console.Clear();

string opcao;
bool inicio = true;
while (inicio)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Encerrar");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            estacionamento.Adicionar();
            break;

        case "2":
            estacionamento.Remover();
            break;

        case "3":
            estacionamento.Listar();
            break;

        case "4":
            inicio = false;
            Console.WriteLine("Estacionamento encerrado!");
            break;
    }
};