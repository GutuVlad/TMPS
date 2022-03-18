using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactory.Entities
{
	public class StudentResultFactory
	{
		public static StudentResult CreateStudentResult(int registerId, int lessonId, int mark, AttendanceStatus status,
			string comment)
		{
			//CHECKING if registerId exists
			//CHECKING if lessonId exists

			if (mark < 1 || mark > 10)
			{
				throw new ArgumentException("Student mark should be an int from 1 to 10", nameof(mark));
			}

			if (!Enum.IsDefined(typeof(AttendanceStatus), status))
			{
				throw new ArgumentException("Input attendance status does not exist", nameof(status));
			}

			if (comment == null)
			{
				throw new ArgumentException("Comment string is null", nameof(comment));
			}

			StudentResult createdResult = new StudentResult()
			{
				AttendanceStatus = status,
				Comment = comment,
				LessonId = lessonId,
				Mark = mark,
				RegisterId = registerId
			};

			return createdResult;
		}
	}
}
