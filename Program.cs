var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/todoitems", () => {});
app.MapGet("/todoitems/{id}", (string id) => {
    var toDoItem = new {
        ID = Guid.NewGuid().ToString(),
        Title = "Complete Todo in C#",
        IsComplete = false
    };
    return Results.Ok(toDoItem);
});
app.MapPost("/todoitems", () => {});
app.MapPut("/todoitems/{id}", (string id) => {});
app.MapDelete("/todoitems/{id}", (string id) => {});

app.Run();
