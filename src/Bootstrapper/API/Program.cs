var builder = WebApplication.CreateBuilder(args);

//Add Services to the container

var app = builder.Build();

// Configuer the Http  request pipline

app.Run();
