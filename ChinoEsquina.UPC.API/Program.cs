var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Habilitar el CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "ChinoEsquinaPolicy",
        policy =>
        {
            policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

//Configuracion del server para el deploy
var app = builder.Build();
app.Urls.Add("http://172.31.36.151:5000");
app.Urls.Add("http://localhost:5000");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ChinoEsquinaPolicy"); //Agregado

app.UseAuthorization();

app.MapControllers();

app.Run();
