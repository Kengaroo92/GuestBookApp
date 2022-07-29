using GuestBook;

//Keep in mind DRY. Don't Repeat Yourself - Use as many methods as you can to avoid repeat code.

Console.WriteLine("Welcome to the Party!!");
Console.WriteLine("We like to keep track of all of our guests in this application.");
Console.WriteLine("Before you come in and have a good time, can you tell me your name?");
Console.Write("Enter your name: ");

GuestBookMethods.GuestNames();

List<int> totalGuestCount = new List<int>();

int guestCount = GuestBookMethods.GuestNames().Count;

totalGuestCount.Add(guestCount);

GuestBookMethods.MoreGuests();

while (GuestBookMethods.MoreGuests() == "yes")
{
    Console.WriteLine("Welcome new guest. What is your name?");
    Console.Write("Enter your name: ");
    GuestBookMethods.GuestNames();
}

for (int i = 0; i < guestCount; i++)
{
    totalGuestCount.Add(i);
}

Console.WriteLine($"That's it. We have {GuestBookMethods.GuestCount().Count} guests at the party.");
Console.WriteLine("Let the party begin!");







//Welcome the guests to your party. WelcomeToParty()

//GuestBookMethods.WelcomeToParty();

//Ask the guest for their name. - GuestsName()

//GuestBookMethods.GuestNames();

//GuestBookMethods.AreThereMoreGuests();

//Ask the guest how many people are in their family and each of their names. - FamilyMemberNames() , FamilyCount()

//Keep track of how many people are in the guests family. - FamilyCount()

//Keep track of how many people there are total at the entire party. - TotalPersonCount()

//Print out the guest book, including the names of the individual families, the individual members of each family,
//the total count in each family, and the total count of people at the entire party. 