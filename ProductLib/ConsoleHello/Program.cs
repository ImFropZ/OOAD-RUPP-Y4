using helloLib; // Include the helloLib namespace

class Program
{
    static void Main()
    {
        Hello hello1 = new Hello();
        Hello hello2 = new Hello
        {
            Message = "Hello, World!"
        };

        hello1.WriteOut(); // This will print "Hello" to the console
        hello2.WriteOut(); // This will print "Hello, World!" to the console
    }
}
