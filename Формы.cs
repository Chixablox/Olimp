using System;
using System.Collections.Generic;
using System.IO;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            int p = 0;
            //Считывание данных
            StreamReader sr = new StreamReader("input3.txt");
            StreamReader sr1 = new StreamReader("output3.txt");
            string s = sr.ReadLine();
            int n = Convert.ToInt32(s);
            List<string[]> det = new List<string[]>();
            for (var i = 0; i < n; i++)
            {
                s = sr.ReadLine();
                string[] d1 = s.Split(' ');
                det.Add(d1);
            }
            List<string[]> pol = new List<string[]>();
            for (var i = 0; i < 2 * n; i++)
            {
                s = sr.ReadLine();
                string[] d1 = s.Split(' ');
                pol.Add(d1);
            }
            Console.WriteLine(n);
            //Решение задачи
            
            List<List<int>> otvet = new List<List<int>>();
            for (var i = 0; i < det.Count; i++)
            {
                List<int> d1 = new List<int>();
                otvet.Add(d1);
            }
            //Для тех случаев, когда освнова - лево или право
            //Верх-низ прямое
            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k + 10]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }

            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][19 - k + 5]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }
            //Верх-низ обратное
            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][4 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][14 - k + 10]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k]))
                        {
                            ch++;
                        }
                    }
                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }

            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][4 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][14 - k + 10]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][9 - k + 5]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }

            //Низ-верх
            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][k + 10]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][k - 10]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][9 - k + 5]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }


            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][k + 10]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][k - 10]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }
            //Низ-верх(обратное)
            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][14 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][14 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k + 10]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }

            for (var i = 0; i < pol.Count; i++)
            {
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][14 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][14 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][19 - k + 5]))
                        {
                            ch++;
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }





            //Для тех случаев, когда рассматриваем, что основа - низ или верх
            //Право-лево(прямое)(НЕ СДЕЛАЛ)
            for (var i = 0; i < pol.Count; i++)
            {
                if (pol[i][0] == "2") continue;
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][k + 15]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][k - 5]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    p = 4;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k - 5]) || (pol[i][k] == det[j][p]))
                        {
                            ch++;
                        }
                        p--;
                    }
                    if (ch < 15)
                    {
                        ch = 10;
                        for (var k = 5; k < 10; k++)
                        {
                            if (((pol[i][k] == det[j][14 - k + 5])) || (pol[i][k] == det[j][k + 5]))
                            {
                                ch++;
                            }
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }

            //Право-лево(обратное)(НЕ СДЕЛАЛ)
            for (var i = 0; i < pol.Count; i++)
            {
                if (pol[i][0] == "2") continue;
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][19 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][19 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    p = 4;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k - 5]) || (pol[i][k] == det[j][p]))
                        {
                            ch++;
                        }
                        p--;
                    }
                    if (ch < 15)
                    {
                        ch = 10;
                        for (var k = 5; k < 10; k++)
                        {
                            if (((pol[i][k] == det[j][14 - k + 5])) || ((pol[i][k] == det[j][k + 5])))
                            {
                                ch++;
                            }
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }


            //Лево-право(прямое)
            for (var i = 0; i < pol.Count; i++)
            {
                if (pol[i][0] == "2") continue;
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][k + 5]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][k + 5]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 10) continue;
                    p = 4;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k - 5]) || (pol[i][k] == det[j][p]))
                        {
                            ch++;
                        }
                        p--;
                    }
                    if (ch < 15)
                    {
                        ch = 10;
                        for (var k = 5; k < 10; k++)
                        {
                            if (((pol[i][k] == det[j][14 - k + 5])) || (pol[i][k] == det[j][k + 5]))
                            {
                                ch++;
                            }
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }

            //Лево-право(обратное)
            for (var i = 0; i < pol.Count; i++)
            {
                if (pol[i][0] == "2") continue;
                for (var j = 0; j < det.Count; j++)
                {
                    int ch = 0;
                    for (var k = 0; k < 5; k++)
                    {
                        if ((pol[i][k] == det[j][9 - k]))
                        {
                            ch++;
                        }
                    }
                    if (ch != 5) continue;
                    p = 19;
                    /*for (var k = 10; k < 15; k++)
                    {
                        if ((pol[i][k] == det[j][p]))
                        {
                            ch++;
                        }
                        p--;
                    }*/
                    if (ch != 10) continue;
                    p = 4;
                    for (var k = 5; k < 10; k++)
                    {
                        if ((pol[i][k] == det[j][k - 5]) || (pol[i][k] == det[j][p]))
                        {
                            ch++;
                        }
                        p--;
                    }
                    if (ch < 15)
                    {
                        ch = 10;
                        for (var k = 5; k < 10; k++)
                        {
                            if (((pol[i][k] == det[j][14 - k + 5])) || ((pol[i][k] == det[j][k + 5])))
                            {
                                ch++;
                            }
                        }
                    }

                    if (ch == 15)
                    {
                        pol[i][0] = "2";
                        otvet[j].Add(i + 1);
                    }
                }
            }



            //Вывод ответа
            Console.WriteLine("Мой ответ");
            for (var i = 0; i < n; i++)
            {
                otvet[i].Sort();
                for (var j = 0; j < otvet[i].Count; j++)
                {
                    Console.Write(otvet[i][j] + " ");
                }
                Console.WriteLine();
            }
            List<string[]> otvetreal = new List<string[]>();
            for (var i = 0; i < n; i++)
            {
                s = sr1.ReadLine();
                string[] d1 = s.Split(' ');
                otvetreal.Add(d1);
            }
            Console.WriteLine("Реальный ответ");
            for (var i = 0; i < det.Count; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    Console.Write(otvetreal[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
