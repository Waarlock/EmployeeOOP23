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
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
           //dia/mes/año
           //var dateContenated1 = _day + "/" + _month + "/" + _year;
           //var dateContenated2 = $"{_day}/{_month}/{_year}";
           //var dateContenated3 = String.Format("{0}/{1}/{2}", _day, _month, _year);
            return  String.Format("{0}/{1}/{2}", _day, _month, _year);

           // return dateContenated;

        }

        #endregion

    }
}
