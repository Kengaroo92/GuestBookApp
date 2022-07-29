using GuestBook;

//Keep in mind DRY. Don't Repeat Yourself - Use as many methods as you can to avoid repeat code.

int totalGuests = 0;
string continueLooping;

GuestLogic.WelcomeMessage();

do
{
    string partyName = GuestLogic.GetPartyName();

    totalGuests += GuestLogic.GetPartySize();

    Console.Write("Are there more guests coming (yes/no): ");
    continueLooping = Console.ReadLine();
} while (continueLooping.ToLower() == "yes");