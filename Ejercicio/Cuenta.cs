using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public abstract class Cuenta
    {
        protected long Saldo { get; set; } 
        protected int NumeroDeCuenta;
        protected String Titular;

        public abstract void Extraccion(long monto);
        public abstract void Deposito(long monto);
    }
}
