using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
