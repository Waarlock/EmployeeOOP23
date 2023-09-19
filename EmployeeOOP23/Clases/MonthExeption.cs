using System.Runtime.Serialization;

namespace EmployeeOOP23.Clases
{
    [Serializable]
    internal class MonthExeption : Exception
    {
        public MonthExeption()
        {
        }

        public MonthExeption(string? message) : base(message)
        {
        }

        public MonthExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MonthExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}