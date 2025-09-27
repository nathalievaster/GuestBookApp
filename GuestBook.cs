using System;

namespace GuestBookApp
{
    public class GuestBook
    {
        // Json-filen där vi ska lagra listan
        private string filename = @"guestbook.json";
        // En lista för alla poster i gästboken
        private List<Post> posts = new List<Post>();

        public GuestBook()
        {
            
        }
    }
}