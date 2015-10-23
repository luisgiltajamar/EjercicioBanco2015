using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco.Clases
{
    public  abstract class Producto
    {
        public decimal Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public abstract void Ingresar(decimal cantidad);
        public abstract void Sacar(decimal cantidad);

        public void Detalle()
        {
            Console.WriteLine("{0} {1} Saldo:{2:c}",
                Cliente.Dni,Cliente.Nombre,Saldo);

        }
    }
}
