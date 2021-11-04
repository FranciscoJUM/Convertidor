using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IReaumur
    {
        decimal CovertirreaAKelvin(decimal Rea);
        decimal CovertirreaACelcius(decimal rea);
        decimal CovertirreaAFahrenheit(decimal rea);
        decimal CovertirreaARankine(decimal rea);
        decimal CovertirreaARomer(decimal rea);
        decimal CovertirreaANewton(decimal rea);
        decimal CovertirreaADelisle(decimal rea);
    }
}
