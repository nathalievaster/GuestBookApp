using System;

namespace GuestBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GuestBook guestBook = new GuestBook();
            int i = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("G Ä S T B O K");
                Console.WriteLine("==============");

                Console.WriteLine("1. Lägg till inlägg");
                Console.WriteLine("2. Ta bort inlägg");
                Console.WriteLine("X. Avsluta\n");
            }
        }
    }
}
