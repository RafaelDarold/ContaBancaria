try
{
    Console.WriteLine("---Banco Darold---\n");

    List<Conta> listaContaBanc = new List<Conta>();

    while (true)
    {
        Console.ReadKey();
        Console.Clear();
        Console.Write("1 para cadastrar uma nova CONTA:\n2 para LISTAR as contas:\n3 para realizar Operações Bancarias:\n4 para Cadastrar Funcionario\n5 para SAIR:\n\nOpção:");
        int op = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();

        if (op == 1)
        {
            Conta conta = new Conta();

            Console.WriteLine("Cadastre sua Conta");
            Console.Write("Informe o ID da conta: ");
            conta.SetIdAgencia(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Informe o número da conta: ");
            conta.SetNumeroConta(Console.ReadLine());

            Console.WriteLine("Informe o nome do proprietario da conta: ");
            conta.SetNomeProprietario(Console.ReadLine());


            listaContaBanc.Add(conta);

            Console.WriteLine("CONTA CADASTRADA COM SUCESSO!");
        }
        else if (op == 2)
        {
            foreach (Conta cont in listaContaBanc)
            {
                Console.WriteLine($"ID: {cont.getIdAgencia} - Nº CONTA: {cont.GetNumeroConta} " +
                    $"- NOME: {cont.GetNomeProprietario} - SALDO: {cont.GetSaldo().ToString("C2")}");
            }
        }
        else if (op == 3)
        {
            Console.Write("Informe o numero da sua conta:");
            Conta conta = listaContaBanc.Find(conta => conta.getIdAgencia() == Convert.ToInt32(Console.ReadLine()));
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
            Funcionario func = new Funcionario();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cadastrar Funcionario");
            Console.Write("Informe o ID do Funcionario: ");
            func.SetIdFuncionario(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Informe o nome do Funcionario: ");
            func.SetNomeFuncionario(Console.ReadLine());
            Console.Write("Informe o CPF do Funcionario: ");
            func.SetCpf(Console.ReadLine());
            Console.Write("Informe a data de nascimento do Funcionario: ");
            func.SetDataNascimentoFunc(Convert.ToDateTime(Console.ReadLine()));
            Console.Write("Informe o e-mail do Funcionario: ");
            func.SetEmailFuncionario(Console.ReadLine());
            Console.Write("Informe a data de admissão do Funcionario: ");
            func.SetDataAdmissaoFunc(Convert.ToDateTime(Console.ReadLine()));
            Console.Write("Informe o sálario do Funcionario: ");
            func.SetSalarioFunc(Convert.ToDouble(Console.ReadLine()));


        }
        else if (op == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Opção invalida!");
        }

    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}finally { Console.ReadLine(); }