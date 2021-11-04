using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicios
{
    public interface RomerService
    {
        decimal CovertirAKelvin(decimal ran);
        decimal CovertirACelcius(decimal ran);
        decimal CovertirAFahrenheit(decimal ran);
        decimal CovertirAReaumur(decimal ran);
        decimal CovertirARankine(decimal ran);
        decimal CovertirANewton(decimal ran);
        decimal CovertirADelisle(decimal ran);
    }
}
