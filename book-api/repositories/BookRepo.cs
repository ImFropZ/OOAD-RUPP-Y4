  class BookRepo {
    private static List<Book> _books = new List<Book>();

    public void Init() {
      _books.Add(new Book {
        Key = "1",
        Title = "The Fellowship of the Ring",
        Author = "J.R.R. Tolkien"
      });

      _books.Add(new Book {
        Key = "2",
        Title = "The Two Towers",
        Author = "J.R.R. Tolkien"
      });

      _books.Add(new Book {
        Key = "3",
        Title = "The Return of the King",
        Author = "J.R.R. Tolkien"
      });

      _books.Add(new Book {
        Key = "4",
        Title = "The Hobbit",
        Author = "J.R.R. Tolkien"
      });
    }

    public List<Book> Query(String? key) {
      if (key != null) {
          return _books;
      }
      return _books;
    }

    public String? Create(Book book) {
      if (_books.Any(b => b.Key == book.Key)) {
        return null;
      }
      _books.Add(book);
      return book.Key;
    }

    public bool Update(Book book) {
      var bookToUpdate = _books.FirstOrDefault(b => b.Key == book.Key);
      if (bookToUpdate == null) {
        return false;
      }
      bookToUpdate.Title = book.Title;
      bookToUpdate.Author = book.Author;
      return true;
    }
  }