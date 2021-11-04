using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IFahrenheit
    {
        decimal covertirfaAKelvin(decimal fah);
        decimal covertirfaACelcius(decimal fah);
        decimal covertirfaARankine(decimal fah);
        decimal covertirfaAReaumur(decimal fah);
        decimal covertirfaARomer(decimal fah);
        decimal covertirfaANewton(decimal fah);
        decimal covertirfaADelisle(decimal fah);
    }
}
