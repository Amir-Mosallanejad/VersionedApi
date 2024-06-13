using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace VersionedApi.RandomHealthChecks
{
    public class RandomHealthChecks : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            int ping = Random.Shared.Next(300);
            if (ping < 100)
            {
               return Task.FromResult(HealthCheckResult.Healthy($"Ping is {ping}"));
            }
            else
            {
               return Task.FromResult(HealthCheckResult.Unhealthy($"Ping is {ping}"));
            }
        }
    }
}
