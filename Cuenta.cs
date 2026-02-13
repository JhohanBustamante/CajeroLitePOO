
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroLitePOO
{
    public class Cuenta
    {
        public decimal saldo { get; private set; }

        public Cuenta(decimal SaldoInicial = 0m)
        {
            saldo = SaldoInicial;
        }

        public string Depositar(decimal monto)
        {
            string resultado = "";
            if (monto <= 0)
            {
                return resultado = "El monto no es suficiente para depositar";
            }
            else if (monto > 2500000)
            {
                return resultado = "El monto es superior al maximo para depositar, debe ser menor o igual a 2'500.000";
            }
            else saldo += monto;
            string saldofinal = saldo.ToString();
            return resultado = "Se pudo hacer el deposito.";
        }

        public string Retirar(decimal monto)
        {

            string resultado = "";
            if (monto > saldo || monto <= 0)
            {
                resultado = "El monto a retirar es invalido o superior al saldo actual de su cuenta";
                return resultado;
            }
            saldo -= monto;
            string saldofinal = saldo.ToString();
            resultado = "El retiro se hizo de forma exitosa, su saldo actual ahora es de: " + saldofinal;
            return resultado;
        }

        public decimal VerSaldo()
        {
            return saldo;
        }
    }
}
