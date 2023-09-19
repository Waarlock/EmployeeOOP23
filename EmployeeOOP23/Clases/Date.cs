using System;

namespace EmployeeOOP23.Clases
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion


        #region Methods
        public Date(int day, int month, int year)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }

        private int ValidateDay(int day, int month, int year)
        {
            //valido si el año pertenece a un año bisiesto

           if (month ==2 && day == 29 && IsLeapYear(year)) // 29/02/2023
            {
                return day;
            }
            

           if(month == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                throw new DayExeption(String.Format("El dia {0} no es válido para el mes {1}.",
                    day, month));
            }


        }

        private void IsLeapYearException (bool isLeapYear, int year)
        {
            if (!isLeapYear)
            {
                throw new YearExeption(String.Format("El año {0} no es bisiesto.", year));
            }
            
            


        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

        }


        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                throw new YearExeption(String.Format("El año {0} no es valido", year));

            }
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            else
            {
                //exeption creation
                throw new MonthExeption(String.Format("El mes {0} no es valido", month));

            }
        }

        public override string ToString()
        {
           //dia/mes/año
           //var dateContenated1 = _day + "/" + _month + "/" + _year;
           //var dateContenated2 = $"{_day}/{_month}/{_year}";
           //var dateContenated3 = String.Format("{0}/{1}/{2}", _day, _month, _year);
            return  String.Format("{0:00}/{1:00}/{2:0000}", _day, _month, _year);

           // return dateContenated;

        }

        #endregion

    }
}
