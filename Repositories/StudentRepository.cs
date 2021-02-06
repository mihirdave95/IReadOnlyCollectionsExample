using System.Collections.Generic;
using System.Threading.Tasks;
using IReadOnlyCollectionsExample.Models;

namespace IReadOnlyCollectionsExample.Repositories
{
    public static class StudentRepository
    {
        public static async Task<IReadOnlyList<Student>> GetReadOnlyStudentsAsync()
        {
            // Send Dummy Data from here.
            return await Task.FromResult<List<Student>>(
                new List<Student>
                {
                    new Student { Id=1,Name="Tom",Standard=9 },
                    new Student { Id=2,Name="Mac",Standard=9 },
                    new Student { Id=3,Name="Harry",Standard=9 },
                }
            );
        }

        public static async Task<List<Student>> GetStudentListAsync()
        {
            // Send Dummy Data from here.
            return await Task.FromResult<List<Student>>(
                new List<Student>
                {
                    new Student { Id=1,Name="Tom",Standard=9 },
                    new Student { Id=2,Name="Mac",Standard=9 },
                    new Student { Id=3,Name="Harry",Standard=9 },
                }
            );
        }
    }
}