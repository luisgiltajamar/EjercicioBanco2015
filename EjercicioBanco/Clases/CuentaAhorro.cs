using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco.Clases
{
   public class CuentaAhorro:Producto
    {
       public double Bonificacion { get; set; }
       public double Penalizacion { get; set; }

       public override void Ingresar(decimal cantidad)
       {
           Saldo += cantidad + (cantidad*(decimal)Bonificacion);
       }

       public override void Sacar(decimal cantidad)
       {
           var penalizacion = cantidad*(decimal)Penalizacion;
           if (Saldo >= cantidad + penalizacion)
           {
               Saldo -= cantidad + penalizacion;
               Console.WriteLine("Retirada realizada con exito");
               Detalle();
           }
           else
           {
                Console.WriteLine("Saldo insuficiente");
                Detalle();
            }
       }
    }
}
