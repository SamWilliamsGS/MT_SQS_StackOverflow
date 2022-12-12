using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition8 : ConsumerDefinition<MyConsumer8>
{
    public MyConsumerDefinition8()
    {
        Endpoint(x => x.Name = $"MyQueue8-{Random.Shared.Next(1000)}.fifo");
    }
}