namespace HerancaAbstrata.Entidades {
    // Subclasse ContaPoupanca herda campos da superclasse conta.
    internal class ContaPoupanca : Conta {
        public double TaxadeJuros { get; set; }

        public ContaPoupanca(int numero, string titular, double saldo, double taxadeJuros) : base(numero, titular, saldo) {

            // Para não ter a necessidade de vincular novamente as variáveis da Classe princial usar ": base"
            // com as variáveis da classe principal e lançar apenas as novas variáveis.

            //this.Numero = numero;
            //this.Titular = titular;    - Tudo isso é substituído por ": base(numero, titular, saldo)"
            //this.Saldo = Saldo;

            this.TaxadeJuros = taxadeJuros;
        }

        public void AtualizaSaldo() {
            Saldo += Saldo * TaxadeJuros;
        }
        // Nesse caso o método usado é o mesmo da classe Conta, porém descontando o valor
        // da taxa de saque que é de R$ 5,00 para saque em conta normal.
        // Ou seja, Foi descontado R$ 5,00 no método principal da classe "Conta"
        // e foi retornado R$ 5,00 na implementação da classe "ContaPoupanca" == Total R$ 0,00 desconto. 
        // Usando a implementação "base".
        //public override void Saque(double quantia) {
         //   base.Saque(quantia);
         //   Saldo += 5.0;
       // }
    }
}
