using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise15
{
    class Song : IWritable
    {
        public string name { get; set; }

        public string songwriter { get; set; }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return songwriter;
        }
    }
}
