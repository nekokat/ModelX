using System;
using System.Reflection;

namespace ModelX
{
	public class Test
	{
		public Test()
		{
			var members = typeof(Area).GetFields();
			foreach (var t in members)
			{
                Console.WriteLine(t.ToString());
			}
        }
	}
}