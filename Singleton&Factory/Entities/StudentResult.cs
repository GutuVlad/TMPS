using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactory.Entities
{
	public class StudentResult
	{
		public int RegisterId { get; set; }
		public int LessonId { get; set; }
		public int Mark { get; set; }
		public AttendanceStatus AttendanceStatus { get; set; }
		public string Comment { get; set; }
	}
}
