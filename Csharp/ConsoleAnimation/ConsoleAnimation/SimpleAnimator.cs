using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimation
{
    internal class SimpleAnimator
    {      
        public SimpleAnimator()
        {
        }
        private List<string> image = new List<string>();
        public List<string> Image
        { get => image; set => image = value; }

        public void Move()
        {
            int count = 100;
            while(count > 0)
            {
                Console.Clear();
                for(int i = 0; i < image.Count; i++)
                {
                    Console.WriteLine(image[i]);
                }
                Thread.Sleep(100);
                Shift();
                count--;
            }
        }

        private void Shift()
        {
            char temp;
            for (int i = 0; i < image.Count; i++)
            {
                temp = image[i].Last();
                image[i] = image[i].Remove(image[i].Length-1);
                image[i] = image[i].Insert(0, temp.ToString());
            }
            
        }
    }
}
