using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition7 : ConsumerDefinition<MyConsumer7>
{
    public MyConsumerDefinition7()
    {
        Endpoint(x => x.Name = $"MyQueue7-{Random.Shared.Next(1000)}.fifo");
    }
}