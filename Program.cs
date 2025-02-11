using Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<CatDto> cats = new List<CatDto>{
    new("1", "https://cdn2.thecatapi.com/images/1g5.jpg", 1280, 1280),
    new("2", "https://cdn2.thecatapi.com/images/1g5.jpg", 1280, 1280),
};



app.MapGet("/cats", () => cats);

app.MapPost("/", () => "Created a cat!");

app.Run();



