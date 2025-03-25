﻿using System.Text;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.APPLICATION.DependencyInjection.Options;
using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.Constrants;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.API.DependencyInjection.Extensions;
public static class JwtExtensions
{
    public static void AddJwtAuthenticationAPI(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddGoogle(options =>
            {
                options.ClientId = "12312313";
                options.ClientSecret = "1231231231";
            })
            .AddJwtBearer(o =>
            {
                JwtOption jwtOption = new();
                configuration.GetSection(nameof(JwtOption)).Bind(jwtOption);

                /**
                 * Storing the JWT in the AuthenticationProperties allows you to retrieve it from elsewhere within your application.
                 * public async Task<IActionResult> SomeAction()
                    {
                        // using Microsoft.AspNetCore.Authentication;
                        var accessToken = await HttpContext.GetTokenAsync("access_token");
                        // ...
                    }
                 */
                o.SaveToken = true; // Save token into AuthenticationProperties

                var Key = Encoding.UTF8.GetBytes(jwtOption.SecretKey);
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // on production make it true
                    ValidateAudience = true, // on production make it true
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtOption.Issuer,
                    ValidAudience = jwtOption.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Key),
                    ClockSkew = TimeSpan.Zero
                };

                o.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("IS-TOKEN-EXPIRED", "true");
                        }

                        return Task.CompletedTask;
                    }
                };

                //o.EventsType = typeof(CustomJwtBearerEvents);
            });


        services.AddAuthorizationBuilder()
            .AddPolicy(Constant.Role.CLINIC_STAFF, po => po.RequireRole(Constant.Role.CLINIC_STAFF))
            .AddPolicy(Constant.Role.CLINIC_ADMIN, po => po.RequireRole(Constant.Role.CLINIC_ADMIN))
            .AddPolicy(Constant.Role.DOCTOR, po => po.RequireRole(Constant.Role.DOCTOR))
            .AddPolicy(Constant.Role.CUSTOMER, po => po.RequireRole(Constant.Role.CUSTOMER))
            .AddPolicy(Constant.Role.SYSTEM_ADMIN, po => po.RequireRole(Constant.Role.SYSTEM_ADMIN))
            .AddPolicy(Constant.Role.SYSTEM_STAFF, po => po.RequireRole(Constant.Role.SYSTEM_STAFF));
        // services.AddScoped<CustomJwtBearerEvents>();
    }
}