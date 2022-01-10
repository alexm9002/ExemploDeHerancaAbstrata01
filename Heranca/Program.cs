using System;
using System.Globalization;
using HerancaAbstrata.Entidades;

namespace HerancaAbstrata {
    class Program {
        static void Main(string[] args) {
            List<Conta> lista = new List<Conta>();

            lista.Add(new ContaPoupanca(1001, "Alex", 500.0, 0.01));
            lista.Add(new ContaEmpresarial(1002, "Maria", 500.0, 400.0));
            lista.Add(new ContaPoupanca(1003, "Bob", 500.0, 0.01));
            lista.Add(new ContaEmpresarial(1004, "Anna", 500.0, 500.0));

            double soma = 0.0;
            foreach (Conta acc in lista)
            {
                soma += acc.Saldo;
            }
            
            Console.WriteLine("Total de Saldos: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            foreach (Conta acc in lista)
            {
                acc.Saque(10.0);
            }
            foreach (Conta acc in lista)
            {
                Console.WriteLine("Saldo atualizado para a conta: "
                + acc.Numero
                + ": "
                + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                
            }
            Console.WriteLine("-------------------------");

            foreach (Conta acc in lista)
            {
                soma += acc.Saldo;
            }

            Console.WriteLine("Total de Saldos: " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}