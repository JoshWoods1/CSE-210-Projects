Address LectureAddress = new Address("1234 State Street", "Rexburg", "Idaho", "USA");
Address ReceptionAddress = new Address("7653 County Road","Houston", "Texas", "USA");
Address OutdoorAddress = new Address("8765 Street Avenue", "Idaho Falls", "Idaho", "USA");

Lectures lecture = new Lectures("John Brown", 100, LectureAddress);
Console.WriteLine("Lecture Event\n----------");
Console.WriteLine("Standard Details");
lecture.DisplayStandardInfo();
Console.WriteLine("\nFull Details");
lecture.DisplayLectureDetails();
Console.WriteLine("\nShort Details");
lecture.DisplayShortDescription();

Reception rec = new Reception("email@gmail.com", ReceptionAddress);
Console.WriteLine();
Console.WriteLine("Reception Event\n----------");
Console.WriteLine("Standard Details");
rec.DisplayStandardInfo();
Console.WriteLine("\nFull Details");
rec.DisplayReceptionDetails();
Console.WriteLine("\nShort Details");
rec.DisplayShortDescription();

Outdoor concert = new Outdoor("sunny", OutdoorAddress);
Console.WriteLine();
Console.WriteLine("Outdoor Event\n----------");
Console.WriteLine("Standard Details");
concert.DisplayStandardInfo();
Console.WriteLine("\nFull Details");
concert.DisplayOutdoorDetails();
Console.WriteLine("\nShort Details");
concert.DisplayShortDescription();


