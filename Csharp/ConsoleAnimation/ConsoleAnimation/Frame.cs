using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimation
{
    internal class Frame
    {
        List<string> frame = new List<string>();
        public Frame(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                frame.Add(input[i]);
            }
        }
        
        public List<string> Return { get { return frame; } }

        public void Show()
        {
            for(int i = 0;i < frame.Count;i++)
            {
                Console.WriteLine(frame[i]);
            }
        }
    }
}
