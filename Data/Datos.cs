using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class Datos
    {
        UsuarioContext context;


        public Datos() 
        {
            context = new UsuarioContext();
        }


        public List<usuario> GetUsuarios()
        {
           return context.usuario.ToList();
        }


        public bool SetUsuario(usuario usuer) 
        {
            try 
            {
                context.Add(usuer);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex) 
            {
                return false; 
            }


        }
        
    }
}
