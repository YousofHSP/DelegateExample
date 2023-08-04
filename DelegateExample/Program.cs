using DelegateExample;

WorkPerformedHandler delPerformed = new WorkPerformedHandler(Worker_WorkPerformed);
WorkCompletedHandler delConpleted = new WorkCompletedHandler(Worker_WorkCompleted);

Worker worker = new Worker();
worker.DoWork(5, "Generating Report", delPerformed, delConpleted);
Console.ReadKey();

static void Worker_WorkPerformed(int hours, string workType)
{
    Console.WriteLine($"{hours} Hours compelted for {workType}");
}

static void Worker_WorkCompleted(string workType)
{
    Console.WriteLine($"{workType} work compplted");
}
