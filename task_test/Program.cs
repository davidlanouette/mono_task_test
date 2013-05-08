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
			// var t = new Task2Test();

			// Test3 - = Test2, but with a cleanup at the end
			// var t = new Task3Test();

			// Test4 - = Test2, but with a cleanup at the end
			// var t = new Task4Test();

			// var t = new Task5Test();

			// var t = new Task6Test();

			// var t = new Task7Test();

			var t = new Task8Test();
			t.Run();

		}
	}
}
