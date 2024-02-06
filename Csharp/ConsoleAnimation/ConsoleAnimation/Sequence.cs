using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimation
{
    internal class Sequence
    {
        public List<Frame> frames = new List<Frame>();
        public Sequence() {}

        public void AddFrame(List<string> input)
        {
            Frame temp = new Frame(input);
            frames.Add(temp);
        }
    }
}
