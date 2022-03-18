using System;
using SingletonFactory.Entities;

namespace SingletonFactory
{
	class Program
	{
		static void Main(string[] args)
		{

			try
			{
				Student std1 = StudentFactory.CreateStudentWithoutResults(1, "Gutu", "Vlad", 1);
				std1.AddResult(1, 1, 10, AttendanceStatus.Present, "Good boy");
				std1.AddResult(1, 1, -1, AttendanceStatus.Present, "Bad boy");
				std1.AddResult(1, 1, 1, (AttendanceStatus)55, "Awesome boy");

				Student std2 = StudentFactory.CreateStudentWithoutResults(1, string.Empty, "Cernavca", 1);
				Student std3 = StudentFactory.CreateStudentWithoutResults(1, "Ion", null, 1);
			}
			catch (ArgumentException e)
			{
				Logger.Instance.Log(e.Message);
			}

			Logger.Instance.DumpLogs();
		}
	}
}
