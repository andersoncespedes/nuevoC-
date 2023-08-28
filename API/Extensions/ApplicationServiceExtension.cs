using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;
namespace API.Extensions;

public static class ApplicationServiceExtension
{
    public static void ConfigureApiVersioning(this IServiceCollection services){
        services.AddApiVersioning(options => {
            options.DefaultApiVersion = new ApiVersion(1,0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("v"),
                new HeaderApiVersionReader("X-Version")
            );
            options.ReportApiVersions = true;
        });
    }
    public static void ConfigureRateLimiting(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<IRateLimitConfiguration,RateLimitConfiguration>();
            services.AddInMemoryRateLimiting();
            services.Configure<IpRateLimitOptions>(option => {
                option.EnableEndpointRateLimiting = true;
                option.StackBlockedRequests = false;
                option.HttpStatusCode = 429;
                option.RealIpHeader = "X-Reañ-IP";
                option.GeneralRules = new List<RateLimitRule>()
                {
                    new RateLimitRule
                    {
                        Endpoint = "*",
                        Period = "10s",
                        Limit = 2
                    }
                };
            });
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.WithOrigins("localhost")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
        }
}
