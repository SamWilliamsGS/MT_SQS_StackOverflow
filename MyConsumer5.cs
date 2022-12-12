using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumer5 : IConsumer<MyMessageType>
{
    public Task Consume(ConsumeContext<MyMessageType> context)
    {
        return Task.CompletedTask;
    }
}