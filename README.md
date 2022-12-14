## MassTransit repo to reproduce stack overflow when creating multiple SQS queues

This bug seems to be triggered under the following conditions:

- Multiple SQS queues need to be created (the bug does not trigger with only one, and the more you add, the more likely it is to happen). If the queues already exist, the bug will not occur.
- The program should be run in regular "Run" mode in Rider rather than "Debug". The bug does not happen in "Debug" mode.
- To maximise chances of the bug occurring, make sure Dynamic Program Analysis (DPA) is switched on in Rider.
- As the stack overflow usually happens after the queues are created, it may be necessary to delete the queues in SQS manually in between runs. Auto delete doesn't always help because the crash isn't a graceful shutdown.
- This repo creates 8 new queues on each run to trigger the bug, so watch out for clutter

### Screenshots of the stack overflow

Apologies for the small text

![img.png](img.png)
![img_1.png](img_1.png)