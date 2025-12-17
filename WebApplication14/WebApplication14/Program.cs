var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("map1", async context =>
{
    await context.Response.WriteAsync("Hello from map1");
});

app.Run();
