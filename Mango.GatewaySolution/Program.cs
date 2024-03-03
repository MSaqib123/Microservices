using Mango.GatewaySolution.Extensions;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

//================= Registration ======================

//--- Authenticaiton --
builder.AddAppAuthentication();

//--- Ocelote ----
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);



//================= Pipline ======================
//app.MapGet("/", () => "Hello World!");
var app = builder.Build();
app.UseOcelot().GetAwaiter().GetResult();

app.Run();
