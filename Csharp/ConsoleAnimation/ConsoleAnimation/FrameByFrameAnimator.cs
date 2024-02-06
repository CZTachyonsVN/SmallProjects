using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimation
{
    internal class FrameByFrameAnimator
    {
        
        public FrameByFrameAnimator(){}

        public void RunAnimation(Sequence input, int framerate)
        {
            Sequence thisSequece = input;
            int count = 2000;
            int currentFrame = 0;

            while(count > 0)
            {
                if (currentFrame < thisSequece.frames.Count)
                {
                    thisSequece.frames[currentFrame].Show();

                }
                else
                {                                        
                    currentFrame = 0;
                    thisSequece.frames[currentFrame].Show();
                }
                Console.WriteLine("frame: " + currentFrame);
                currentFrame++;
                count--;
                Thread.Sleep(framerate);               
                Console.Clear();
            }
        }
    }
}
