using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class GestionBancoData
    {
        public List<string> registro { get; set; }

        public GestionBancoData()
        {
            registro = new List<string>();
        }



        // metodo para agregar monto depositados a una lista
        public void AgregarRegistro(int monto)
        {
            registro.Add($"{monto}");
        }


        //metodo para mostrar historial de depositos
        public List<string> obtenerRegistro()
        {
            Console.WriteLine("------Historial de Transacciones-------");
            foreach (var transacciones in registro)
            {
                Console.WriteLine($"* {transacciones}");
            }
            return registro;
        }
    }
}
