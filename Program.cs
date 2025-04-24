

using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("---Banco Darold---\n");

List<Conta> listaContaBanc = new List<Conta>();

while (true)
{
    Console.ReadKey();
    Console.Clear();
    Console.Write("1 para cadastrar uma nova CONTA:\n2 para LISTAR as contas:\n3 realizar Operações Bancarias:\n4 para SAIR:\n\nOpção:");
    int op = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    if (op == 1)
    {
        Conta conta = new Conta();

        Console.WriteLine("Cadastre sua Conta");
        Console.Write("Informe o ID da conta: ");
        conta.idAgencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o número da conta: ");
        conta.numeroConta = Console.ReadLine();

        Console.WriteLine("Informe o nome do proprietario da conta: ");
        conta.nomeProprietario = Console.ReadLine();


        listaContaBanc.Add(conta);

        Console.WriteLine("CONTA CADASTRADA COM SUCESSO!");
    }
    else if (op == 2)
    {
        foreach (Conta cont in listaContaBanc)
        {
            Console.WriteLine($"ID: {cont.idAgencia} - Nº CONTA: {cont.numeroConta} " +
                $"- NOME: {cont.nomeProprietario} - SALDO: {cont.saldo.ToString("C2")}");
        }
    }
    else if (op == 3)
    {
        Console.Write("Informe o numero da sua conta:");
        Conta conta = listaContaBanc.Find(conta => conta.idAgencia == Convert.ToInt32(Console.ReadLine()));
        if (conta != null)
        {

            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                Console.Write("Digite 1 para DEPOSITAR, 2 para SACAR ou 3 para SAIR: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (op == 1)
                {
                    Console.Write("Informe o valor que deseja depositar:");
                    conta.Depositar(Convert.ToDouble(Console.ReadLine()));
                }
                else if (op == 2)
                {
                    Console.WriteLine("Realizar saque.");
                    Console.Write("Informe o valor que deseja sacar");
                    conta.Sacar(Convert.ToDouble(Console.ReadLine()));
                }
                else if (op == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }
            }
        }
    }
    else if (op == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção invalida!");
    }
    
}