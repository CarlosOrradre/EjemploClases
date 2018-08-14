using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class CajaDeAhorro : Cuenta
    {
        public CajaDeAhorro(long saldo, int numeroDeCuenta, string titular) : base()
        {
            Saldo = saldo;
            NumeroDeCuenta = numeroDeCuenta;
            Titular = titular;
        }

        public override void Deposito(long monto)
        {
            Saldo += monto;
        }

        public override void Extraccion(long monto)
        {
            if (monto > Saldo)
            {
                throw new Exception("No hay dinero suficiente");
            }
            Saldo -= monto;
        }
    }
}
