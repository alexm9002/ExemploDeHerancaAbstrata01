namespace HerancaAbstrata.Entidades {

    // Subclasse herda campos da classe principal e acrescenta apenas os campos novos na nova classe
    internal class ContaEmpresarial : Conta {
        public double Limite { get; set; }

        // Para não ter a necessidade de vincular novamente as variáveis da Classe princial usar ": base"
        // com as variáveis da classe principal e lançar apenas as novas variáveis.
        public ContaEmpresarial(int numero, string titular, double saldo, double limite) : base(numero, titular, saldo) {
            this.Limite = limite;
        }

        public void Emprestimo(double emprestimo) {
            if (emprestimo <= Limite) {
                Saldo += emprestimo;
            }


        }
        // Nesse caso o método usado é o mesmo da classe Conta, porém acrescentado a diferença
        // da taxa de saque que é de R$ 7,00 para saque em conta jurídica.
        // Ou seja, Foi descontado R$ 5,00 no método principal da classe "Conta"
        // e foi acrescido mais R$ 2,00 na implementação da classe "ContaEmpresarial" == Total R$ 7,00. 
        // Usando a implementação "base".
        public override void Saque(double quantia) {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
