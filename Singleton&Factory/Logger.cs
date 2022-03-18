using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactory
{
	public class Logger
	{
		readonly string _logFilePath = Path.Combine(Directory.GetCurrentDirectory() + "\\logs.txt");

		private static readonly Lazy<Logger> instance = new (() => new Logger(), true);

		private Logger() { }

		public static Logger Instance => instance.Value;

		public void Log(string message)
		{
			string printedString = $"[{DateTime.UtcNow}]	{message}\n";

			File.AppendAllText(_logFilePath, printedString);
		}

		public void DumpLogs()
		{
			Console.WriteLine("---------------------------------------DUMPING LOG FILE--------------------------------------------------");
			using (StreamReader logFile = File.OpenText(_logFilePath))
			{
				string s = string.Empty;

				while ((s = logFile.ReadLine()) != null)
				{
					Console.WriteLine(s);
				}
			}

			Console.WriteLine("-------------------------------------------END LOGS------------------------------------------------------");
		}
	}
}
