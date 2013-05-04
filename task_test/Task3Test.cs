using System;
using System.Threading;
using System.Threading.Tasks;


namespace task_test
{
	public class Task3Test : BaseTask
	{
		public void Run()
		{
			bool listening = true;
			long i = 0;
			while (listening)
			{
				i++;

				Func<int> fun = () => {
					int n = GetRandomInt(100);
					Fib f = new Fib();
					FibArgs args = new FibArgs();
					args.n = n;

					return f.Calculate(args);
				};

				var t = Task<int>.Factory.FromAsync(fun.BeginInvoke, fun.EndInvoke, null);
				t.ContinueWith(myTask => Cleanup(myTask), TaskContinuationOptions.PreferFairness);
			}
		}

		void Cleanup(Task<int> t)
		{
			Console.WriteLine("Cleaning up task {0}", t.Id);
			t.Dispose();
		}
	}
}

