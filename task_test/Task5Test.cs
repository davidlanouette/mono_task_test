using System;
using System.Threading;
using System.Threading.Tasks;


namespace task_test
{
	public class Task5Test : BaseTask
	{
		public void Run()
		{
			bool listening = true;
			long i = 0;
			while (listening)
			{
				int n = GetRandomInt(100);
				Fib f = new Fib();
				FibArgs args = new FibArgs();
				args.n = n;

				Task.Factory.StartNew(() => f.Calculate(args), TaskCreationOptions.LongRunning);
			}
		}

	}
}

