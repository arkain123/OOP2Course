using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class Archive
    {
        private Mark[] marks;

        public Mark[] GetMarks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }
    }
}
