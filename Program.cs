using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(1, "Alice", 98);
            Student student2 = new Student(2, "Jason", 85);
            Student student3 = new Student(3, "Steve", 90);

            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);   

            Student storedStudent = (Student) studentsTable[1]; 

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
            }


            foreach(Student temp in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
            }
            //Console.WriteLine("Stored student from hashtable: "+ storedStudent.Name);
        }
    }
}
