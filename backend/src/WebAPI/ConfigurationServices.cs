using System.Text;
using Microsoft.OpenApi;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using DataAccessLayer.ContextDB.EFCore;
using Entities.Concrete.Auth;

namespace WebAPI;

public static class ConfigurationServices
{
    public static IServiceCollection AddWebApiConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(options => 
        {
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                Description = "Enter the JWT token **without** the 'Bearer ' prefix.\n\nExample: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
            });
            options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
            {
                [new OpenApiSecuritySchemeReference("Bearer", document)] = []
            });
            options.DocInclusionPredicate((docName, apiDesc) => true);
        });
        
        services.AddControllers();

        services.AddIdentity<AppUser, IdentityRole<Guid>>()
            .AddEntityFrameworkStores<ECommerceDbContext>()
            .AddDefaultTokenProviders();
        // services.AddIdentityCore<AppUser>(opt =>
        //     {
        //         opt.Password.RequireDigit = false;
        //         opt.Password.RequiredLength = 8;
        //         opt.Password.RequireNonAlphanumeric = false;
        //         opt.Password.RequireUppercase = false;
        //     })
        //     .AddRoles<IdentityRole<Guid>>()
        //     .AddEntityFrameworkStores<ECommerceDbContext>();

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            var tokenOptions = configuration.GetSection("TokenOptions").Get<Entities.Concrete.Auth.TokenOptions>();
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidIssuer = tokenOptions.Issuer,
                ValidAudience = tokenOptions.Audience,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey)),
                ClockSkew = TimeSpan.Zero
            };
        });
        services.AddAuthorization();

        services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });

        return services;
    }
}
