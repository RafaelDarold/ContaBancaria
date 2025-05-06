public class Funcionario
{
    private int idFuncionario;
    private string NomeFuncionario;
    private string cpfFuncionario;
    private DateTime dataNascimentoFunc;
    private string emailFuncionario;
    private DateTime dataAdimissaoFunc;
    private double salarioFuncionario;

    public void SetIdFuncionario(int idFuncionario)
    {
        if(idFuncionario > 0)
        {
            this.idFuncionario = idFuncionario;
        }
        else
        {
            throw new Exception("ID inválido");
        }
    }
    public int GetIdFuncionario()
    {
        return idFuncionario;
    }
    public void SetNomeFuncionario(string nome)
    {
        if (nome.Length > 0)
        {
            this.NomeFuncionario = nome;
        }
        else
        {
            throw new Exception("Nome Funcionario inválido");
        }
    }
    public string GetNomeFuncionario()
    {
        return NomeFuncionario;
    }
    public void SetCpf(string cpf)
    {
        if (ValidarCPF(cpf) == true)
        {
            this.cpfFuncionario = cpf;
            Console.WriteLine("CPF informado válido!");
        }
        else
        {
            throw new Exception("CPF informado é inválido");
        }
    }
    public string GetCpf()
    {
        return cpfFuncionario;
    }
    public void SetDataNascimentoFunc(DateTime dataNascimento)
    {
        if(dataNascimento < DateTime.Now)
        {
            this.dataNascimentoFunc = dataNascimento;
        }
        else
        {
            throw new Exception("Data de nascimento não pode ser maior ou igual do dia atual");
        }
    }
    public DateTime GetDataNasimentoFunc()
    {
        return dataNascimentoFunc;
    }
    public void SetEmailFuncionario(string email)
    {
        if (email.Length > 0)
        {
            this.emailFuncionario = email;
        }
        else
        {
            throw new Exception("Email não pode ser nulo");
        }
    }
    public string GetEmailFuncionario()
    {
        return emailFuncionario;
    }
    public void SetDataAdmissaoFunc(DateTime dataAdmissao)
    {
        if( dataAdmissao <= DateTime.Now)
        {
            this.dataAdimissaoFunc = dataAdmissao;
        }
        else
        {
            throw new Exception("Data de admissão não pode ser maior que a data atual");
        }
    }
    public DateTime GetDataAdmissaoFunc()
    {
        return dataAdimissaoFunc;
    }
    public void SetSalarioFunc(double salario)
    {
        if(salario > 0)
        {
            this.salarioFuncionario = salario;
        }
        else
        {
            throw new Exception("Salario informado não é válido");
        }
    }
    public double GetSalarioFunc()
    {
        return salarioFuncionario;
    }
    public bool ValidarCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length == 11)
        {
            int soma = 0;
            int div1 = 10;
            int div2 = 11;
            int restoDiv = 0;
            int digito1 = 0, digito2 = 0;
            int[] numeroCpf = cpf.Select(cpf => int.Parse(cpf.ToString())).ToArray();
            for (int i = 0; i < 9; i++)
            {
                soma += numeroCpf[i] * div1;
                div1--;
            }
            if (soma % 11 < 2)
            {
                digito1 = 0;
            }
            else
            {
                restoDiv = soma % 11;
                digito1 = 11 - restoDiv;
            }
  
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += numeroCpf[i] * div2;
                div2--;
            }
            if(soma % 11 < 2)
            {
                digito2 = 0;
            }
            else
            {
                restoDiv = soma % 11;
                digito2 = 11 - restoDiv;
            }
            if((numeroCpf[9] == digito1) && (numeroCpf[10] == digito2))
            {
                return true;
            }
        }
        else
        {
            return false;
        }

        return false;
    }
}
