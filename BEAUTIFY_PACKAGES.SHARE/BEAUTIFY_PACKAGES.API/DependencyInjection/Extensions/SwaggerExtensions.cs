﻿using BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.API.DependencyInjection.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.API.DependencyInjection.Extensions;

public static class SwaggerExtensions
{
    public static void AddSwaggerAPI(this IServiceCollection services)
    {
        services.AddSwaggerGen();
        services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
    }

    public static void UseSwaggerAPI(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            foreach (var version in app.DescribeApiVersions().Select(version => version.GroupName))
                options.SwaggerEndpoint($"/swagger/{version}/swagger.json", version);

            options.DisplayRequestDuration();
            options.EnableTryItOutByDefault();
            options.DocExpansion(DocExpansion.None);
        });

        app.MapGet("/", () => Results.Redirect("/swagger/index.html"))
            .WithTags(string.Empty);
    }
}
