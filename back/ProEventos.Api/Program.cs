using Microsoft.EntityFrameworkCore;
using ProEventos.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<ProEventosContexto>(options => options.UseSqlite("Data Source=MyDb.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

