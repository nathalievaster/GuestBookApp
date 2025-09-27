using System;

namespace GuestBookApp
{
    public class GuestBookWrite
    {
        public string User { get; set; }
        public string Message { get; set; }

        // Konstruktor för att ta emot parametrarna 
        public GuestBookWrite(string user, string message)
        {
            User = user;
            Message = message;
        }
    }
}
