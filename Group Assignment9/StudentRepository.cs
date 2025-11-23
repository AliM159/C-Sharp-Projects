using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment9
{
    public static class StudentRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>();

        private static int _nextId = 1;

        public static int GetNextId() => _nextId++;
    }
}
