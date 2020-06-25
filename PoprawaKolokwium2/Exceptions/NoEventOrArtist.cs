using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolokwium2.Exceptions
{
    public class NoEventOrArtist : Exception
    {
        public NoEventOrArtist()
        {
        }

        public NoEventOrArtist(string? message) : base(message)
        {
        }

        public NoEventOrArtist(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
