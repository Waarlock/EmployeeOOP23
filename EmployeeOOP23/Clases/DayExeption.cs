using System.Runtime.Serialization;

namespace EmployeeOOP23.Clases
{
    [Serializable]
    internal class DayExeption : Exception
    {
        public DayExeption()
        {
        }

        public DayExeption(string? message) : base(message)
        {
        }

        public DayExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}