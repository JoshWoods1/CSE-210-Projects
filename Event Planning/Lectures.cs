public class Lectures : Event
{
    string _speakerName;
    int _capacity;

    public Lectures(string SpeakerName, int capacity, Address address)
    {
        _speakerName = SpeakerName;
        _capacity = capacity;
        _eventType = "Lecture";
        _title = "How to Be a Better Person";
        _description = "This event will discuss different ways to increase your quality of life and help you help others do the same";
        _date = "July 20, 2023";
        _time = "6:00 PM";
        _address = address;
    }

     public void DisplayLectureDetails()
    {
        Console.WriteLine($"Event: {_eventType}\nWhat is discussed? : {_title}\nWhat is it? : {_description}\nWho? : {_speakerName}\nWhere? : {_address.GetAddress()}\nWhen? : {_date} - {_time}\nEvent is limited to {_capacity} people.*");
    }


}