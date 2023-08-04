using DelegateExample;

var delPerformed = new WorkPerformedHandler(WorkerWorkPerformed);
var delCompleted = new WorkCompletedHandler(WorkerWorkCompleted);

Worker.DoWork(5, "Generating Report", delPerformed, delCompleted);
Console.ReadKey();
return;

static void WorkerWorkPerformed(int hours, string workType)
{
    Console.WriteLine($"{hours} Hours completed for {workType}");
}

static void WorkerWorkCompleted(string workType)
{
    Console.WriteLine($"{workType} work completed");
}
