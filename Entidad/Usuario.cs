
namespace Entidad
{
    public class usuario
    {
        public int Id { get; set; }
        
        public string NombreCompleto { get; set; }
        public string CorreoElectrónico { get; set;}
        public string Carrera { get; set;}
        public string Contrasena { get; set;}

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {NombreCompleto}, Correo: {CorreoElectrónico}, Carrera: {Carrera}, " +
                $"contrase{Contrasena}";
        }

    }
}
