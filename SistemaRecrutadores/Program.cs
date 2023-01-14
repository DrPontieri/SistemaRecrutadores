using Dominio.Interface;
using Dominio.UnitOfWork;
using InfraEstrutura;
using InfraEstrutura.Repository;
using InfraEstrutura.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddTransient(typeof(IUserService), typeof(UserService));
builder.Services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddTransient(typeof(ITecnologiaRepository), typeof(TecnologiaRepository));
builder.Services.AddTransient(typeof(ITipoTecnologiaRepository), typeof(TipoTecnologiaRepository));


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<SistemaDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnection"),
                b => b.MigrationsAssembly(typeof(SistemaDbContext).Assembly.FullName)));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "RecrutadoresWeb", Version = "v1" });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
                policy =>
                {
                    policy.WithOrigins("https://localhost:4200", "https://localhost:7274")
                            .WithMethods("PUT", "DELETE", "GET", "POST")
                            .AllowAnyHeader();
                });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RecrutadoresWeb v1"));
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
