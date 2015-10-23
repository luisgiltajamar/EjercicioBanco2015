using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco.Clases
{
   public class CuentaCorriente:Producto,ICalculoSeguro
    {

       public decimal Credito { get; set; }
       public decimal Interes { get; set; }


       public override void Ingresar(decimal cantidad)
       {
           Saldo += cantidad;
            Console.WriteLine("Ingreso realizado con exito");
            Detalle();
       }

       public override void Sacar(decimal cantidad)
       {
           if (Saldo >= cantidad)
           {
               Saldo -= cantidad;
               Console.WriteLine("Retirada realizada con exito");
               Detalle();
           }
           else if (Saldo + Credito >= cantidad)
           {
               var cs = cantidad - Saldo;
               var interes = cs*Interes;
               Saldo -= cantidad + interes;
               Console.WriteLine("Retirada realizada con exito");
               Detalle();
           }
           else
           {
                Console.WriteLine("Saldo insuficiente");
                Detalle();
            }
       }

       public decimal Prima(int edad, decimal cantidad)
       {
           if (edad < 40)
           {
               return cantidad*(decimal)0.01;
           }
           else
           {
                return cantidad * (decimal)0.03;
            }
       }

       public decimal Cancelacion(decimal cantidad)
       {
           return cantidad*(decimal)0.01;
       }
    }
}
