using System;
using System.Collections.Generic;
using System.Drawing;

namespace 퍼즐_프로젝트
{
    internal class 퍼즐
    {
        public static int[,] arr = new int[10, 10];

        private static Bitmap 빨강 = new Bitmap("red.png");
        private static Bitmap 노랑 = new Bitmap("yel.png");
        private static Bitmap 초록 = new Bitmap("gre.png");
        private static Bitmap 파랑 = new Bitmap("blu.png");
        private static Bitmap 보라 = new Bitmap("vio.png");
        private static Bitmap 회색 = new Bitmap("ggg.png");

        public static void 랜덤()
        {
            Random 숫자 = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = 숫자.Next(0, 5);
                    가로세로();
                    추가랜덤();
                }
            }
        }
        public static void 그림(Graphics g)
        {
            g.DrawImage(배경.map, -15, -12);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    switch (arr[i, j])
                    {
                        case 0:
                            {
                                g.DrawImage(빨강, 50 * j, 50 * i, 50, 50);
                                break;
                            }
                        case 1:
                            {
                                g.DrawImage(노랑, 50 * j, 50 * i, 50, 50);
                                break;
                            }
                        case 2:
                            {
                                g.DrawImage(초록, 50 * j, 50 * i, 50, 50);
                                break;
                            }
                        case 3:
                            {
                                g.DrawImage(파랑, 50 * j, 50 * i, 50, 50);
                                break;
                            }
                        case 4:
                            {
                                g.DrawImage(보라, 50 * j, 50 * i, 50, 50);
                                break;
                            }
                        case 5:
                            {
                                g.DrawImage(회색, 50 * j, 50 * i, 50, 50);
                                break;
                            }
                    }

                }
            }
        }

        private class 좌표
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static void 가로세로()
        {
            
            List<좌표> 좌표리스트 = new List<좌표>();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int k = 0;
                    for (; k < 10 - j; k++)
                    {
                        if (arr[i, j] == arr[i, j + k])
                        {
                            continue;
                        }
                        else
                        {
                            
                            break;
                        }
                    }

                    int n = 0;
                    for (; n < 10 - j; n++)
                    {
                        if (arr[j, i] == arr[j + n, i])
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (k > 2)
                    {
                        for (int l = j; l < k + j; l++)
                        {
                            좌표리스트.Add(new 좌표() { X = i, Y = l });
                        }
                    }

                    if (n > 2)
                    {
                        for (int l = j; l < n + j; l++)
                        {
                            좌표리스트.Add(new 좌표() { X = l, Y = i });
                        }
                    }
                }
            }

            foreach (좌표 z in 좌표리스트)
            {
                arr[z.X, z.Y] = 5;
            }
        }


        public static void 아래()
        {
            for (int d = 0; d < 10; d++)
            {
                for (int a = 0; a < 10; a++)
                {
                    for (int b = 9; b != 0; b--)
                    {
                        for (int c = 0; c < b; c++)
                        {
                            if (arr[c + 1, a] == 5)
                            {
                                int temp2 = arr[c, a];
                                arr[c, a] = arr[c + 1, a];
                                arr[c + 1, a] = temp2;
                            }
                        }
                        가로세로();
                    }

                }
            }
        }

        public static void 추가랜덤()
        {
            Random 숫자2 = new Random();
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 10; n++)
                {
                    if (arr[m, n] == 5)
                    {
                        arr[m, n] = 숫자2.Next(0, 5);
                    }
                }
            }
        }
    }
}