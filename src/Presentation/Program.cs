using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Application.Interfaces;
using Application.Services;
using Presentation.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("FreelancerConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Inyeccion de dependencias para repositorios
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IFreelancerRepository, FreelancerRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();

// Inyeccion de dependencias para servicios
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IFreelancerService, FreelancerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<IUserService, UserService>();

// Inyeccion del middleware de manejo de excepciones
builder.Services.AddTransient<CentralizedExceptionMiddleware>();

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

app.Run();
