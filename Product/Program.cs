using ProductLib;

class Program
{
    static void Main()
    {
      ProductRepo repo = new ProductRepo();
      repo.Initialize();

      System.Console.ForegroundColor = System.ConsoleColor.Green;
      System.Console.WriteLine("Read all products");
      System.Console.ResetColor();

      var products = repo.ReadAll();
      foreach (var product in products)
      {
        System.Console.WriteLine($"+ Product {product.Code} - {product.Name} - C:{product.Category}");
      }

      repo.Create(new ProductCreateReq(){
        Code = "PRD004",
        Name = "TShirt-SEA game 2027",
        Category = "Cloth"
      });

      System.Console.ForegroundColor = System.ConsoleColor.Green;
      System.Console.WriteLine("After create new product");
      System.Console.ResetColor();

      products = repo.ReadAll();
      foreach (var product in products)
      {
        System.Console.WriteLine($"+ Product {product.Code} - {product.Name} - C:{product.Category}");
      }
    }
}