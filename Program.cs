using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Add CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()   // Allow any origin to make requests
              .AllowAnyHeader()   // Allow any header in requests
              .AllowAnyMethod();  // Allow any HTTP method
    });
});

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

// Enable Swagger and SwaggerUI in Development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // Swagger UI at the root (e.g., http://localhost:5168/)
    });
}

// Use CORS middleware before routing
app.UseCors("AllowAll");

// Use routing and authorization middleware
app.UseRouting();
app.UseAuthorization();

// Map the API endpoints
app.MapControllers();

app.Run();

