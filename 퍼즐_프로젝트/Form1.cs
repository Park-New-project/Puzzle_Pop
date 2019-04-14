using System;
using System.Drawing;
using System.Windows.Forms;

namespace 퍼즐_프로젝트
{
    public partial class Form1 : Form
    {
        private int pu_X1, pu_Y1, pu_X2, pu_Y2;

        private static Bitmap 꽃 = new Bitmap("cle.png");

        public Form1()
        {
            InitializeComponent();
            GDIBuffer.Instance(500, 500);
        }

        private bool isstart = true;
        private bool 진행 = true;

        private void 게임시작버튼_Click(object sender, EventArgs e)
        {
            if (isstart)
            {
                퍼즐.랜덤();
                isstart = false;
            }
            퍼즐.그림(GDIBuffer.Instance().getGraphics);
            render();

            if (게임시작버튼.Text == "START")
            {
                게임시작버튼.Text = "PAUSE";
                진행 = true;
                timer1.Enabled = true;
            }
            else if (게임시작버튼.Text == "PAUSE")
            {
                게임시작버튼.Text = "START";
                진행 = false;
                timer1.Enabled = false;
            }
        }

        public void render()
        {
            Graphics g = CreateGraphics();
            g.DrawImage(GDIBuffer.Instance().GetImages, 200, 30);
            g.Dispose();
        }

        private int a = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a--;
            if (a > 9) { textBox4.Text = "0 : " + a; }
            else { textBox4.Text = "0 : 0" + a; }

            if (a < 1)
            {
                timer1.Enabled = false;
            }

            if (a == 0)
            {
                MessageBox.Show("게임종료.\n 점수는 : {0}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private bool isfirst = true;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (진행)
            {
                //마우스 클릭 좌표 확인
                if (e.X > 200 && e.X < 700 && e.Y > 30 && e.Y < 530)
                {
                    if (isfirst)
                    {
                        pu_X1 = (e.X - 200) / 50;
                        pu_Y1 = (e.Y - 30) / 50;

                        isfirst = false;
                    }
                    else
                    {
                        pu_X2 = (e.X - 200) / 50;
                        pu_Y2 = (e.Y - 30) / 50;

                        int dif_X = pu_X1 - pu_X2;
                        int dif_Y = pu_Y1 - pu_Y2;

                        //퍼즐 값 서로 변경
                        if (dif_X < 2 && dif_X > -2 && dif_Y < 2 && dif_Y > -2)
                        {
                            if (dif_X == 0 || dif_Y == 0)
                            {
                                int temp1 = 퍼즐.arr[pu_Y1, pu_X1];
                                퍼즐.arr[pu_Y1, pu_X1] = 퍼즐.arr[pu_Y2, pu_X2];
                                퍼즐.arr[pu_Y2, pu_X2] = temp1;

                                // 퍼즐 3개씩 확인
                                퍼즐.가로세로();
                                퍼즐.아래();
                                퍼즐.추가랜덤();

                                //퍼즐 값따라 그림 그리기
                                퍼즐.그림(GDIBuffer.Instance().getGraphics);
                                render();
                                isfirst = true;
                            }
                            else
                            {
                                퍼즐.그림(GDIBuffer.Instance().getGraphics);
                                render();
                                isfirst = true;
                            }
                        }
                    }
                }
            }
        }
    }
}