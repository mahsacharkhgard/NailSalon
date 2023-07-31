using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Reservation.Application.Contract.Commons;
using Reservation.Application.Contract.IServices.ICustomers;
using Reservation.Application.Contract.IServices.IDesignNails;
using Reservation.Application.Contract.IServices.INailServices;
using Reservation.Application.Contract.IServices.IPersonnels;
using Reservation.Application.Contract.IServices.Users;
using Reservation.Application.Contract.MappingConfiguration;
using Reservation.Application.Services.Customers;
using Reservation.Application.Services.DesignNails;
using Reservation.Application.Services.NailServices;
using Reservation.Application.Services.Personnels;
using Reservation.Application.Services.Users;
using Reservation.EndPoint.API.Middlewares;
using Reservation.Infrastructure.Contexts;
using Reservation.Infrastructure.IRepositories;
using Reservation.Infrastructure.Repositories;
using Reservation.Model.IdentityModels;
using System.Globalization;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4000")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
    });
});

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Ordering HTTP API",
        Version = "v1",
        Description = "The Ordering Service HTTP API",
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the bearer scheme",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});

builder.Services.AddHttpClient();

RegisterServices(builder);

builder.Services.AddDbContext<ReservationContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Reservation")));


builder.Services.Configure<ImagePathProvider>(x => x.ImagePath = builder.Configuration.GetValue<string>("ImagePath"));

ImagePathProvider.HttpImagePath = builder.Configuration.GetValue<string>("HttpImagePath");

builder.Services
    .AddIdentityCore<ApplicationUser>()
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<ReservationContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
   .AddJwtBearer(cfg =>
   {
       cfg.TokenValidationParameters = new TokenValidationParameters()
       {
           ValidateIssuer = false,
           ValidateAudience = false,
           ValidateIssuerSigningKey = true,
           RequireExpirationTime = true,
           IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("vjhgjhgbk32ییسشjkjloij6576hiuhiujhgh87y"))
       };
   });


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin",
 policyBuilder => policyBuilder.RequireRole("Admin"));
});

builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseMiddleware(typeof(CustomExceptionHandlerMiddleware));

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

static IServiceScope SeedRole(WebApplication app)
{
    var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();

    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    if (roleManager.FindByNameAsync("USER").GetAwaiter().GetResult() == null)
    {
        roleManager.CreateAsync(new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = "User",
            NormalizedName = "USER"
        }).GetAwaiter().GetResult();
    }

    return scope;

}

static void RegisterServices(WebApplicationBuilder builder)
{
    builder.Services.AddScoped<INailServiceService, NailServiceService>();
    builder.Services.AddScoped<INailServiceRepository, NailServiceRepository>();

    builder.Services.AddScoped<IDesignNailService, DesignNailService>();
    builder.Services.AddScoped<IDesignNailRepository, DesignNailRepository>();

    builder.Services.AddScoped<ICustomerService, CustomerService>();
    builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

    builder.Services.AddScoped<IPersonnelService, PersonnelService>();
    builder.Services.AddScoped<IPersonnelRepository, PersonnelRepository>();

    builder.Services.AddScoped<IUserService, UserService>();
    builder.Services.AddScoped<ITokenHandler, Reservation.EndPoint.API.Securities.TokenHandler>();

    builder.Services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));

}


