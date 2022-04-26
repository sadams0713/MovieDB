namespace Movie_Database
{
    public class Program
    {
        public static void Main()
        {
            
            List<Movies> movieList = new List<Movies>
            {
                 new Movies("Eternal Sunshine of the Spotless Mind", "drama"),
                 new Movies("Rock n Rolla", "action"),
                 new Movies("Snatch", "action"),
                 new Movies("Onward", "animated"),
                 new Movies("Encanto", "animated"),
                 new Movies("A Scanner Darkly", "drama"),
                 new Movies("Anchorman", "comedy"),
                 new Movies("Hot Rod", "comedy"),
                 new Movies("Don't F*ck with Cats", "documentary"),
                 new Movies("Human Nature", "documentary")
            };

            Console.WriteLine("Welcome to the Movie Database.");
            do
            {
                Console.WriteLine("Please enter the category of movie you'd like to see from the options listed \naction \nanimated \ndrama \ncomedy \ndocumentary");
                var selectcat = Console.ReadLine().ToLower().Trim();

                if (selectcat.Contains("act"))
                {
                    var action = movieList.Where(cat => cat.category == "action").ToList();
                    foreach (Movies cat in action)
                    {
                        Console.WriteLine(cat.title);
                    }
                }
                else if (selectcat.Contains("ani"))
                {
                    var animated = movieList.Where(cat => cat.category == "animated").ToList();
                    foreach (Movies cat in animated)
                    {
                        Console.WriteLine(cat.title);
                    }
                }
                else if (selectcat.Contains("dra"))
                {
                    var drama = movieList.Where(cat => cat.category == "drama").ToList();
                    foreach (Movies cat in drama)
                    {
                        Console.WriteLine(cat.title);
                    }
                }
                else if (selectcat.Contains("com"))
                {
                    var comedy = movieList.Where(cat => cat.category == "comedy").ToList();
                    foreach (Movies cat in comedy)
                    {
                        Console.WriteLine(cat.title);
                    }
                }
                else if (selectcat.Contains("doc"))
                {
                    var documentary = movieList.Where(cat => cat.category == "documentary").ToList();
                    foreach (Movies cat in documentary)
                    {
                        Console.WriteLine(cat.title);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't a valid entry. Please select from the following categories \naction \nanimated \ndrama \ncomedy \ndocumentary.");
                }

                bool check = OneMoreTime();

            }
            while (true);

                static bool OneMoreTime()
                {
                    string input = GetUserInput("Would you like to select a different category? Please enter  Y/N").ToLower();

                    if (input.Contains("y"))
                    {
                        return true;
                    }
                    else if (input.Contains("n"))
                    {
                        Console.WriteLine("Thanks for checking out the movie database!");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Sorry I didn't catch that. Let's try again.");
                        return OneMoreTime();
                    }

                }
                 static string GetUserInput(string prompt)
                {
                    Console.WriteLine(prompt);
                    string output = Console.ReadLine();
                    return output;
                }
            }

        }
    }
