﻿using Ocelot.ServiceDiscovery.Providers;
using Ocelot.Values;
using Steeltoe.Discovery;

namespace Ocelot.Provider.Eureka
{
    public class Eureka : IServiceDiscoveryProvider
    {
        private readonly IDiscoveryClient _client;
        private readonly string _serviceName;

        public Eureka(string serviceName, IDiscoveryClient client)
        {
            _client = client;
            _serviceName = serviceName;
        }

        public Task<List<Service>> Get()
        {
            var services = new List<Service>();

            var instances = _client.GetInstances(_serviceName);

            if (instances != null && instances.Any())
            {
                services.AddRange(instances.Select(i => new Service(i.ServiceId, new ServiceHostAndPort(i.Host, i.Port, i.Uri.Scheme), string.Empty, string.Empty, new List<string>())));
            }

            return Task.FromResult(services);
        }
    }
}
