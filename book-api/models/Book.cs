class Book
{
    public int Id { get; set; }
    public string Key { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book()
    {
        Key = Guid.NewGuid().ToString();
        Title = Author = Key = "";
    }
}

class BookResponse
{
    public string Key { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public BookResponse(Book book)
    {
        Key = book.Key;
        Title = book.Title;
        Author = book.Author;
    }
}

class BookCreate
{
    public string Key { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public BookCreate()
    {
        Title = Author = Key = "";
    }
}

class BookUpdate
{
    public string Key { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }

    public BookUpdate()
    {
        Title = Author = Key = "";
    }
}
