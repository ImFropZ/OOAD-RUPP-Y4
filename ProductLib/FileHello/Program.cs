using helloLib; // Include the helloLib namespace

class Program
{
    static void Main()
    {
        var sw = File.AppendText("output.txt");
        Hello hello1 = new(){Output = sw};
        Hello hello2 = new()
        {
          Output = sw,
          Message = "Hi, everybody"
        };

        hello1.WriteOut();
        hello2.WriteOut();
        sw.Close();
    }
}
