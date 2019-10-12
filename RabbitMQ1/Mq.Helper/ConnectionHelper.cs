using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mq.Helper
{
    public class ConnectionHelper
    {
        public IConnection Connection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            return connectionFactory.CreateConnection();
        }
    }
}
