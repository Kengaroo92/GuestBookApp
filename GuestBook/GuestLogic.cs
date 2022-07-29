namespace GuestBook
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            //WelcomeMessage
            Console.WriteLine("**********************");
            Console.WriteLine("Welcome to the Party!!");
            Console.WriteLine("**********************");
            Console.WriteLine();

            Console.WriteLine("***************************************************************");
            Console.WriteLine("We like to keep track of all of our guests in this application.");
            Console.WriteLine("***************************************************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            //GetPartyName
            Console.Write("Enter your party name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;

            do
            {
                //GetPartySize
                Console.Write("How many people are in your party: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }

        public static bool AskToContinue()
        {
            Console.Write("Are there more guests coming (yes/no): ");
            string continueLooping = Console.ReadLine();

            bool output = (continueLooping.ToLower() == "yes");

            return output;
        }

        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;

            List<string> guests = new List<string>();

            do
            {
                guests.Add(GetPartyName());

                totalGuests += GetPartySize();

            } while (AskToContinue());

            return (guests, totalGuests);
        }

        public static void DisplayGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        public static void DisplayGuestsCount(int totalGuests)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Thank you for everyone who attended.");
            Console.WriteLine("************************************");
            Console.WriteLine();

            Console.WriteLine($"The total guest count for this evening was {totalGuests}.");
            Console.WriteLine();

        }
    }
}