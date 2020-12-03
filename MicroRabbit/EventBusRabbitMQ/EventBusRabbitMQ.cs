using MicroRabbit.EventBus.Abstractions;
using MicroRabbit.EventBus.Events;

namespace MicroRabbit.EventBusRabbitMQ
{
    public sealed class EventBusRabbitMQ : IEventBus
    {
        public void Publish(IntegrationEvent @event)
        {
            throw new System.NotImplementedException();
        }

        public void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new System.NotImplementedException();
        }

        public void Unsubscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new System.NotImplementedException();
        }
    }
}
