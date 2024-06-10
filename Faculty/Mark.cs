using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class Mark
    {
        private Student student;
        private int mark_value;

        public Student Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }

        public int MarkValue
        {
            get
            {
                return mark_value;
            }
            set
            {
                if (mark_value >= 0 && mark_value <= 10)
                    mark_value = Convert.ToInt32(value);
                else
                    mark_value = 0;
            }
        }

        public Mark(Student new_student, int new_mark)
        {
            Student = new_student;
            MarkValue = new_mark;
        }
    }
}
