using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Core
{
    public class Tile
    {
        public int Value { get; set;}
        public int X { get; set; }
        public int Y { get; set; }

        public Tile()
        {
            Value = 0;
        }

        public void DoubleValue()
        {
            Value *= 2;
        }
    }
}
