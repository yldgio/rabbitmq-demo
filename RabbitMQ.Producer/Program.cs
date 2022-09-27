using RabbitMQ.Client;
using System;

namespace RabbitMQ.Producer
{
    static class Program
    {
        private const string UriString = "amqp://guest:guest@localhost:5672";
        //"amqp://guest:guest@localhost:5672/FattEl"
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory
            {
                
                Uri = new Uri(UriString)
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            QueueProducer.Publish(channel);
            //DirectExchangePublisher.Publish(channel);
            //    TopicExchangePublisher.Publish(channel);
            //    HeaderExchangePublisher.Publish(channel);
            //    FanoutExchangePublisher.Publish(channel);
        }
    }
}
