using Entidad;
using Negocio;
using CapaNegocio;

BancoGestionCuentas gestion = new BancoGestionCuentas();
Negocios serv = new Negocios();




int opcion;
string nombre;
string correo;
string carrera;
string contrasena;
int monto;
do
{
    
    Console.WriteLine("--------------------------Gestion Bancaria BHD-------------------");
    Console.WriteLine("Menu");
    Console.WriteLine("1.Registrarme");
    Console.WriteLine("2.Iniciar sesion");
    Console.WriteLine("3.Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion) {

        case 1:
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu correo");
            correo = Console.ReadLine();
            Console.WriteLine("Ingresa tu carrera");
            carrera = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            contrasena = Console.ReadLine();
            serv.AgregarPersona(nombre,correo,carrera,contrasena);
            break;

        case 2:
            var list = serv.DevolverLogin();

            Console.WriteLine("Ingresa tu correo:");
            correo = Console.ReadLine();

            Console.WriteLine("Ingresa tu contraseña:");
            contrasena = Console.ReadLine();

            // Buscar si existe un usuario con ese correo y contraseña
            var usuario = list.FirstOrDefault(item => item.CorreoElectrónico == correo && item.Contrasena == contrasena);

            if (usuario != null)
            {
                Console.WriteLine("Ingresando a la gestión banco...");


                Console.WriteLine("Ingrese su nombre");
                gestion.propietario.nombre = Console.ReadLine();

                Console.WriteLine("ingrese su numero de documento");
                gestion.propietario.numeroDocumento = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese su numero de cuenta");
                gestion.NumeroCuenta = int.Parse(Console.ReadLine());


                do
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("BHD");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Selecione una opcion");
                    Console.WriteLine("1-Agregar saldo");
                    Console.WriteLine("2-Retirar Monto");
                    Console.WriteLine("3-Ver informacion de la cuenta");
                    Console.WriteLine("4-Ver historial de transacciones");
                    Console.WriteLine("5-Salir");
                    opcion = int.Parse(Console.ReadLine());



                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese monto a depositar");
                            monto = int.Parse(Console.ReadLine());
                            gestion.AgregarSaldo(monto);
                            break;

                        case 2:
                            Console.WriteLine("Ingrese monto a retirar");
                            monto = int.Parse(Console.ReadLine());
                            gestion.RetirarMonto(monto);
                            break;

                        case 3:
                            gestion.MostarInfo();
                            break;

                        case 4:
                            gestion.MostrarHistorial();
                            break;

                        case 5:
                            Console.WriteLine("Saliendoooo");
                            break;

                        default:
                            Console.WriteLine("Opcion seleccionada no valida");
                            break;
                    }

                } while (opcion != 5);

            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
            }


            break;

        case 3:
            Console.WriteLine("saliendo del sistema");
            break; 


    }




} while (opcion != 3);