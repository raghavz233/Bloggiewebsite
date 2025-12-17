using Routing.CustomConstraints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months", typeof(Months));
   } );
var app = builder.Build();

app.Map("product/details/{id?}", async context =>
{
    int id = Convert.ToInt32(context.Request.RouteValues["id"]);
    await context.Response.WriteAsync($"Product Details for product id - {id}");
});
app.Map("daily-digest-report/{reportdate:datetime}", async (context)
    =>
{
    DateTime reportdate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
    await context.Response.WriteAsync($"Daily Digest Report for date : {reportdate.ToShortDateString()}");
}
);

app.Map("sales-report/{year:int:min(1900)}/{month:months}", async context =>
{
    int year = Convert.ToInt32(context.Request.RouteValues["year"]);
    string? month = Convert.ToString(context.Request.RouteValues["month"]);
    await context.Response.WriteAsync($"sales report -{year} -{month}");
}
);

app.MapFallback(async context =>
{
    await context.Response.WriteAsync("In fallback");
});
app.Run();