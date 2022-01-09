using System;
using Heranca.Entidades;

namespace Heranca {
    class Program {
        static void Main(string[] args) {
            Conta contaPessoaFisica = new Conta(1008, "Alex", 0.0);
            ContaEmpresarial contaPessoaJuridica = new ContaEmpresarial(1009, "Maria", 0.0, 500.00);

            //UPCASTING
            // Uma classe pode receber qualquer objeto de uma subclasse
            Conta contaPessoaFisica1 = contaPessoaJuridica; //De variável para variável
            Conta contaPessoaFisica2 = new ContaEmpresarial(1003, "Bob", 500.00, 200.00); //Atribuído diretamente
            Conta contaPoupanca = new ContaPoupanca(1004, "Anna", 500.00, 0.01);


            Conta acc1 = new Conta(1005, "Marcelo", 500.00);
            Conta acc2 = new ContaPoupanca(1006, "Carlos", 500.00, 0.01);
            
            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc2.Saldo);

            //DOWNCASTING
            // Uma subclasse pode receber qualquer objeto de uma superclasse
            ContaEmpresarial contaPessoaFisica3 = (ContaEmpresarial)contaPessoaFisica2;

            // Exemplo de um método da subclasse "ContaEmpresarial" sendo usado em uma variável da superclasse "Conta"
            // Obs.: Só poderá ser feito esse processo após ter sido feito o "DOWNCASTING"
            contaPessoaFisica3.Emprestimo(100.0);

            // Obs.: Não podemos fazer UPCASTING OU DOWNCASTING de variáveis diferentes entre classes.
            // Para isso devemos fazer um teste antes com "if"
            // Exemplo:


            //Temos duas formas de fazer Downcasting:

            //  classe destino   nova variável      variável de origem "as" classe destino
            // "ContaEmpresarial contaPessoaFisica4 = contaPoupanca as ContaEmpresarial;"

            //  classe destino   nova variável    (classe destino) <--- "Entre parenteses"  variável de origem
            // ContaPoupanca contaPessoaFisica4 = (ContaPoupanca) contaPoupanca;

            if (contaPoupanca is ContaEmpresarial) {  
                ContaEmpresarial contaPessoaFisica4 = contaPoupanca as ContaEmpresarial; //Exemplo: 1
                contaPessoaFisica4.Emprestimo(200.0);
                Console.WriteLine("Empréstimo");
            }
            if (contaPoupanca is ContaPoupanca) {
                ContaPoupanca contaPessoaFisica4 = (ContaPoupanca) contaPoupanca; //Exemplo: 2
                contaPessoaFisica4.AtualizaSaldo();
                Console.WriteLine("Atualizado");
            }

            
        }
    }
}