using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class CovertidorModel : IKelvin, ICelcius, IFahrenheit, IRankine, IReaumur, IRomer, INewton, IDelisle
    {

        #region Delisle
        public decimal CovertirdedAKelvin(decimal ran)
        {
            decimal t = (decimal)373.15 - ran * (2 / 3);
            return t;
        }
        public decimal CovertirdeACelcius(decimal ran)
        {
            decimal t = 100 - ran * (2 / 3);
            return t;
        }
        public decimal CovertirdeAFahrenheit(decimal ran)
        {
            decimal t = 212 - ran * (6/ 5);
            return t;
        }
        public decimal CovertirdeARankine(decimal ran)
        {
            decimal t = (decimal)171.67 - ran * (6 / 5);
            return t;
        }
        public decimal CovertirdeAReaumur(decimal ran)
        {
            decimal t = 80- ran * (5 / 6);
            return t;
        }
        public decimal CovertirdeARomer(decimal ran)
        {
            decimal t = 60 - ran * (7 / 20);
            return t;
        }
        public decimal CovertirdeANewton(decimal ran)
        {
            decimal t = 33 - ran * (11/50);
            return t;
        }
        

        #endregion
        #region Newton
        public decimal CovertirnewAKelvin(decimal newt)
        {
            decimal t = newt * (100 / 33) + (decimal)273.15;
            return t;
        }
        public decimal CovertirnewACelcius(decimal newt)
        {
            decimal t = newt * (100 / 33);
            return t;
        }
        public decimal CovertirnewAFahrenheit(decimal newt)
        {
            decimal t = newt * (60 / 11) + 32;
            return t;
        }
        public decimal CovertirnewARankine(decimal newt)
        {
            decimal t= newt * (60/11) + (decimal)491.67;
            return t;
        }
        public decimal CovertirnewAReaumur(decimal newt)
        {
            decimal t = newt * (80/33);
            return t;
        }
        public decimal CovertirnewARomer(decimal newt)
        {
            decimal t= newt * (35/22) + (decimal)7.5;
            return t;
        }
        public decimal CovertirnewADelisle(decimal newt)
        {
          decimal t= (33-newt) * (50/11);
            return t;
        }


        #endregion
        #region Romer
        public decimal CovertirAKelvin(decimal ran)
        {
            decimal t = (ran - (decimal)7.5) * (40 / 21) + (decimal)273.15;
            return t;
        }
        public decimal CovertirACelcius(decimal ran)
        {
            decimal t = (ran - (decimal)7.5) * (40 / 21);
            return t;
        }
        public decimal CovertirAFahrenheit(decimal ran)
        {
            decimal t = (ran - (decimal)7.5) * (24 / 7) + 32;
            return t;
        }
        public decimal CovertirAReaumur(decimal ran)
        {
            decimal t = (ran - (decimal)7.5) * (32 / 21);
            return t;
        }
        public decimal CovertirARankine(decimal ran)
        {
            decimal t = (ran - (decimal)7.5) * (32 / 21) + (decimal)491.67;
            return t;
        }
        public decimal CovertirANewton(decimal ran)
        {
            decimal t = (ran - (decimal)7.5) * (22 / 35);
            return t;
        }
        public decimal CovertirADelisle(decimal ran)
        {
            decimal t = (60 - ran) * (20 / 7);
            return t;
        }
        #endregion
        #region Reaumur
        public decimal CovertirreaAKelvin(decimal Rea)
        {
            decimal t = Rea * (5 / 4) + (decimal)273.15;
            return t;
        }
        public decimal CovertirreaACelcius(decimal rea)
        {
            decimal t = rea * (5 / 4);
            return t;
        }
        public decimal CovertirreaAFahrenheit(decimal rea)
        {
            decimal t = rea * (9 / 4) + 32;
            return t;
        }
        public decimal CovertirreaARankine(decimal rea)
        {
            decimal t = rea * (9 / 4) + (decimal)491.67;
            return t;
        }
        public decimal CovertirreaARomer(decimal rea)
        {
            decimal t = rea * (21 / 32) + (decimal)7.5;
            return t;
        }
        public decimal CovertirreaANewton(decimal rea)
        {
            decimal t = rea * (33 / 80);
            return t;
        }
        public decimal CovertirreaADelisle(decimal rea)
        {
            decimal t = (80 - rea) * (6 / 5);
            return t;
        }
        #endregion
        #region Rankine
        public decimal CovertirranAKelvin(decimal ran)
        {
            decimal t = ran * (5 / 9);
            return t;
        }
        public decimal CovertirranACelcius(decimal ran)
        {
            decimal t = (ran - (decimal)491.67) * (5 / 9);
            return t;
        }
        public decimal CovertiranAFahrenheit(decimal ran)
        {
            decimal t = ran - (decimal)491.67;
            return t;
        }
        public decimal CovertirranAReaumur(decimal ran)
        {
            decimal t = (ran - (decimal)491.67) * (4 / 9);
            return t;
        }
        public decimal CovertirranARomer(decimal ran)
        {
            decimal t = (ran - (decimal)491.67) * (7 / 24) + (decimal)7.5;
            return t;
        }
        public decimal CovertirranANewton(decimal ran)
        {
            decimal t = (ran - (decimal)491.67) * (11 / 60);
            return t;
        }
        public decimal CovertirranADelisle(decimal ran)
        {
            decimal t = ((decimal)580.67 - ran) + (5 / 6);
            return t;
        }
        #endregion
        #region FAhrenheit
        public decimal covertirfaAKelvin(decimal fah)
        {
            decimal t = (fah + (decimal)459.67) * (5 / 9);
            return t;
        }
        public decimal covertirfaACelcius(decimal fah)
        {
            decimal t = (fah - 32) * (5 / 9);
            return t;
        }
        public decimal covertirfaARankine(decimal fah)
        {
            decimal t = fah + (decimal)459.67;
            return t;
        }
        public decimal covertirfaAReaumur(decimal fah)
        {
            decimal t = (fah - 32) * (4 / 9);
            return t;
        }
        public decimal covertirfaARomer(decimal fah)
        {
            decimal t = (fah - 32) * (7 / 24) + (decimal)7.5;
            return t;
        }
        public decimal covertirfaANewton(decimal fah)
        {
            decimal t = (fah - 32) * (11 / 60);
            return t;
        }
        public decimal covertirfaADelisle(decimal fah)
        {

            decimal t = (212 - fah) * (5 / 6);
            return t;
        }

        #endregion
        #region Celcius
        public decimal ConvertidorCelciusAKelvin(decimal Celcius)
        {
            decimal t = Celcius + (decimal)273.15;
            return t;
        }
        public decimal ConvertidorcelAFahrenheit(decimal cel)
        {
            decimal t = cel * (9 / 5) + 32;
            return t;
        }
        public decimal ConvertidorcelARankie(decimal cel)
        {
            decimal t = cel + (decimal)273.15 * (9 / 5);
            return t;
        }
        public decimal ConvertidocelAReamur(decimal cel)
        {
            decimal t = cel * (4 / 5);
            return t;
        }
        public decimal ConvertidorcelARomer(decimal cel)
        {
            decimal t = (cel * (21 / 40)) + (decimal)7.5;
            return t;
        }
        public decimal ConvertidorcelANewton(decimal cel)
        {
            decimal t = cel * (33 / 100);
            return t;
        }
        public decimal ConvertidorcelDelisle(decimal cel)
        {
            decimal t = (100 - cel) * (3 / 2);
            return t;
        }
        #endregion
        #region Kelvin
        public decimal ConvertidorKelvinACelcius(decimal Kelvin)
        {
            decimal tt = Kelvin - (decimal)273.15;
            return tt;
        }
        public decimal ConvertidorKelvinAFahrenheit(decimal Kelvin)
        {
            decimal tt = (Kelvin * (9 / 5)) - (decimal)459.67;
            return tt;
        }
        public decimal ConvertidorKelvinANewton(decimal Kelvin)
        {
            decimal tt = (Kelvin - (decimal)273.15) * (33 / 100);
            return tt;
        }
        public decimal ConvertidorKelvinARankie(decimal Kelvin)
        {
            decimal tt = Kelvin * (9 / 5);
            return tt;
        }
        public decimal ConvertidorKelvinAReamur(decimal Kelvin)
        {
            decimal tt = (Kelvin - (decimal)273.15) * (4 / 5);
            return tt;
        }
        public decimal ConvertidorKelvinARomer(decimal Kelvin)
        {
            decimal tt = (Kelvin - (decimal)273.15) * (21 / 40) + (decimal)7.5;
            return tt;
        }
        public decimal ConvertidorKelvinDelisle(decimal Kelvin)
        {
            decimal t = ((decimal)373.15 - Kelvin) * (3 / 2);
            return t;
        }
        #endregion



    }
    }

