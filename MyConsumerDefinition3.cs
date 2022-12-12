using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition3 : ConsumerDefinition<MyConsumer3>
{
    public MyConsumerDefinition3()
    {
        Endpoint(x => x.Name = $"MyQueue3-{Random.Shared.Next(1000)}.fifo");
    }
}