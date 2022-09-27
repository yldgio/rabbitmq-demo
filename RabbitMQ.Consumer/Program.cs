using RabbitMQ.Client;
using System;

namespace RabbitMQ.Consumer
{
    static class Program
    {
        private const string UriString = "amqp://guest:guest@localhost:5672";

        static void Main(string[] args)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri(uriString: UriString)
            };
            factory.ClientProvidedName = "app:audit component:event-consumer";
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            QueueConsumer.Consume(channel);
            //DirectExchangeConsumer.Consume(channel);
            //TopicExchangeConsumer.Consume(channel);
            //HeaderExchangeConsumer.Consume(channel);
            //FanoutExchangeConsumer.Consume(channel);
        }
    }
}