using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class CuentaCorriente : Cuenta
    {
        private long DescubiertoAcordado { get; set; }

        public CuentaCorriente(long saldo, int numeroDeCuenta, string titular, long descubiertoAcordado) : base()
        {
            Saldo = saldo;
            NumeroDeCuenta = numeroDeCuenta;
            Titular = titular;
            DescubiertoAcordado = descubiertoAcordado;
        }

        public override void Deposito(long monto)
        {
            Saldo += monto;
        }

        public override void Extraccion(long monto)
        {
            if (monto > Saldo + DescubiertoAcordado)
            {
                throw new Exception("No hay dinero suficiente");
            }
            Saldo -= monto;
        }
    }
}
