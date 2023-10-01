namespace helloLib;

public class Hello
{
  public string Message { get; set; } = "Hello";
  public TextWriter Output { get; set; } = Console.Out;
  public void WriteOut () => Output.WriteLine(Message);
}
