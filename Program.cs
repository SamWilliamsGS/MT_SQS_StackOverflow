using MassTransit;
using MT_SQS_StackOverflow;

var builder = WebApplication.CreateBuilder(args);

const string c_Region = "PERHAPS_eu-west-1";
const string c_AccessKey = "YOUR_ACCESS_KEY";
const string c_SecretKey = "YOUR_SECRET_KEY";

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<MyConsumer1>(typeof(MyConsumerDefinition1));
    x.AddConsumer<MyConsumer2>(typeof(MyConsumerDefinition2));
    x.AddConsumer<MyConsumer3>(typeof(MyConsumerDefinition3));
    x.AddConsumer<MyConsumer4>(typeof(MyConsumerDefinition4));
    
    x.AddConfigureEndpointsCallback((_, cfg) =>
    {
        if (cfg is IAmazonSqsReceiveEndpointConfigurator configurator)
        {
            configurator.AutoDelete = true;
        }
    });
    
    x.UsingAmazonSqs((context, cfg) =>
    {
        cfg.Host(c_Region, h =>
        {
            h.AccessKey(c_AccessKey);
            h.SecretKey(c_SecretKey);
        });

        cfg.Message<MyMessageType>(c =>
        {
            c.SetEntityName("MySNSTopicName");
        });

        cfg.ConfigureEndpoints(context);
    });
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();