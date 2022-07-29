using GuestBook;

//Keep in mind DRY. Don't Repeat Yourself - Use as many methods as you can to avoid repeat code.

GuestLogic.WelcomeMessage();

(List<string> guests, int totalGuests) = GuestLogic.GetAllGuests();

GuestLogic.DisplayGuests(guests);

GuestLogic.DisplayGuestsCount(totalGuests);