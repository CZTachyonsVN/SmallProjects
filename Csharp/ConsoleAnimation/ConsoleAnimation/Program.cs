using System.ComponentModel;
using System.Globalization;

namespace ConsoleAnimation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///-----000-----
            ///----0---0----
            ///---0-----0---

            //string line = "---0---";
            //Console.WriteLine(line.Remove(line.Length-1));    
            //Console.WriteLine(line);

            //List<char> list = new List<char>();



            //for (int i = 0; i < line.Length; i++)
            //{
            //    list.Add(line[i]);
            //}
            //while(true)
            //{

            //    foreach (char c in list)
            //    {
            //        Console.Write(c);
            //    }
            //    //Console.WriteLine();
            //    shiftLine();
            //    Thread.Sleep(100);
            //    Console.Clear();
            //}

            //List<string> animateThis = new List<string>();
            //SimpleAnimator myAnimator = new SimpleAnimator();

            //animateThis.Insert(0, "|||                ");
            //animateThis.Insert(0, "|||                ");
            //animateThis.Insert(0, "|||                ");
            //animateThis.Insert(0, "|||                ");

            //myAnimator.Image = animateThis;
            //myAnimator.Move();

            FrameByFrameAnimator Animator2 = new FrameByFrameAnimator();
            Sequence sequence = new Sequence();

            List<string> frame1 = new List<string>();
            frame1.Add("         ");
            frame1.Add("         ");
            frame1.Add("         ");
            frame1.Add("         ");
            sequence.AddFrame(frame1);
            //sequence.frames[0].Show();

            #region explosion
            List<string> frame2 = new List<string>();
            frame2.Add("          ");
            frame2.Add("          ");
            frame2.Add("          ");
            frame2.Add("    .     ");
            sequence.AddFrame(frame2);


            List<string> frame3  = new List<string>();
            frame3.Add("          ");
            frame3.Add("          ");
            frame3.Add("    0     ");
            frame3.Add("    |     ");
            sequence.AddFrame(frame3);

            List<string> frame4 = new List<string>();
            frame4.Add("          ");
            frame4.Add("   000    ");
            frame4.Add("  00000   ");
            frame4.Add("    0     ");
            sequence.AddFrame(frame4);

            List<string> frame5 = new List<string>();
            frame5.Add("0000000000");
            frame5.Add("0000000000");
            frame5.Add("  000000  ");
            frame5.Add("    00    ");
            sequence.AddFrame(frame5);

            List<string> frame6 = new List<string>();
            frame6.Add("000000 000");
            frame6.Add("00000 0000");
            frame6.Add("0000 00000");
            frame6.Add("000000000 ");
            sequence.AddFrame(frame6);

            List<string> frame7 = new List<string>();
            frame7.Add("0 000-000 ");
            frame7.Add("00.000 00 ");
            frame7.Add(".00000000 ");
            frame7.Add("000 00000 ");
            sequence.AddFrame(frame7);

            List<string> frame8 = new List<string>();
            frame8.Add("  000 00  ");
            frame8.Add("00*000'00 ");
            frame8.Add(" 000 000 0");
            frame8.Add("  00\000/ ");
            sequence.AddFrame(frame8);

            List<string> frame9 = new List<string>();
            frame9.Add(" 000 ,0_ , ");
            frame9.Add(" 00`0/0 0  ");
            frame9.Add("  00 /0/  ,");
            frame9.Add(" . `00'  ` ");
            sequence.AddFrame(frame9);

            List<string> frame10 = new List<string>();
            frame10.Add("  00  ,_  ");
            frame10.Add(" ( `0/00) ");
            frame10.Add("  00   /  ");
            frame10.Add("   `0/' ' ");
            sequence.AddFrame(frame10);

            List<string> frame11 = new List<string>();
            frame11.Add("  _.   _  ");
            frame11.Add(" ( `\\/'0) ");
            frame11.Add("  \\, ; /  ");
            frame11.Add("   `\\/'   ");
            sequence.AddFrame(frame11);

            List<string> frame12 = new List<string>();
            frame12.Add("  _    _  ");
            frame12.Add(" ( `\\/' ) ");
            frame12.Add("  \\    /  ");
            frame12.Add("   `\\/'   ");
            sequence.AddFrame(frame12);

            List<string> frame13 = new List<string>();
            frame13.Add("  _    _  ");
            frame13.Add(" ( `\\/' ) ");
            frame13.Add("  \\    /  ");
            frame13.Add("   `\\/'   ");
            sequence.AddFrame(frame13);

            List<string> frame14 = new List<string>();
            frame14.Add("          ");
            frame14.Add("  _    _  ");
            frame14.Add(" ( `\\/' ) ");
            frame14.Add("  \\    /  ");
            sequence.AddFrame(frame14);

            List<string> frame15 = new List<string>();
            frame15.Add("          ");
            frame15.Add("          ");
            frame15.Add("  _    _  ");
            frame15.Add(" ( `\\/' ) ");
            sequence.AddFrame(frame15);

            List<string> frame16 = new List<string>();
            frame16.Add("          ");
            frame16.Add("          ");
            frame16.Add("          ");
            frame16.Add("  _    _  ");
            sequence.AddFrame(frame16);

            List<string> frame17 = new List<string>();
            frame17.Add("          ");
            frame17.Add("          ");
            frame17.Add("          ");
            frame17.Add("          ");
            sequence.AddFrame(frame17);
            #endregion




            Console.WriteLine(sequence.frames.Count);

            Animator2.RunAnimation(sequence, 100);
            Console.ReadLine();
        }
    }
}


