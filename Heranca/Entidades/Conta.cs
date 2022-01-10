namespace HerancaAbstrata.Entidades
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }
        // Usa-se o modificador de acesso "protected" para permitir o acesso em subclasse.

        public Conta(int numero, string titular, double saldo)
        {

            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        //Usar o termo "virtual" antes do "void" para permitir o método ser usado em outras classes subclasses.
        //Exemplo de uso na subclasse "ContaPoupanca". Digitar "override" e dar espaço depois, para puxar o método.
        public virtual void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
