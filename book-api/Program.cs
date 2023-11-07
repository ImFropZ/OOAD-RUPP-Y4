var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

new BookRepo().Init();

app.MapGet("/api/books", () =>
{
    BookService bookService = new BookService(new BookRepo());
    var response = bookService.Query(null);
    return response;
})
.WithName("QueryBook")
.WithOpenApi();

app.MapGet("/api/books/{key}", (String key) =>
{
    BookService bookService = new BookService(new BookRepo());
    var response = bookService.Query(key);
    return response;
});

app.MapPost("/api/books", (BookCreate book) =>
{
    BookService bookService = new BookService(new BookRepo());
    var response = bookService.Create(book);
    return response;
});

app.MapPut("/api/books", (BookUpdate book) =>
{
    BookService bookService = new BookService(new BookRepo());
    var response = bookService.Update(book);
    return response;
});

app.MapDelete("/api/books/{key}", (String key) =>
{
    BookService bookService = new BookService(new BookRepo());
    var response = bookService.Delete(key);
    return response;
});

app.Run();
