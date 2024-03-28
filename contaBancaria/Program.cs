using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número da conta");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do titular da conta:");
            string NomeTitular = Console.ReadLine();
            Console.WriteLine("Deseja efetuar um depósito inicial(s/n)?");
                char resposta = char.Parse(Console.ReadLine());
            ContaBancaria conta;
            if(resposta == 's')
            {
                Console.WriteLine("Informe o valor do depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta= new ContaBancaria(NumeroConta, NomeTitular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(NumeroConta, NomeTitular);
}
            Console.WriteLine("Os dados da conta,");
            Console.WriteLine("Conta");
            Console.WriteLine("Informe valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);
            Console.WriteLine("Conta");
        }
    }
}
