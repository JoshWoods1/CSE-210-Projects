public class Outdoor : Event
{
 string _weather;


 public Outdoor(string weather, Address address)
 {
    _weather = weather;
    _eventType = "Outdoor Gathering";
    _title = "Concert in the Park";
    _description = "Come listen to local live music and have a fun time!";
    _date = "August 15, 2023";
    _time = "7:00 PM";
    _address = address;
}

     public void DisplayOutdoorDetails()
    {
        Console.WriteLine($"Event: {_eventType}\n{_title}\n{_description}\nWhere? : {_address.GetAddress()}\nWhen? : {_date} - {_time}\nThe weather will be {_weather}");
    }
}