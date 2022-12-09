using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumer3 : IConsumer<MyMessageType>
{
    public Task Consume(ConsumeContext<MyMessageType> context)
    {
        return Task.CompletedTask;
    }
}