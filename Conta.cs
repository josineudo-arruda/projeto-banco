class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if(valor > Saldo)
            throw new ArgumentException("O valor a ser sacado é maior que o Saldo atual");
        Saldo -= valor;
    }

    public void Depositar(double valor)
    {
        if(valor < 1)
            throw new ArgumentException("O valor a ser depositado não pode ser negativou ou zero");
        Saldo += valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        if(valor > Saldo || valor < 1)
            throw new ArgumentException("O valor a ser tranferido para a outra conta não deve ser maior que o saldo atual, ou menor que zero");
        Saldo -= valor;
        //conta.Depositar(valor);
        conta.Saldo += valor;
    }
}