using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition1 : ConsumerDefinition<MyConsumer1>
{
    public MyConsumerDefinition1()
    {
        Endpoint(x => x.Name = $"MyQueue1-{Random.Shared.Next(1000)}.fifo");
    }
}