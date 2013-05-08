using System;
using System.Threading;
using System.Threading.Tasks;


namespace task_test
{
	public class Task8Test : BaseTask
	{
		public void Run()
		{
			bool listening = true;
			while (listening)
			{
				int n = GetRandomInt(100);
				Fib f = new Fib();

				Task.Factory.StartNew(() => f.Calculate(n), TaskCreationOptions.LongRunning);
			}
		}

	}
}

