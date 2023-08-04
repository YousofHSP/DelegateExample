using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void WorkPerformedHandler(int hours, string workType);
    public delegate void WorkCompletedHandler(string workType);

    public class Worker
    {
        public void DoWork(int hours, string workType, WorkPerformedHandler delPerformed, WorkCompletedHandler delCompleted)
        {
            delPerformed = null;
            delCompleted = null;
            // Do Work here and notify the customer that work has been performed
            for(int i = 0; i < hours; i++)
            {
                // Do Some Processing
                Thread.Sleep(1000);
                //Notify how much works have been done
                delPerformed(i + 1, workType);
            }
            delCompleted(workType);

        }
    }
}
