using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicios
{
    public interface CelciusService
    {
        decimal ConvertidorCelciusAKelvin(decimal Celcius);
        decimal ConvertidorcelAFahrenheit(decimal cel);
        decimal ConvertidorcelARankie(decimal cel);
        decimal ConvertidocelAReamur(decimal cel);
        decimal ConvertidorcelARomer(decimal cel);
        decimal ConvertidorcelANewton(decimal cel);
        decimal ConvertidorcelDelisle(decimal cel);
    }
}
