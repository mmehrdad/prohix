
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json.Serialization;
using System.Text;
using Prohix.Infrastracture.Utilities;
using Prohix.Infrastracture.DBContexts;
using Prohix.Core.Entities.Students;
using Prohix.Core.Entities.Identity;
using Prohix.Api.Configuration;
using Microsoft.OpenApi.Models;
using Prohix.Api.Helper;
using Prohix.Core.Entities.Teachers;



// Add services to the container.
// string conn = AppConfig.GetConnectionString("WebRazorDatabase");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataBaseContext>();

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<DataBaseContext>()
            .AddDefaultTokenProviders();

// builder.Services.AddIdentity<Teacher, Role>()
//    .AddEntityFrameworkStores<DataBaseContext>()
//            .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 5;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
});

// Configure the HTTP request pipeline.

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var key = Encoding.ASCII.GetBytes(AppConfig.GetSection("JwtSettings", "Secret"));

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;


})

.AddJwtBearer(x =>
{

    x.RequireHttpsMetadata = false;
    x.Audience = AppConfig.GetSection("JwtSettings", "Audience");
    x.ClaimsIssuer = AppConfig.GetSection("JwtSettings", "Issuer");
    x.SaveToken = true;


    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidIssuer = AppConfig.GetSection("JwtSettings", "Issuer"),
        ValidAudience = AppConfig.GetSection("JwtSettings", "Audience"),

        RequireExpirationTime = true,

    };
});

builder.Services.InjectDependency();
builder.Services.AddSignalR(options =>
{
    options.MaximumReceiveMessageSize = long.MaxValue;
    options.EnableDetailedErrors = true;
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "SAMAK",
        Description = "RasadGroup User Management Service",
        Contact = new OpenApiContact
        {
            Name = "Mehrdad Momeni",
            Email = "m.momeni166@gmail.com",

        },
        License = new OpenApiLicense
        {
            Name = "Use under Gpl v3 License",

        }
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
       {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                            },
                            new List<string>()
                        }
                    });
});


builder.Services.AddODataQueryFilter();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers().AddOData(
    options => options.Select().Filter().OrderBy().Expand().Count().SetMaxTop(null).Count().AddRouteComponents(
    routePrefix: "odata",
        model: ODataRouteMapper.GetEdmModel()));

//------------------------------------------------
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost",
                "http://localhost:4200",
                "https://localhost:7230",
                "http://localhost:90",
                "http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});

builder.Services.AddHttpClient();



//------------------------------------------------

var app = builder.Build();

app.UseRouting();


//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();

//}


//--------------------------------------
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//----------------------------------------

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

builder.Services.AddControllers();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
