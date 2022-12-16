using AspTest.AnimalDb;
using AspTest.AnimalDb.Tables;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

using (var client = new AnimalDbContext())
{
    var animals = client.Students.ToList();
    var animal = new Animal()
    {
        Name = "Koala"
    };
    client.Add(animal);
    client.SaveChanges();
}

app.Run();


