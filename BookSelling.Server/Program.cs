using BookSelling.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Configuration.GetValue<bool>("UseDeveloperExceptionPage"))
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}


app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("api/error", () => Results.Problem());
app.MapGet("api/error/test", _ => throw new Exception("Test"));

app.Run();