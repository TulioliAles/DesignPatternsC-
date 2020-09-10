using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01_Creational._1._3_Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;

        private readonly Random _randon = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Id = Guid.NewGuid(), Name = "Server I", IP = "120.14.220.18" },
                new Server{ Id = Guid.NewGuid(), Name = "Server II", IP = "120.14.220.19" },
                new Server{ Id = Guid.NewGuid(), Name = "Server III", IP = "120.14.220.20" },
                new Server{ Id = Guid.NewGuid(), Name = "Server IV", IP = "120.14.220.21" },
                new Server{ Id = Guid.NewGuid(), Name = "Server V", IP = "120.14.220.22" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _randon.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
