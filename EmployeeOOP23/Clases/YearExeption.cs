using System.Runtime.Serialization;

namespace EmployeeOOP23.Clases
{
    [Serializable]
    internal class YearExeption : Exception
    {
        public YearExeption()
        {
        }

        public YearExeption(string? message) : base(message)
        {
        }

        public YearExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected YearExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}