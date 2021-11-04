using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IDelisle
    {
        decimal CovertirdedAKelvin(decimal ran);
        decimal CovertirdeACelcius(decimal ran);
        decimal CovertirdeAFahrenheit(decimal ran);
        decimal CovertirdeAReaumur(decimal ran);
        decimal CovertirdeARomer(decimal ran);
        decimal CovertirdeANewton(decimal ran);
        decimal CovertirdeARankine(decimal ran);
    }
}
