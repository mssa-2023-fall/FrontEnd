var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//
builder.Services.AddDistributedMemoryCache();

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

app.UseMaintenanceMiddleware();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

//i think we need to check if we close the page and then comeback to it. but we are in dev mode
//im going to push this to the repo
//store values in cookie upon hitting calculate
//look for and retrieve values when page reloaded

