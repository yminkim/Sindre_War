/*
생각난 김에 일단 만들고 보기
코드,,, 줄여야 하지만 안 줄일듯 -_-
*/


using System;
using System.Runtime.Intrinsics.X86;
using System.Timers;

namespace 무한의_계단
{
    class Program
    {
        static int _count = 0; // 카운트
        static int _maxCount = 0; //최고기록  카운트
        static int timeCount = 0; // 타임어택
        public class Floor
        {
            public bool boolGameStart;
            public int a = 1;
            public int b = 2;
            public int c = 6;
            public int d = 7;
            public int e = 8;
            public int f = 9;
            public int g = 10;
            public int h = 11;
            public int x = 0;


            public int b1 = 3;
            public int b2 = 4;
            public int b3 = 5;

            public int ax = 0;
            public int bx = 0;
            public int cx = 0;
            public int dx = 0;
            public int fx = 0;
            public int gx = 0;

            public int b1x =0;
            public int b2x = 0;
            public int b3x = 0;

            

            public void First()
            {
                Timer timer = new System.Timers.Timer();
                timer.Interval = 1000; // 타이머 간격 
                timer.Elapsed += new ElapsedEventHandler(timer_Elapsed); // 타이머 간격마다 이벤트 실행
                timeCount = 0;
                _count = 0;
                Console.Clear();
                Console.WriteLine("    ===\n");
                Console.WriteLine("        ===\n");
                Console.WriteLine("            ===\n");
                Console.WriteLine("                ===");
                Console.WriteLine("                    ");
                Console.WriteLine("                    ===\n");
                Console.WriteLine("                        ===");
                Console.WriteLine("                            ●");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine($"기록: {_count}");
                a = 1;
                b = 2;
                b1 = 3;
                b2 = 4;
                b3 = 5;
                c = 6;
                d = 7;
                e = 8;
                f = 9;
                g = 10;
                h = 11;
                ax = 0;
                bx = 0;
                b1x = 0;
                b2x = 0;
                b3x = 0;
                cx = 0;
                dx = 0;
                fx = 0;
                gx = 0;
                x = 0;

                boolGameStart = true;

                while (boolGameStart)
                {
                    Random ran = new Random();
                    int ranc = ran.Next(1, 6);
                    ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.Clear();
                            if (x == 0)
                            {
                                x = 1;
                                e += 1;
                            }
                            else if (x == 1)
                            {
                                x = 0;
                                e -= 1;
                            }

                            

                            if (a == 1)
                                Console.WriteLine("===\n");
                            else if (a == 2)
                                Console.WriteLine("    ===\n");
                            else if (a == 3)
                                Console.WriteLine("        ===\n");
                            else if (a == 4)
                                Console.WriteLine("            ===\n");
                            else if (a == 5)
                                Console.WriteLine("                ===\n");
                            else if (a == 6)
                                Console.WriteLine("                    ===\n");
                            else if (a == 7)
                                Console.WriteLine("                        ===\n");
                            else if (a == 8)
                                Console.WriteLine("                            ===\n");

                            ax = a;

                            if (a == 1)
                                a = 2;
                            else if (a == 7)
                                a = 6;
                            else if (ranc >= 1 && ranc <= 2)
                                a -= 1;
                            else if (ranc >= 3 && ranc <= 5)
                                a += 1;




                            if (b == 1)
                                Console.WriteLine("===\n");
                            else if (b == 2)
                                Console.WriteLine("    ===\n");
                            else if (b == 3)
                                Console.WriteLine("        ===\n");
                            else if (b == 4)
                                Console.WriteLine("            ===\n");
                            else if (b == 5)
                                Console.WriteLine("                ===\n");
                            else if (b == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b == 8)
                                Console.WriteLine("                            ===\n");
                            bx = b;
                            b = ax;



                            if (b1 == 1)
                                Console.WriteLine("===\n");
                            else if (b1 == 2)
                                Console.WriteLine("    ===\n");
                            else if (b1 == 3)
                                Console.WriteLine("        ===\n");
                            else if (b1 == 4)
                                Console.WriteLine("            ===\n");
                            else if (b1 == 5)
                                Console.WriteLine("                ===\n");
                            else if (b1 == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b1 == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b1 == 8)
                                Console.WriteLine("                            ===\n");
                            b1x = b1;
                            b1 = bx;


                            if (b2 == 1)
                                Console.WriteLine("===\n");
                            else if (b2 == 2)
                                Console.WriteLine("    ===\n");
                            else if (b2 == 3)
                                Console.WriteLine("        ===\n");
                            else if (b2 == 4)
                                Console.WriteLine("            ===\n");
                            else if (b2 == 5)
                                Console.WriteLine("                ===\n");
                            else if (b2 == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b2 == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b2 == 8)
                                Console.WriteLine("                            ===\n");
                            b2x = b2;
                            b2 = b1x;

                            if (b3 == 1)
                                Console.WriteLine("===\n");
                            else if (b3 == 2)
                                Console.WriteLine("    ===\n");
                            else if (b3 == 3)
                                Console.WriteLine("        ===\n");
                            else if (b3 == 4)
                                Console.WriteLine("            ===\n");
                            else if (b3 == 5)
                                Console.WriteLine("                ===\n");
                            else if (b3 == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b3 == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b3 == 8)
                                Console.WriteLine("                            ===\n");
                            b3x = b3;
                            b3 = b2x;


                            if (c == 1)
                                Console.WriteLine("===");
                            else if (c == 2)
                                Console.WriteLine("    ===");
                            else if (c == 3)
                                Console.WriteLine("        ===");
                            else if (c == 4)
                                Console.WriteLine("            ===");
                            else if (c == 5)
                                Console.WriteLine("                ===");
                            else if (c == 6)
                                Console.WriteLine("                    ===");
                            else if (c == 7)
                                Console.WriteLine("                        ===");
                            else if (c == 8)
                                Console.WriteLine("                            ===");
                            cx = c;
                            c = b3x;

                            if (d == 1)
                                Console.WriteLine(" ●\n===\n");
                            else if (d == 2)
                                Console.WriteLine("     ●\n    ===\n");
                            else if (d == 3)
                                Console.WriteLine("         ●\n        ===\n");
                            else if (d == 4)
                                Console.WriteLine("             ●\n            ===\n");
                            else if (d == 5)
                                Console.WriteLine("                 ●\n                ===\n");
                            else if (d == 6)
                                Console.WriteLine("                     ●\n                    ===\n");
                            else if (d == 7)
                                Console.WriteLine("                         ●\n                        ===\n");
                            else if (d == 8)
                                Console.WriteLine("                             ●\n                            ===\n");
                            dx = d;
                            d = cx;

                            /*
                            if (e == dx)
                            {
                                if (e == 1)
                                    Console.WriteLine(" ●");
                                else if (e == 2)
                                    Console.WriteLine("     ●");
                                else if (e == 3)
                                    Console.WriteLine("         ●");
                                else if (e == 4)
                                    Console.WriteLine("             ●");
                                else if (e == 5)
                                    Console.WriteLine("                 ●");
                                else if (e == 6)
                                    Console.WriteLine("                     ●");
                                else if (e == 7)
                                    Console.WriteLine("                         ●");
                                else if (e == 8)
                                    Console.WriteLine("                             ●");
                            }

                            */

                            if (e != dx || timeCount >= 60)
                            {
                                Console.Clear();
                                timer.Stop();
                                Console.WriteLine("---END---");
                                Console.WriteLine($"시간: {timeCount}초");
                                if (_count >= _maxCount)
                                {
                                    _maxCount = _count;
                                }
                                Console.WriteLine($"최고기록: {_maxCount}");
                                Console.WriteLine($"기록: {_count}");

                                Console.ReadLine();
                                boolGameStart = false;

                            }

                            if (f == 1)
                                Console.WriteLine("===\n");
                            else if (f == 2)
                                Console.WriteLine("    ===\n");
                            else if (f == 3)
                                Console.WriteLine("        ===\n");
                            else if (f == 4)
                                Console.WriteLine("            ===\n");
                            else if (f == 5)
                                Console.WriteLine("                ===\n");
                            else if (f == 6)
                                Console.WriteLine("                    ===\n");
                            else if (f == 7)
                                Console.WriteLine("                        ===\n");
                            else if (f == 8)
                                Console.WriteLine("                            ===\n");

                            fx = f;
                            f = dx;



                            if (g == 1)
                                Console.WriteLine("===\n");
                            else if (g == 2)
                                Console.WriteLine("    ===\n");
                            else if (g == 3)
                                Console.WriteLine("        ===\n");
                            else if (g == 4)
                                Console.WriteLine("            ===\n");
                            else if (g == 5)
                                Console.WriteLine("                ===\n");
                            else if (g == 6)
                                Console.WriteLine("                    ===\n");
                            else if (g == 7)
                                Console.WriteLine("                        ===\n");
                            else if (g == 8)
                                Console.WriteLine("                            ===\n");

                            gx = g;
                            g = fx;


                            _count += 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine($"기록: {_count}");

                            break;

                        ////////////////////////////////////////////////
                        case ConsoleKey.LeftArrow:
                            timer.Start();
                            Console.Clear();
                            if (x == 0)
                                e -= 1;
                            else if (x == 1)
                                e += 1;



                            if (a == 1)
                                Console.WriteLine("===\n");
                            else if (a == 2)
                                Console.WriteLine("    ===\n");
                            else if (a == 3)
                                Console.WriteLine("        ===\n");
                            else if (a == 4)
                                Console.WriteLine("            ===\n");
                            else if (a == 5)
                                Console.WriteLine("                ===\n");
                            else if (a == 6)
                                Console.WriteLine("                    ===\n");
                            else if (a == 7)
                                Console.WriteLine("                        ===\n");
                            else if (a == 8)
                                Console.WriteLine("                            ===\n");

                            ax = a;

                            if (a == 1)
                                a = 2;
                            else if (a == 7)
                                a = 6;
                            else if (ranc >= 1 && ranc <= 2)
                                a -= 1;
                            else if (ranc >= 3 && ranc <= 5)
                                a += 1;




                            if (b == 1)
                                Console.WriteLine("===\n");
                            else if (b == 2)
                                Console.WriteLine("    ===\n");
                            else if (b == 3)
                                Console.WriteLine("        ===\n");
                            else if (b == 4)
                                Console.WriteLine("            ===\n");
                            else if (b == 5)
                                Console.WriteLine("                ===\n");
                            else if (b == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b == 8)
                                Console.WriteLine("                            ===\n");
                            bx = b;
                            b = ax;

                            if (b1 == 1)
                                Console.WriteLine("===\n");
                            else if (b1 == 2)
                                Console.WriteLine("    ===\n");
                            else if (b1 == 3)
                                Console.WriteLine("        ===\n");
                            else if (b1 == 4)
                                Console.WriteLine("            ===\n");
                            else if (b1 == 5)
                                Console.WriteLine("                ===\n");
                            else if (b1 == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b1 == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b1 == 8)
                                Console.WriteLine("                            ===\n");
                            b1x = b1;
                            b1 = bx;


                            if (b2 == 1)
                                Console.WriteLine("===\n");
                            else if (b2 == 2)
                                Console.WriteLine("    ===\n");
                            else if (b2 == 3)
                                Console.WriteLine("        ===\n");
                            else if (b2 == 4)
                                Console.WriteLine("            ===\n");
                            else if (b2 == 5)
                                Console.WriteLine("                ===\n");
                            else if (b2 == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b2 == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b2 == 8)
                                Console.WriteLine("                            ===\n");
                            b2x = b2;
                            b2 = b1x;

                            if (b3 == 1)
                                Console.WriteLine("===\n");
                            else if (b3 == 2)
                                Console.WriteLine("    ===\n");
                            else if (b3 == 3)
                                Console.WriteLine("        ===\n");
                            else if (b3 == 4)
                                Console.WriteLine("            ===\n");
                            else if (b3 == 5)
                                Console.WriteLine("                ===\n");
                            else if (b3 == 6)
                                Console.WriteLine("                    ===\n");
                            else if (b3 == 7)
                                Console.WriteLine("                        ===\n");
                            else if (b3 == 8)
                                Console.WriteLine("                            ===\n");
                            b3x = b3;
                            b3 = b2x;


                            if (c == 1)
                                Console.WriteLine("===");
                            else if (c == 2)
                                Console.WriteLine("    ===");
                            else if (c == 3)
                                Console.WriteLine("        ===");
                            else if (c == 4)
                                Console.WriteLine("            ===");
                            else if (c == 5)
                                Console.WriteLine("                ===");
                            else if (c == 6)
                                Console.WriteLine("                    ===");
                            else if (c == 7)
                                Console.WriteLine("                        ===");
                            else if (c == 8)
                                Console.WriteLine("                            ===");
                            cx = c;
                            c = b3x;

                            

                            if (d == 1)
                                Console.WriteLine(" ●\n===\n");
                            else if (d == 2)
                                Console.WriteLine("     ●\n    ===\n");
                            else if (d == 3)
                                Console.WriteLine("         ●\n        ===\n");
                            else if (d == 4)
                                Console.WriteLine("             ●\n            ===\n");
                            else if (d == 5)
                                Console.WriteLine("                 ●\n                ===\n");
                            else if (d == 6)
                                Console.WriteLine("                     ●\n                    ===\n");
                            else if (d == 7)
                                Console.WriteLine("                         ●\n                        ===\n");
                            else if (d == 8)
                                Console.WriteLine("                             ●\n                            ===\n");
                            dx = d;
                            d = cx;

                            /*
                            if (e == dx)
                            {
                                if (e == 1)
                                    Console.WriteLine(" ●\n");
                                else if (e == 2)
                                    Console.WriteLine("     ●\n");
                                else if (e == 3)
                                    Console.WriteLine("         ●\n");
                                else if (e == 4)
                                    Console.WriteLine("             ●\n");
                                else if (e == 5)
                                    Console.WriteLine("                 ●\n");
                                else if (e == 6)
                                    Console.WriteLine("                     ●\n");
                                else if (e == 7)
                                    Console.WriteLine("                         ●\n");
                                else if (e == 8)
                                    Console.WriteLine("                             ●\n");
                            }
                            */

                            if (e != dx || timeCount >= 60)
                            {
                                Console.Clear();
                                timer.Stop();
                                Console.WriteLine("---END---");
                                Console.WriteLine($"시간: {timeCount}초");
                                if (_count >= _maxCount)
                                {
                                    _maxCount = _count;
                                }
                                Console.WriteLine($"최고기록: {_maxCount}");
                                Console.WriteLine($"기록: {_count}");
                                
                                Console.ReadLine();
                                boolGameStart = false;

                            }

                            if (f == 1)
                                Console.WriteLine("===\n");
                            else if (f == 2)
                                Console.WriteLine("    ===\n");
                            else if (f == 3)
                                Console.WriteLine("        ===\n");
                            else if (f == 4)
                                Console.WriteLine("            ===\n");
                            else if (f == 5)
                                Console.WriteLine("                ===\n");
                            else if (f == 6)
                                Console.WriteLine("                    ===\n");
                            else if (f == 7)
                                Console.WriteLine("                        ===\n");
                            else if (f == 8)
                                Console.WriteLine("                            ===\n");

                            fx = f;
                            f = dx;



                            if (g == 1)
                                Console.WriteLine("===\n");
                            else if (g == 2)
                                Console.WriteLine("    ===\n");
                            else if (g == 3)
                                Console.WriteLine("        ===\n");
                            else if (g == 4)
                                Console.WriteLine("            ===\n");
                            else if (g == 5)
                                Console.WriteLine("                ===\n");
                            else if (g == 6)
                                Console.WriteLine("                    ===\n");
                            else if (g == 7)
                                Console.WriteLine("                        ===\n");
                            else if (g == 8)
                                Console.WriteLine("                            ===\n");

                            gx = g;
                            g = fx;


                            _count += 1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine($"기록: {_count}");

                            break;


                        default:
                            break;

                    }
                }






            }


        }

        static void Main(string[] args)
        {
            Floor fl = new Floor();
            


            bool boolGameMain = true;
            while(boolGameMain)
            {
                Console.Clear();
                Console.WriteLine("[무한의 계단]");
                Console.WriteLine("1. 1분 타임어택");
                Console.WriteLine("2. 최고기록");

                string inputGameStart = Console.ReadLine();
                switch(inputGameStart)
                {
                    case "1":
                        fl.First();
                        break;
                    case "2":
                        bool record = true;
                        while (record)
                        {
                            Console.Clear();
                            Console.WriteLine($"최고기록: {_maxCount}");
                            Console.WriteLine("\n0.뒤로가기");

                            string inputOut = Console.ReadLine();
                            switch(inputOut)
                            {
                                case "0":
                                    record = false;
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;


                    default:
                        break;
                }
            }

        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timeCount += 1;
        }




    }
}
