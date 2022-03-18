using System;
using System.Collections.Generic;

namespace SingletonFactory.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public int GroupId { get; set; }

		public List<StudentResult> Results { get; set; } = new List<StudentResult>();


		public void AddResult(int registerId, int lessonId, int mark, AttendanceStatus status,
			string comment)
		{
			try
			{
				Results.Add(StudentResultFactory.CreateStudentResult(registerId, lessonId, mark, status, comment));
				Logger.Instance.Log($"Student {this.Id} was marked with {mark}, {status}, {comment} on lesson {lessonId}, in register {registerId}");
			}
			catch (ArgumentException e)
			{
				Logger.Instance.Log($"[Student {this.Id}] "+e.Message);
			}
		}
	}
}
