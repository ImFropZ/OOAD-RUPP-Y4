  class Book {
      public int Id { get; set; }
      public string Key { get; set; }
      public string Title { get; set; }
      public string Author { get; set; }   
  }

  class BookResponse {
      public string Key { get; set; }
      public string Title { get; set; }
      public string Author { get; set; }   
  }

  class BookCreate {
      public string Key { get; set; }
      public string Title { get; set; }
      public string Author { get; set; }   
  }

  class BookUpdate {
      public string Key { get; set; }
      public string? Title { get; set; }
      public string? Author { get; set; }   
  }