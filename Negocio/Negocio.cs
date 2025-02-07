
using Data;
using Entidad;

namespace Negocio
{
    public class Negocios 
    {

        Datos servicio;

        public Negocios() 
        {
            servicio = new Datos();
        }

        public string AgregarPersona(string nombre,string correo, string carrera, string contrasena)
        {
            var modelo = new usuario
            {
                
                NombreCompleto = nombre,
                CorreoElectrónico = correo,
                Carrera = carrera,
                Contrasena = contrasena
            };
            servicio.SetUsuario(modelo);

            if (servicio.SetUsuario(modelo))

                return "Usuario agregado";

            else
                return "Problema para el registro. Contacte a un tecnico";
                
        }

        public List<usuario> DevolverLogin() 
        {  
            return servicio.GetUsuarios();
        }


    }
}
