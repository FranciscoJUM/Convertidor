using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface  IKelvin 
    {
        // Kelvin

        decimal ConvertidorKelvinACelcius(decimal Kelvin);
        decimal ConvertidorKelvinAFahrenheit(decimal Kelvin);
        decimal ConvertidorKelvinARankie(decimal Kelvin);
        decimal ConvertidorKelvinAReamur(decimal Kelvin);
        decimal ConvertidorKelvinARomer(decimal Kelvin);
        decimal ConvertidorKelvinANewton(decimal Kelvin);
        decimal ConvertidorKelvinDelisle(decimal Kelvin);
    }
}
