using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace HelloMediatR.Configuration;

public static class CustomOtel
{
    public static IServiceCollection AddCustomOtel(this IServiceCollection services)
    {
        services.AddOpenTelemetry()
            .ConfigureResource(resource => resource.AddService("HelloMediatR"))
            .WithMetrics(metrics =>
            {
                metrics.AddAspNetCoreInstrumentation()
                .AddHttpClientInstrumentation();

                metrics.AddOtlpExporter();
            })
            .WithTracing(tracing =>
            {
                tracing.AddAspNetCoreInstrumentation()
                .AddHttpClientInstrumentation()
                .AddEntityFrameworkCoreInstrumentation();

                tracing.AddOtlpExporter();
            });

        return services;
    }
}