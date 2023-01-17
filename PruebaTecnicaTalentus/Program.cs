using DAL;
using Microsoft.EntityFrameworkCore;
using Services.CitiesServices;
using Services.EmailService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ConfigurationManager configuration = builder.Configuration;
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<TalentusDB>(opt => opt.UseNpgsql(configuration.GetConnectionString("PruebaTecnica")));

builder.Services.AddAutoMapper(typeof(Program));

// Inyeccion de dependecias 
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ICitiesServices, CitiesServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

UpdateDatabase(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void UpdateDatabase(IApplicationBuilder app)
{
    using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
    {
        using (var context = serviceScope.ServiceProvider.GetService<TalentusDB>())
        {
            if (context is not null)
            {
                context.Database.Migrate();
            }
        }
    }
}