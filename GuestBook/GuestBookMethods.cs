using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class GuestBookMethods
    {
        public static void WelcomeToParty()
        {
            Console.WriteLine("Welcome to our party. We hope you enjoy your night.");
            Thread.Sleep(500);

            Console.WriteLine("Before we begin, please tell me what your name is.");
            Thread.Sleep(500);
        }

        public static void GuestNames()
        {
            string? guestFirstName = Console.ReadLine();
            List<string>? guestNames = new List<string>();

            guestNames.Add(guestFirstName);

            Console.WriteLine($"What is your last name {guestFirstName}? ");

            string? guestLastName = Console.ReadLine();
            List<string>? guestLastNames = new List<string>();
            //Add last names to List to count total families at the party later on.
            guestLastNames.Add(guestLastName);

            Console.WriteLine($"Thank you {guestFirstName + " " + guestLastName}, how many family members are joining you tonight?");

            string? countText = Console.ReadLine();
            bool countParse = int.TryParse(countText, out int familyCount);

            if (countParse)
            {
                Console.WriteLine($"Great, you have {familyCount} family members with you.");
            }
            else
            {
                Console.WriteLine($"It seems you entered an invalid entry. Please use real numbers.");
            }

            Console.WriteLine("What are their names?");

            for (int i = 0; i < familyCount; i++)
            {
                Console.Write($"Name of family member {i + 1}? ");
                string? familyName = Console.ReadLine();

                guestNames.Add(familyName);
            }

            Console.WriteLine($"Great! It seems you have {familyCount + 1} total members in your family.");
            Console.WriteLine("Their names are: ");
            foreach (string name in guestNames)
            {
                Console.WriteLine(name + " " + guestLastName);
            }
        }


        public static void FamilyCount()
        {

        }

        public static void TotalPersonCount()
        {

        }
    }
}
