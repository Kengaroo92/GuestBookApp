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
    }
}