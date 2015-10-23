using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco.Clases
{
    public interface ICalculoSeguro
    {
        decimal Prima(int edad, decimal cantidad);
        decimal Cancelacion(decimal cantidad);
    }
}
