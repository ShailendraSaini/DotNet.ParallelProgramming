namespace AsyncSampleProject
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        private int total;
        List<string> testData = new List<string> { "India", "Russia", "China","USA" };
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "Main";

            Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
            taskA.Start();

            Console.WriteLine("Hello from thread '{0}'.",
                              Thread.CurrentThread.Name);
            taskA.Wait();
        }

        private void WithAsync_Click(object sender, EventArgs e)
        {
            total = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.For(0, 100000000, x => Sum(total));
            stopwatch.Stop();
            MessageBox.Show(String.Format("{0}. miliseconds {1}.", 0, stopwatch.ElapsedMilliseconds));
            total = 0;
        }

        private void WithoutAsync_Click(object sender, EventArgs e)
        {
            total = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < 100000000; i++)
            {
                total = Sum(i);
            }
            stopwatch.Stop();
            MessageBox.Show(String.Format(" {0}. miliseconds {1}.", 0, stopwatch.ElapsedMilliseconds));
        }

        private int Sum(int value)
        {
            return value++;
        }

        private void Task_Click(object sender, EventArgs e)
        {
            total = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task.Run(() => Parallel.For(0, 100000000, x => Sum(total)));
            stopwatch.Stop();
            MessageBox.Show(String.Format("{0}. miliseconds {1}.", 0, stopwatch.ElapsedMilliseconds));
            total = 0;
        }

        private async void TaskAwait_Click(object sender, EventArgs e)
        {
            total = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await Task.Run(() => Parallel.For(0, 100000000, x => Sum(total)));
            stopwatch.Stop();
            MessageBox.Show(String.Format("{0}. miliseconds {1}.", 0, stopwatch.ElapsedMilliseconds));
            total = 0;
        }

        private void ParallerForeach()
        {
            Parallel.ForEach(testData,
            currentElement =>
            {
                //Perform Action
            });

            var data = from co in testData.AsParallel().AsOrdered()
                       where co.StartsWith("I")
                       select co;


            var data2 = from co in testData.AsParallel().WithDegreeOfParallelism(2)
                       where co.StartsWith("J")
                       select co;

            try
            {
                // We use ForAll although it doesn't really improve performance
                // since all output must be serialized through the Console.
                data2.ForAll(e => Console.WriteLine(e));
            }

            // IndexOutOfRangeException will not bubble up      
            // because we handle it where it is thrown.
            catch (AggregateException e)
            {
                foreach (var ex in e.InnerExceptions)
                    Console.WriteLine(ex.Message);
            }
        }
    }
}
