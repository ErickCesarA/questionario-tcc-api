using Microsoft.EntityFrameworkCore;
using questionario_tcc_api.Data;
using questionario_tcc_api.Repositorios;
using questionario_tcc_api.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var DataBaseMySql = builder.Configuration.GetConnectionString("DataBase");
builder.Services.AddDbContext<RegistroDePacientesDbContext>
    (options => options.UseMySql(DataBaseMySql,
    ServerVersion.Parse("MySQl 8.0.32")));

//builder.Services.AddEntityFrameworkSqlServer().AddDbContext<RegistroDePacientesDbContext>
//   (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPacienteRepos, PacienteRepos>();

builder.Services.AddCors(options => options.AddPolicy(name: "QuetionarioTccOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200","https://ui-questionario-tcc.herokuapp.com").AllowAnyMethod().AllowAnyHeader();
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/Swagger.json", "questionario_tcc_api"); });

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseCors("QuetionarioTccOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
