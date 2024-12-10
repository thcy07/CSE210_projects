using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Cityville", "CA", "12345");
        Lecture lecture = new Lecture(
            "Tech Talk", 
            "AI in Modern Society", 
            "2024-12-15", 
            "10:00 AM", 
            "Lecture", 
            lectureAddress, 
            "Dr. John Smith", 
            200
        );
        Console.WriteLine("=== Lecture Event ===");
        Console.WriteLine($"Standard Description:\n{lecture.GetStandardDescription()}");
        Console.WriteLine($"Full Description:\n{lecture.GetFullDescription()}");
        Console.WriteLine($"Short Description:\n{lecture.GetShortDescription()}");
        Console.WriteLine();

        
        Address receptionAddress = new Address("456 Elm St", "Townsville", "NY", "54321");
        Reception reception = new Reception(
            "Wedding Reception", 
            "Celebrate our marriage!", 
            "2024-12-20", 
            "7:00 PM", 
            "Reception", 
            receptionAddress, 
            "rsvp@wedding.com"
        );
        Console.WriteLine("=== Reception Event ===");
        Console.WriteLine($"Standard Description:\n{reception.GetStandardDescription()}");
        Console.WriteLine($"Full Description:\n{reception.GetFullDescription()}");
        Console.WriteLine($"Short Description:\n{reception.GetShortDescription()}");
        Console.WriteLine();

        
        Address outdoorEventAddress = new Address("789 Pine Ave", "Springfield", "IL", "62704");
        OutdoorGathering outdoorEvent = new OutdoorGathering(
            "Spring Festival", 
            "Celebrate the arrival of spring with music, food, and fun!", 
            "2024-04-15", 
            "10:00 AM", 
            "Outdoor Gathering", 
            outdoorEventAddress, 
            "Sunny with a chance of clouds"
        );
        Console.WriteLine("=== Outdoor Gathering ===");
        Console.WriteLine($"Standard Description:\n{outdoorEvent.GetStandardDescription()}");
        Console.WriteLine($"Full Description:\n{outdoorEvent.GetFullDescription()}");
        Console.WriteLine($"Short Description:\n{outdoorEvent.GetShortDescription()}");
        Console.WriteLine();
    }
}