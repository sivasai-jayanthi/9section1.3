using System;

namespace _9section1._3
{
	class Program
	{


		static void Main(string[] args)
		{
			doApp();
			Console.ReadLine();
		}

		public static void doApp()
		{

			Student[] students = new Student[1];
			for (int i = 0; i < students.Length; i++)
			{
				students[i].name = "sai " + i.ToString();
				students[i].address = "india";
				students[i].rollNumber = i;
				students[i].className = "5";
				students[i].dateOfBirth = Convert.ToDateTime("2000-01-10 00:00:00");
			}

			for (int i = 0; i < students.Length; i++)
			{
				Console.Write(students[i].name + ",");
				Console.Write(students[i].address + ",");
				Console.Write(students[i].rollNumber + ",");
				Console.Write(students[i].className + ",");
				Console.Write(students[i].dateOfBirth);
				Console.WriteLine("------------------------");
			}
		}
	}

	struct Student
	{
		public string name;
		public string address;
		public int rollNumber;
		public string className;
		public DateTime dateOfBirth;
	}
}
