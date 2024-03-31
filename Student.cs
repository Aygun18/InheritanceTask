using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Student
	{
		public int[] Grades;

		public void GradesStudent()
		{
			int count = 0;

			foreach (int grade in Grades)
			{
				if (grade % 2 == 0)
				{
					count++;
				}
			}


			int[] evenGrades = new int[count];
			int count1 = 0;
			foreach(int grade in Grades)
			{
				if(grade%2==0)
				{
					evenGrades[count1]=grade;
					count1++;
				}
			}
			Grades = evenGrades;
			foreach (int grade in evenGrades)
			{
                Console.WriteLine(grade);
            }
		}
	}
}
