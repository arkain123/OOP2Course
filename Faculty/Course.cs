using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class Course
    {
        private string name;
        private Lecturer lecturer;
        private Student[] students;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Lecturer Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }

        public Student[] Students
        {
            get
            {
                return students;
            }
        }

        public void AddStudent(Student new_student)
        {
            Students.Append(new_student);
        }
    }
}
