using GuestBook;

//Keep in mind DRY. Don't Repeat Yourself - Use as many methods as you can to avoid repeat code.

GuestBookMethods.PartyGuests();

Console.Write("Are there more guests? ");
string moreGuests = Console.ReadLine();

while (moreGuests.ToLower() == "yes")
{
    GuestBookMethods.PartyGuests();
}

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