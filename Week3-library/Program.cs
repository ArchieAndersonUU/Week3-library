using Week3_library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        Console.WriteLine("Currently available books");
        book.DisplayInfo();
        book1.DisplayInfo();


        Member member = new Member(1, "John Smith", "1 high street", 0776594365);
        Member member1 = new Member(2, "Mary jones", "2 high street", 0776594365);
        Console.WriteLine("Current library members");
        member.DisplayInfo();   
        member1.DisplayInfo();
    }
}