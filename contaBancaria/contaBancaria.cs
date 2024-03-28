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
        }
        public contaBancaria(int NumeroConta, string NomeTitular, double depositoInicial):
            this(NumeroConta, NomeTitular)
        {
            depositar(depositoInicial);
        }


    }
}
