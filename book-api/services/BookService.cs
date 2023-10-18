class BookService
{
    private BookRepo _bookRepo;

    public BookService(BookRepo bookRepo)
    {
        _bookRepo = bookRepo;
    }

    public APIResponse<List<BookResponse>> Query(String? key)
    {
        var books = _bookRepo.Query(key);
        var bookResponses = books.Select(b => new BookResponse(b)).ToList();
        return new APIResponse<List<BookResponse>>
        {
            Succeded = true,
            Message = "Success",
            Data = bookResponses
        };
    }

    public APIResponse<String?> Create(BookCreate bookCreate)
    {
        var book = new Book
        {
            Key = bookCreate.Key,
            Title = bookCreate.Title,
            Author = bookCreate.Author
        };
        var key = _bookRepo.Create(book);
        if (key == null)
        {
            return new APIResponse<String?>
            {
                Succeded = false,
                Message = "Book already exists",
                Data = null
            };
        }
        return new APIResponse<String?>
        {
            Succeded = true,
            Message = "Success",
            Data = key
        };
    }

    public APIResponse<String?> Update(BookUpdate bookUpdate)
    {
        if (bookUpdate.Key == null)
            return new APIResponse<String?>
            {
                Succeded = false,
                Message = "Key is required",
                Data = null
            };

        if (bookUpdate.Title == null && bookUpdate.Author == null)
        {
            return new APIResponse<String?>
            {
                Succeded = false,
                Message = "Title or Author is required",
                Data = null
            };
        }

        var book = new Book { Key = bookUpdate.Key, };

        if (bookUpdate.Title != null)
        {
            book.Title = bookUpdate.Title;
        }

        if (bookUpdate.Author != null)
        {
            book.Author = bookUpdate.Author;
        }

        var isUpdated = _bookRepo.Update(book);
        if (!isUpdated)
        {
            return new APIResponse<String?>
            {
                Succeded = false,
                Message = "Book does not exist",
                Data = null
            };
        }
        return new APIResponse<String?>
        {
            Succeded = true,
            Message = "Success",
            Data = book.Key
        };
    }

    public APIResponse<String?> Delete(String key)
    {
        var isDeleted = _bookRepo.Delete(key);
        if (isDeleted)
        {
            return new APIResponse<String?>
            {
                Succeded = false,
                Message = "Book does not exist",
                Data = null
            };
        }
        return new APIResponse<String?>
        {
            Succeded = true,
            Message = "Success",
            Data = key
        };
    }
}
