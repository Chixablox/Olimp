using System;
using System.Collections.Generic;
using System.IO;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input_s1_01.txt");
            string s = sr.ReadLine();
            int n = Convert.ToInt32(s);
            List<int[]> det = new List<int[]>();
            for (var i = 0; i < n; i++)
            {
                s = sr.ReadLine();
                int[] d1 = new int[20];
                for (var j = 0; j < 20; j++)
                {
                    d1[j] = Convert.ToInt32(s[j]);
                }
                det.Add(d1);
            }
            List<int[]> pol = new List<int[]>();
            for (var i = 0; i < 2*n; i++)
            {
                s = sr.ReadLine();
                int[] d1 = new int[15];
                for (var j = 0; j < 15; j++)
                {
                    d1[j] = Convert.ToInt32(s[j]);
                }
                pol.Add(d1);
            }
            List<int> otvet = new List<int>();
            for (var i = 0; i < 2 * n; i++)
            {
                if (pol[i][0] == 2) continue;
                for (var j = 0; j < n; j++)
                {
                    if (det[j][0] == 2) continue;
                    int sov = 0;
                    for (var l = 0; l < 5; l++)
                    {
                        if (pol[i][l] == det[j][l])
                        {
                            sov++;
                        }
                    }
                    for (var l = 5; l < 10; l++)
                    {
                        if (pol[i][l] == det[j][l])
                        {
                            sov++;
                        }
                    }
                    for (var l = 5; l < 10; l++)
                    {
                        if (pol[i][l] == det[j][l+5])
                        {
                            sov++;
                        }
                    }
                    for (var l = 10; l < 15; l++)
                    {
                        if (pol[i][l] == det[j][l + 5])
                        {
                            sov++;
                        }
                    }
                    int polov = 0;
                    for (var k = 0; k < 2 * n; k++)
                    {
                        if (k == i) continue;
                        for (var l = 0; l < 5; l++)
                        {
                            if (pol[i][l] == pol[k][l])
                            {
                                polov++;
                            }
                        }
                        for (var l = 10; l < 15; l++)
                        {
                            if (pol[i][l] == pol[k][l])
                            {
                                polov++;
                            }
                        }
                        if ((sov == 15) && (polov == 10))
                        {
                            det[j][0] = 2;
                            pol[i][0] = 2;
                            pol[k][0] = 2;
                            otvet.Add(j);
                            otvet.Add(k);
                            continue;
                        }
                    }
                }
            }
            for (var i = 0; i < otvet.Count; i++)
            {
                if(i%2!=0)Console.Write(otvet[i] + " ");
                else Console.WriteLine(otvet[i]);
            }
            Console.ReadLine();
        }
    }
}
