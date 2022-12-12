using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition5 : ConsumerDefinition<MyConsumer5>
{
    public MyConsumerDefinition5()
    {
        Endpoint(x => x.Name = $"MyQueue5-{Random.Shared.Next(1000)}.fifo");
    }
}