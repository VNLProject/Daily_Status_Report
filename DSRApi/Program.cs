//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
using DSR_BL.DSR;
using DSR_BL.DSR.IMPL;
using DSRApi.Utility;

var builder = WebApplication.CreateBuilder(args);
Utility.MapDependency(builder);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.UseCors(
        options => options.WithOrigins("http://localhost:4200",
                                              "https://localhost:7014").AllowAnyMethod()
    );

app.Run();
