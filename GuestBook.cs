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
            if (File.Exists(filename))
            {
                string jsonString = File.ReadAllText(filename);
                posts = JsonSerializer.Deserialize<List<Post>>(jsonString)!;
            }
        }
        // Metod för att lägga till en post i gästboken
        public Post AddPost(string user, string message)
        {
            var post = new Post(user, message);
            posts.Add(post);
            SavetoFile();
            return post;
        }
        // Metod för att ta bort ett inlägg i gästboken
        public bool DeletePost(int index)
        {
            if (index < 0 || index >= posts.Count) return false;
            posts.RemoveAt(index);
            SavetoFile();
            return true;
        }
        // Metod för att hämta alla inlägg i gästboken
        public List<Post> GetPosts()
        {
            return posts;
        }
        // Metod för att spara listan med inlägg till en fil
        private void SavetoFile()
        {
            var options = new JsonSerializeroptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(posts, options);
            File.WriteAllText(filename, jsonString);
        }
    }
}