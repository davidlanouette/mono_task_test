using System;
using System.Threading;
using System.Threading.Tasks;


namespace task_test
{
	public class Task4Test : BaseTask
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

				Task.Factory.StartNew(() => f.Calculate(args), TaskCreationOptions.LongRunning)
					.ContinueWith(x => {
						if(x.IsFaulted)
						{ 
							Console.WriteLine("OOPS, error!!!");
							x.Exception.Handle(_ => true); //just an example, you'll want to handle properly

						}
						else if(x.IsCompleted)
						{
							Console.WriteLine("Cleaning up task {0}", x.Id);
							x.Dispose();
						}
					}
				);
			}
		}

	}
}

