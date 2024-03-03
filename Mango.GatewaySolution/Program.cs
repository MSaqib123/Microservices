using Mango.GatewaySolution.Extensions;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//================= Registration ======================
//--- Ocelote ----
builder.AddAppAuthentication();
builder.Services.AddOcelot();



//================= Pipline ======================
//app.MapGet("/", () => "Hello World!");
var app = builder.Build();
app.UseOcelot();

app.Run();
