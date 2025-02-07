using CapaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BancoGestionCuentas
    {
        public int NumeroCuenta { get; set; }
        public int Saldo { get; set; }
        public Propietario propietario { get; set; }

        GestionBancoData Data = new GestionBancoData();


        public BancoGestionCuentas()
        {
            propietario = new Propietario();
        }

        //sobrecarga constructor saldo en 0
        public BancoGestionCuentas(int numeroCuenta = 000 - 000, int saldo = 0)
        {
            NumeroCuenta = numeroCuenta;
            Saldo = saldo;
        }

        //metodo para mostrar informacion de la cuenta del usuario
        public void MostarInfo()
        {
            Console.WriteLine($"Nombre: {propietario.nombre} con el nuemero de documento {propietario.numeroDocumento}" +
                $" en el numero de cuenta: {NumeroCuenta} pose un saldo de ${Saldo}");

        }

        //Metodo para agregar un monto al saldo 
        public void AgregarSaldo(int monto)
        {
            if (monto >= 0)
            {
                Saldo += monto;
                Console.WriteLine("Deposito exitoso");
                Data.AgregarRegistro(monto);
            }
            else
            {
                Console.WriteLine("No se permiten numeros negativos");
            }

        }

        //metodo para retirar un monto
        public void RetirarMonto(int monto)
        {
            if (monto < Saldo)
            {
                Saldo -= monto;
                Console.WriteLine("Retiro exitoso");
                Data.AgregarRegistro(monto);
            }
            else
            {
                Console.WriteLine("El monto solicitado debe ser menor al saldo ");
            }
        }

        //muestra el historial de depositos y retiros
        public void MostrarHistorial()
        {
            Data.obtenerRegistro();
        }









    }
}
