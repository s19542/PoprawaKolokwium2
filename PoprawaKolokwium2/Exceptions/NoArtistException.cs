using System;


namespace PoprawaKolokwium2.Exceptions
{
    public class NoArtistException : Exception
    {
        public NoArtistException()
        {
        }

        public NoArtistException(string? message) : base(message)
        {
        }

        public NoArtistException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
