using System;

namespace task_test
{
	public class BaseTask
	{		
		public int GetRandomInt(int top)
		{
			Random random = new Random();

			return random.Next(1,top);
		}
	}
}

