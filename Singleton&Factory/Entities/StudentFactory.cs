using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactory.Entities
{
	public class StudentFactory
	{
		public static Student CreateStudentWithoutResults(int id, string name, string surname, int groupId)
		{
			if (String.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Student name shouldn't be a null string, empty string, or a whitespace", nameof(name));
			}

			if (String.IsNullOrWhiteSpace(surname))
			{
				throw new ArgumentException("Student surname shouldn't be a null string, empty string, or a whitespace", nameof(surname));
			}

			//CHECKING if the groupId exist


			Student createdStudent = new Student()
			{
				Id = id,
				GroupId = groupId,
				Name = name,
				Surname = surname
			};

			OnStudentCreation(createdStudent);

			return createdStudent;
		}


		private static void OnStudentCreation(Student newStudent)
		{
			Logger.Instance.Log($"{newStudent.Surname} {newStudent.Surname}[{newStudent.Id}] student in group {newStudent.GroupId} was created");
		}


		//on student creation log
	}
}
