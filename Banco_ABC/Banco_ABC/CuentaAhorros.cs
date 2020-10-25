using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_ABC
{
    public class CuentaAhorros
    {
        private string numeroCuenta;
        private string nombreTitular;
        private string idTitular;
        private double saldo;
        
        public CuentaAhorros(string numeroCuenta, string nombreTitular, string idTitular, double saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.nombreTitular = nombreTitular;
            this.idTitular = idTitular;
            this.saldo = saldo;
        }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string NombreTitular { get => nombreTitular; set => nombreTitular = value; }
        public string IdTitular { get => idTitular; set => idTitular = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public static double totalConsignaciones = 0;
        public static double totalRetiros = 0;
        public static int totalTransacciones = 0;
        public static double mayorConsignacion = 0;
        public static string clienteMayorConsignacion;

        public static bool BuscarCuenta(string numeroCuenta, List<CuentaAhorros> cuentas)
        {
            bool x = false;
            foreach (CuentaAhorros cuentaAhorros in cuentas)
            {
                if (cuentaAhorros.numeroCuenta == numeroCuenta)
                {
                    x=true;
                    break;
                }
            }
            return x;
        }
        
        public static string Consignar(List <CuentaAhorros> cuentas, string numeroCuenta, double valorConsignacion) {
            string mensaje = "";
            if (CuentaAhorros.BuscarCuenta(numeroCuenta, cuentas) == true)
            {
                foreach (CuentaAhorros cuentaAhorros in cuentas)
                {
                    if (cuentaAhorros.numeroCuenta == numeroCuenta)
                    {
                        cuentaAhorros.saldo += valorConsignacion;
                        mensaje = "Valor consignado exitosamente";
                        totalTransacciones++;
                        totalConsignaciones += valorConsignacion;
                        if(valorConsignacion> mayorConsignacion)
                        {
                            mayorConsignacion = valorConsignacion;
                            clienteMayorConsignacion = cuentaAhorros.nombreTitular;
                        }
                        break;
                    }
                }
            }
            else
            {
                mensaje = "La cuenta no existe";
            }
            return mensaje;
        }

        public static string Retirar(string numeroCuenta, double valorRetirar, List<CuentaAhorros> cuentas)
        {
            string mensaje = "";
            if (CuentaAhorros.BuscarCuenta(numeroCuenta, cuentas) == true)
            {
                foreach (CuentaAhorros cuentaAhorros in cuentas)
                {
                    if (cuentaAhorros.saldo - valorRetirar < 0)
                    {
                        mensaje = "Saldo insuficiente";
                        break;
                    }
                    else
                    {
                        cuentaAhorros.saldo -= valorRetirar;
                        mensaje = "Retiro Exitoso";
                        totalTransacciones++;
                        totalRetiros += valorRetirar;
                        break;
                    }
                }
            }
            else
            {
                mensaje = "La cuenta no existe";
            }
        return mensaje;
        }

        public static string Transferir(string numeroCuentaOrigen, string numeroCuentaDestino, double valorTransferir, List<CuentaAhorros> cuentas)
        {
            string mensaje = "";
            int confCuentaOrigen = 0;
            int confCuentaDestino = 0;
            if (CuentaAhorros.BuscarCuenta(numeroCuentaOrigen, cuentas) == true) 
            {
                confCuentaOrigen = 1;
            }
            else
            {
                mensaje = "La cuenta de origen no existe";
            }

            if (CuentaAhorros.BuscarCuenta(numeroCuentaDestino, cuentas) == true)
            {
                confCuentaDestino = 1;
            }
            else
            {
                mensaje = "La cuenta de destino no existe";
            }


            if (confCuentaOrigen == 1 && confCuentaDestino == 1)
            {
                foreach (CuentaAhorros cuentaAhorros in cuentas)
                {
                    if (cuentaAhorros.numeroCuenta == numeroCuentaOrigen && cuentaAhorros.saldo - valorTransferir < 0)
                    {
                        mensaje = "Saldo insuficiente";
                        break;
                    }
                    else
                    {
                        cuentaAhorros.saldo -= valorTransferir;
                        mensaje = "Transferencia Exitosa";
                        totalTransacciones++;
                        break;
                    }
                }
                foreach (CuentaAhorros cuentaAhorros in cuentas)
                {
                    if (cuentaAhorros.numeroCuenta == numeroCuentaDestino)
                    {
                        cuentaAhorros.saldo += valorTransferir;
                        break;
                    }
                }
            }
            return mensaje;
        }
    }
}
