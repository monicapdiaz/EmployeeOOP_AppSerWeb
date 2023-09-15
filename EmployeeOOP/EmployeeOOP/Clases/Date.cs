using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    internal class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        //metodo costructor ctor
        public Date(int day,int month,int year)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month); 
            _day = ValidateDay(day,month,year);
        }

        private int ValidateDay(int day,int mont,int year)
        {
            //valido sin el día ingresado, pertenece a año  bisiesto
            if (mont ==2 && day == 29 && IsLeapYear(year)) // 29/2/2023
            {
                return day;
            }
            if (mont == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }
            int[] daysPersMont = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 31, 30, 31 };
             if(day >=1 && day <= daysPersMont[mont])
            {
                return day;
            }
             else
            {
                throw new DayException(String.Format("El día {0} no es válido para el mes {1}.",
                    day, mont));

            }

        }
        private void IsLeapYearException(bool isLeapYear,int year)
        {
            if (!isLeapYear)
            {
                throw new YearException(String.Format("El año {0} no es bisiesto.", year));
            }
        }
        
        private bool IsLeapYear(int year) 
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 !=0; //valido los años bisiesto  
        }

        private int ValidateYear(int year)
        {
           if (year >=1900) 
            {
                return year;
            }
            else
            {
                throw new YearException(String.Format("El año {0} no es válido.", year));

            }
        }

        private int ValidateMonth(int month)
        {
           if(month >=1 && month <=12)//Mont =13
            {
                return month; 
            }
            else
            {
                //Exception Creation
                throw new MonthException(String.Format("El mes {0} no es válido.",month));

            }

        } 

        public override string ToString()
        {
            //día/mes/año
            var dateConcatenated = _day + "/" + _month + "/" + _year;
            return dateConcatenated;
         //   return String.Format("{0}/{1}/{2}", _day, _year, _month);

        }

        #endregion
    }

    [Serializable]
    internal class DayException : Exception
    {
        public DayException()
        {
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class YearException : Exception
    {
        public YearException()
        {
        }

        public YearException(string? message) : base(message)
        {
        }

        public YearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected YearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class MonthException : Exception
    {
        public MonthException()
        {
        }

        public MonthException(string? message) : base(message)
        {
        }

        public MonthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
