using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
 public interface IRankine
    {
        decimal CovertirranAKelvin(decimal ran);
        decimal CovertirranACelcius(decimal ran);
        decimal CovertiranAFahrenheit(decimal ran);
        decimal CovertirranAReaumur(decimal ran);
        decimal CovertirranARomer(decimal ran);
        decimal CovertirranANewton(decimal ran);
        decimal CovertirranADelisle(decimal ran);
    }
}
