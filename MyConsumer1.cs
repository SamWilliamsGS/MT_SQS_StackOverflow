using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumer1 : IConsumer<MyMessageType>
{
    public Task Consume(ConsumeContext<MyMessageType> context)
    {
        return Task.CompletedTask;
    }
}