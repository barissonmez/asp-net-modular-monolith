using FiftyNine.ModularMonolith.OrderManagement.Module.Extensions;
using FiftyNine.ModularMonolith.UserManagement.Module.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.AddOrdersModule();
builder.AddUsersModule();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

// Required for testing...
public partial class ApiProgram
{

}
