using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria
{
    class contaBancaria
    {
        private int _NumeroConta;
        private string _NomeTitular;
        private double _Saldo;
        public contaBancaria(int NumeroConta, string NomeTitular)
        {
            _NumeroConta = _NumeroConta;
            _NomeTitular = _NomeTitular;
             _Saldo = 0.0;
        }
        public contaBancaria(int NumeroConta, string NomeTitular, double depositoInicial):
            this(NumeroConta, NomeTitular)
        {
            depositar(depositoInicial);
        }
        public void Depositar(double Valor)
        {
            _Saldo += Valor;
        }
        public void sacar(double Valor)
        {
            _Saldo -= Valor + 5.0;
}
        public override string ToString()
        {
            return $"O número da conta {_NumeroConta}, titular, {_NomeTitular}, saldo R${_Saldo:C2}";
                }

    }
}
