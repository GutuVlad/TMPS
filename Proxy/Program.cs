using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var secureNestProxy = new SecureNestProxy(new RealNest());

			try
			{
				secureNestProxy.Access("Stegosaurus");
				secureNestProxy.Access("TRex");
			}
			catch (UnauthorizedAccessException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
