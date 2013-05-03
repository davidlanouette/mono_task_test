using System;

namespace task_test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Test1 - Doesn't Leak
			// var t = new Task1Test();

			// Test2 - Leaks like mad!
			var t = new Task2Test();
			t.Run();

		}
	}
}
