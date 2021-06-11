using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise15
{
    class Movie : IWritable
    {
        public string name { get; set; }

        public string screenwriter { get; set; }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return screenwriter;
        }
    }
}
