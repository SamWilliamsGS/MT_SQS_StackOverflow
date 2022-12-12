using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition6 : ConsumerDefinition<MyConsumer6>
{
    public MyConsumerDefinition6()
    {
        Endpoint(x => x.Name = $"MyQueue6-{Random.Shared.Next(1000)}.fifo");
    }
}