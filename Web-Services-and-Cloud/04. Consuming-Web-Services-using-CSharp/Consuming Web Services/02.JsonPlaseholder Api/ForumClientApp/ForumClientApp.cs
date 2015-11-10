using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaseholderApi
{
    public class ForumClientApp
    {
        private IForumData data;

        public ForumClientApp(IForumData data)
        {
            this.data = data;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to JSONPlaseho;der console client app. Available commands are 'search', 'exit'");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "search":
                        SearchPosts();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        private void SearchPosts()
        {
            Console.WriteLine("Pese enter your search key or nothing to see all posts: ");
            var searchKey = Console.ReadLine();

            IEnumerable<string> result = new List<string>();

            try
            {
                result = data.GetPosts(searchKey);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Found posts:");
            Console.WriteLine(string.Join("\n", result.ToArray()));
            Console.WriteLine("\nSearch finished.\n");
        }
    }
}
