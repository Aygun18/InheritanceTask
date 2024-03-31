using System;

namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Tapşırıq:
			//Student classınız olsun. int[] Grades propertysi olsun.
			//Studentdən obyekt yaradıb grades-i set edəndə arrayin yalnız cüt ədədlərindən ibarət yeni bir array set olunsun.
			Student student = new Student();

            student.Grades=new int[] {34,36,44,48,45,67,56,78,76,23,26};
			student.GradesStudent();

			

        }
	}
}