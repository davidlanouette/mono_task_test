using System;
using System.Net;
using System.IO;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace task_test
{
	public class Task1Test : BaseTask
	{

		public void Run()
		{
			bool listening = true;
			long i = 0;
			while (listening)
			{
				i++;
				int n = GetRandomInt(100);
				Fib f = new Fib();
				FibArgs args = new FibArgs();
				args.data = new byte[1234567];
				args.n = n;

				Task.Factory.StartNew(() => f.Calculate(args));
			
				if (i%10 == 0)
				{
					Console.WriteLine("ThreadId: {0}, iteration:{1}", Thread.CurrentThread.GetHashCode(), i);
				}
			}
		}


	}
}

