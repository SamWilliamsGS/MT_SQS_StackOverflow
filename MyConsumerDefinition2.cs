using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition2 : ConsumerDefinition<MyConsumer2>
{
    public MyConsumerDefinition2()
    {
        Endpoint(x => x.Name = "MyQueue2");
    }
}