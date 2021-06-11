using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise15
{
    class Novel : IWritable
    {
        public string name { get; set; }

        public string author { get; set; }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return author;
        }
    }
}
