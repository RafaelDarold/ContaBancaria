
// Metodo Construtor

public class Conta
{
    private int idAgencia;
    private string numeroConta;
    private string nomeProprietario;
    private double saldo;

    public Conta(int id, string conta, string nomeProp, double saldo)
    {
        idAgencia = id;
        numeroConta = conta;
        nomeProprietario = nomeProp;
        this.saldo = saldo;
    }

    public Conta()
    {

    }
    
    //GET E SET
    public void SetIdAgencia(int idAgencia)
    {
        if(idAgencia > 0)
        {
            this.idAgencia = idAgencia;
        }
        else
        {
            throw new Exception("ID inválido!");
        }
    }
    public int getIdAgencia()
    {
        return this.idAgencia;
    }
    public void SetNumeroConta(string numeroConta)
    {
        if(numeroConta.Length > 0)
        {
            this.numeroConta = numeroConta;
        }
        else
        {
            throw new Exception("Número da Conta inválido");
        }
    }
    public string GetNumeroConta()
    {
        return this.numeroConta;
    }
    public void SetNomeProprietario(string nomeProprietario)
    {
        if(nomeProprietario.Length > 0)
        {
            this.nomeProprietario = nomeProprietario;
        }
        else
        {
            throw new Exception("Nome de proprietario inválido");
        }
    }
    public string GetNomeProprietario()
    {
        return this.nomeProprietario;
    }
    public void SetSaldo(double saldo)
    {
        if (saldo > 0)
        {
            this.saldo = saldo;
        }
        else
        {
            throw new Exception("Valor Inválido!");
        }
    }
    public double GetSaldo()
    {
        return saldo;
    }
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