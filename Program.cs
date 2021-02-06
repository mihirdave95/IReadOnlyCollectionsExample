using System;
using System.Linq;
using System.Threading.Tasks;
using IReadOnlyCollectionsExample.Repositories;

namespace IReadOnlyCollectionsExample
{
    class Program
    {
        // You can use "async Task Main" from c# 7.1 onwards 
        static async Task Main(string[] args)
        {
            // You(Or any other dev using this method) can't call Add(or any List -- methods) on this. 
            var students = await StudentRepository.GetReadOnlyStudentsAsync();
            
            // can call Add(or any List -- methods) on this.
            var studentList = await StudentRepository.GetStudentListAsync();

            // Checking if students list is not null and not empty.
            if (students?.Any() ?? false)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}, Standard: {student.Standard}");
                }
            }
        }
    }
}
