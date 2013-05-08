using System;
using System.Threading;

namespace task_test
{
	public class FibArgs
	{
		public byte[] data;
		public int n;
	}

	public class Fib
	{
		public int Calculate(FibArgs args)
		{
			return Calculate(args.n);
		}

		public int Calculate(int n)
		{
			int a = 0;
			int b = 1;
			// In N steps compute Fibonacci sequence iteratively.
			for (int i = 0; i < n; i++)
			{
				int temp = a;
				a = b;
				b = temp + b;
			}
			Console.WriteLine("ThreadId: {2}, fib({0}) = {1}", n, a, Thread.CurrentThread.GetHashCode());
			return a;
		}
	}
}
