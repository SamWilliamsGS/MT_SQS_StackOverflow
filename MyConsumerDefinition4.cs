using MassTransit;

namespace MT_SQS_StackOverflow;

public class MyConsumerDefinition4 : ConsumerDefinition<MyConsumer4>
{
    public MyConsumerDefinition4()
    {
        Endpoint(x => x.Name = "MyQueue4");
    }
}