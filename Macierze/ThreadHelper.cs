using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macierze
{
    public class ThreadHelper
    {
        public ThreadHelper(int Row, int Column)
        {
            row = Row;
            column = Column;
        }

        public ThreadHelper(int numberofRow)
        {
            row = numberofRow;
        }
        public Thread thread { get; set; }
        public int row { get; set; }
        public int column { get; set; }

    }
}
