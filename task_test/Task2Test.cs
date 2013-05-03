using System;
using System.Threading;
using System.Threading.Tasks;


namespace task_test
{
	public class Task2Test : BaseTask
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
					args.data = new byte[1234567];
					args.n = n;

					return f.Calculate(args);
				};

				var t = Task<int>.Factory.FromAsync(fun.BeginInvoke, fun.EndInvoke, null);
				Console.WriteLine(t.Result);

				if (i%10 == 0)
				{
					Console.WriteLine("\n\nThreadId: {0}, iteration:{1}\n\n", Thread.CurrentThread.GetHashCode(), i);
				}
			}
		}
	}

}

