using System;

namespace HotDrinksMachineApi.Exceptions
{
    public class InvalidDrinkTypeException : Exception
    {
        public InvalidDrinkTypeException()
        {
        }

        public InvalidDrinkTypeException(string message) : base(message)
        {
        }

        public InvalidDrinkTypeException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}
