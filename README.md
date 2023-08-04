# DelegateExample
https://dotnettutorials.net/lesson/delegates-real-time-example-csharp/


Let’s say we have a class called Worker and this class has a method called DoWork. What our business requirement is when we invoke the DoWork method, we need to send a notification about the percentage of work done to the consumer as well as once the work is completed, we also need to send the notification. For example, how much work is done in 1 hour, how much work is done in 2 hours, how much work is done in 3 hours, and so on until the work is completed? And the DoWork method has no idea to whom to send the notifications. The caller of the DoWork method should decide to whom to send the notification. That means here we need to use call-back functions.
