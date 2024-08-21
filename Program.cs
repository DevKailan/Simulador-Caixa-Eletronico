double saldo = 1000.00; // Saldo inicial na conta
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Bem-vindo ao Caixa Eletrônico!");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1- Consultar Saldo");
    Console.WriteLine("2- Sacar");
    Console.WriteLine("3- Depositar");
    Console.WriteLine("4- Sair");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Seu saldo atual é: R$ " + saldo);
            break;

        case "2":
            Console.WriteLine("Digite o valor que deseja sacar:");
            double valorSaque = Convert.ToDouble(Console.ReadLine());

            if (valorSaque <= saldo)
            {
                saldo -= valorSaque;
                Console.WriteLine("Você sacou R$ " + valorSaque + ". Seu novo saldo é: R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            break;

        case "3":
            Console.WriteLine("Digite o valor que deseja depositar:");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());

            if (valorDeposito > 0)
            {
                saldo += valorDeposito;
                Console.WriteLine("Você depositou R$ " + valorDeposito + ". Seu novo saldo é: R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
            break;

        case "4":
            Console.WriteLine("Obrigado por usar o Caixa Eletrônico. Até logo!");
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida, por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine();
}
