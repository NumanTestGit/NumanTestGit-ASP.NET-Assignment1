var builder = WebApplication.CreateBuilder();


var app = builder.Build();

app.MapPost("/authenticator/login", () => "Handles Login");
app.MapPost("/authenticator/register", () => "Handles Registration");
app.MapGet("/authenticator/logout", () => "Handles Logout");

app.MapGet("/Dashboard", () => "Returns Dashboard Data");

app.MapGet("/Books", () => "Lists All The Books In The System");
app.MapPost("/Books", () => "Adds A New Book");
app.MapGet("/Books/{bookId}", (int bookId) => $"Returns Details For Book With ID {bookId}");
app.MapPut("/Books/{bookId}", (int bookId) => $"Updates Details For Book With ID {bookId}");
app.MapDelete("/Books/{bookId}", (int bookId) => $"Deletes Book With ID {bookId}");

app.MapGet("/Borrowings", () => "Lists All Borrowings");
app.MapPost("/Borrowings", () => "Creates a New Borrowing Record");
app.MapGet("/Borrowings/{borrowingId}", (int borrowingId) => $"Retrieves a Specific Borrowing Record by using its ID {borrowingId}");
app.MapPut("/Borrowings/{borrowingId}", (int borrowingId) => $"Updates a Specific Borrowing Record by using its ID {borrowingId}");
app.MapDelete("/Borrowings/{borrowingId}", (int borrowingId) => $"Deletes a Specific Borrowing Record by using its ID {borrowingId}");

app.MapGet("/Readers", () => "Lists All Readers");
app.MapPost("/Readers", () => "Adds a New Reader");
app.MapGet("/Readers/{readerId}", (int readerId) => $"Retrieves a Specific Reader's Details by using its ID {readerId}");
app.MapPut("/Readers/{readerId}", (int readerId) => $"Updates a Specific Reader's Details by using its ID {readerId}");
app.MapDelete("/Readers/{readerId}", (int readerId) => $"Deletes a Specific Reader by using its ID {readerId}");

app.MapGet("/Reports/borrowings", () => "Generates Borrowings Report");
app.MapGet("/Reports/books", () => "Generates Books Report");
app.MapGet("/Reports/readers", () => "Generates Readers Report");

app.MapGet("/Overdue/check", () => "Checks Overdue Books and Calculates Charges");
app.MapGet("/Overdue/charges/{borrowingId}", (int borrowingId) => $"Retrieves Overdue Charges for a Specific Borrowing by using its ID {borrowingId}");

app.Run();
