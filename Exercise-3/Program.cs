namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>
        {
            "The product is excellent.",
            "This is a great product.",
            "I use this product all the time.",
            "This is the best product in this category."
        };
            List<string> events = new List<string>
        {
           "I feel good.",
           "I managed to change.",
           "He did a miracle.",
           "I won! A miracle happened!",
           "I can't believe it, but I managed to outdo myself.",
           "Try it too. I'm very pleased."
        };
            List<string> firstNames = new List<string> { "Kalina", "Gergana", "Stella", "Elena", "Katya" };
            List<string> lastNames = new List<string> { "Ivanova", "Petrova", "Kirova" };
            List<string> cities = new List<string> { "Sofia", "Plovdiv", "Varna", "Ruse", "Burgas", "Karlovo", "Sopot" };
            while (true)
            {
                Console.WriteLine("Do you want to add new data? (Yes / No)");
                string answer = Console.ReadLine().ToLower();
                if (answer != "yes") break;
                Console.WriteLine("Which list do you want to add to? (1: Phrases, 2: Events, 3: First name, 4: Last name, 5: City)");
                int listChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new item:");
                string newItem = Console.ReadLine();
                switch (listChoice)
                {
                    case 1:
                        phrases.Add(newItem);
                    break;
                    case 2:
                        events.Add(newItem);
                    break;
                    case 3:
                        firstNames.Add(newItem);
                        break;
                    case 4:
                        lastNames.Add(newItem);
                    break;
                    case 5:
                        cities.Add(newItem);
                    break;
                    default:
                        Console.WriteLine("Invalid selection.");
                    break;
                }
            }
            Random rnd = new Random();
            string phrase = phrases[rnd.Next(phrases.Count)];
            string eventHappened = events[rnd.Next(events.Count)];
            string firstName = firstNames[rnd.Next(firstNames.Count)];
            string lastName = lastNames[rnd.Next(lastNames.Count)];
            string city = cities[rnd.Next(cities.Count)];
            Console.WriteLine($"{phrase} {eventHappened} - {firstName} {lastName}, {city}");
        }
           
    }
}
