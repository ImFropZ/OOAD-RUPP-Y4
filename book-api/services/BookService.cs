class BookService {
  private BookRepo _bookRepo;

  public BookService(BookRepo bookRepo) {
    _bookRepo = bookRepo;
  }

  public APIResponse<List<BookResponse>> Query(String? key) {
    var books = _bookRepo.Query(key);
    var bookResponses = books.Select(b => new BookResponse {
      Key = b.Key,
      Title = b.Title,
      Author = b.Author
    }).ToList();
    return new APIResponse<List<BookResponse>> {
      Succeded = true,
      Message = "Success",
      Data = bookResponses
    };
  }

  public APIResponse<String?> Create(BookCreate bookCreate) {
    var book = new Book {
      Key = bookCreate.Key,
      Title = bookCreate.Title,
      Author = bookCreate.Author
    };
    var key = _bookRepo.Create(book);
    if (key == null) {
      return new APIResponse<String?> {
        Succeded = false,
        Message = "Book already exists",
        Data = null
      };
    }
    return new APIResponse<String?> {
      Succeded = true,
      Message = "Success",
      Data = key
    };
  }

  public APIResponse<String?> Update(BookUpdate bookUpdate) {
    var book = new Book {
      Key = bookUpdate.Key,
      Title = bookUpdate.Title,
      Author = bookUpdate.Author
    };
    var key = _bookRepo.Update(book);
    if (key == null) {
      return new APIResponse<String?> {
        Succeded = false,
        Message = "Book does not exist",
        Data = null
      };
    }
    return new APIResponse<String?> {
      Succeded = true,
      Message = "Success",
      Data = book.Key
    };
  }
}