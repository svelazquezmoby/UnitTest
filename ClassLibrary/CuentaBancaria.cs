using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CuentaBancaria
    {
        private readonly ILoggerGeneral _loggerGeneral;

        public int balance { get; set; }
        public CuentaBancaria(ILoggerGeneral loggerGeneral
            )
        {
            balance = 0;
            this._loggerGeneral = loggerGeneral;
        }

        public bool Deposito(int monto)
        {
            _loggerGeneral.Message("Esta depositando la cantidad de:  " + monto);
            balance += monto;
            return true;
        }

        public bool Retiro(int monto)
        {
            if (monto <= balance)
            {
                balance -= monto;
                return true;
            }
            return false;
        }

        public int Getbalance ()
        {
            return balance;
        }
    }
}
