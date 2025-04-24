using System.Xml;

public class Conta
{
    public int idAgencia;
    public string numeroConta;
    public string nomeProprietario;
    public double saldo;
    public void Depositar(double valorDep)
    {
        if (valorDep <= 0)
        {
            Console.WriteLine("Não é possivel realizar depositos menor que zero");
        }
        else
        {
            saldo += valorDep;

            Console.WriteLine("\nDeposito realizado com sucesso!");
            Console.WriteLine($"Saldo atual: R${saldo}");
        }
    }

    public void Sacar(double valorSaq)
    {
        if(saldo <= 0)
        {
            Console.WriteLine("Saque não permitido, saldo insuficiente!");
        }
        else if(saldo < valorSaq)
        {
            Console.WriteLine("Saque não permitido, saldo insuficiente!");
        }
        else
        {
            saldo -= valorSaq;

            Console.WriteLine("\nSaque realizado com sucesso!");
            Console.WriteLine($"Saldo Atual: R${saldo}");
        }
    }

}