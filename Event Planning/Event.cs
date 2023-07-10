public class Event
{
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

 

    public void DisplayStandardInfo()
    {
        Console.WriteLine($"{_title} -- {_description}\n{_date}-{_time}\n{_address.GetAddress()}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_eventType} : {_title}\n{_date}");
    }
}