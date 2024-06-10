using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class Lecturer
    {
        private string name;

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

        public void AnnounceCourse(Course course)
        {
            //курс анонсирован
        }

        public void GiveMark(Student student, int mark, Archive MarkArchive)
        {
            Mark new_mark = new(student, mark);
            MarkArchive.GetMarks.Append(new_mark);
        }
    }
}
