public class Reception : Event
{
    string _email;

    public Reception(string email, Address address)
    {
        _email = email;
        _eventType = "Reception";
        _title = "John and Mary's Wedding";
        _description = "We are celebrating the marraige of John Brown and Mary Johnson";
        _date = "July 29, 2023";
        _time = "1:00 PM";
        _address = address;
    }

    public void DisplayReceptionDetails()
    {
        Console.WriteLine($"Event: {_eventType}\n{_title}\nWhat is it? : {_description}\nWhere? : {_address.GetAddress()}\nWhen? : {_date} - {_time}");
        Console.WriteLine($"Please RSVP to {_email}!");
    }
}