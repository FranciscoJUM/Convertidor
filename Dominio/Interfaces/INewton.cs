using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface INewton
    {
        decimal CovertirnewAKelvin(decimal newt);
        decimal CovertirnewACelcius(decimal newt);
        decimal CovertirnewAFahrenheit(decimal newt);
        decimal CovertirnewAReaumur(decimal newt);
        decimal CovertirnewARomer(decimal newt);
        decimal CovertirnewARankine(decimal newt);
        decimal CovertirnewADelisle(decimal newt);
    }
}
