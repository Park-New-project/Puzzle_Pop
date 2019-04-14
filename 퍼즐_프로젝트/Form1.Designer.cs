namespace 퍼즐_프로젝트
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.게임시작버튼 = new System.Windows.Forms.Button();
            this.스테이지 = new System.Windows.Forms.Label();
            this.현재점수 = new System.Windows.Forms.Label();
            this.목표점수 = new System.Windows.Forms.Label();
            this.남은시간 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // 게임시작버튼
            // 
            this.게임시작버튼.BackColor = System.Drawing.Color.SeaShell;
            this.게임시작버튼.Font = new System.Drawing.Font("휴먼엑스포", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.게임시작버튼.Location = new System.Drawing.Point(28, 64);
            this.게임시작버튼.Name = "게임시작버튼";
            this.게임시작버튼.Size = new System.Drawing.Size(134, 75);
            this.게임시작버튼.TabIndex = 0;
            this.게임시작버튼.Text = "START";
            this.게임시작버튼.UseVisualStyleBackColor = false;
            this.게임시작버튼.Click += new System.EventHandler(this.게임시작버튼_Click);
            // 
            // 스테이지
            // 
            this.스테이지.AutoSize = true;
            this.스테이지.Font = new System.Drawing.Font("휴먼엑스포", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.스테이지.Location = new System.Drawing.Point(24, 173);
            this.스테이지.Name = "스테이지";
            this.스테이지.Size = new System.Drawing.Size(94, 23);
            this.스테이지.TabIndex = 2;
            this.스테이지.Text = "스테이지";
            // 
            // 현재점수
            // 
            this.현재점수.AutoSize = true;
            this.현재점수.Font = new System.Drawing.Font("휴먼엑스포", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.현재점수.Location = new System.Drawing.Point(24, 266);
            this.현재점수.Name = "현재점수";
            this.현재점수.Size = new System.Drawing.Size(94, 23);
            this.현재점수.TabIndex = 3;
            this.현재점수.Text = "현재점수";
            // 
            // 목표점수
            // 
            this.목표점수.AutoSize = true;
            this.목표점수.Font = new System.Drawing.Font("휴먼엑스포", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.목표점수.Location = new System.Drawing.Point(24, 357);
            this.목표점수.Name = "목표점수";
            this.목표점수.Size = new System.Drawing.Size(94, 23);
            this.목표점수.TabIndex = 4;
            this.목표점수.Text = "목표점수";
            // 
            // 남은시간
            // 
            this.남은시간.AutoSize = true;
            this.남은시간.Font = new System.Drawing.Font("휴먼엑스포", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.남은시간.Location = new System.Drawing.Point(24, 447);
            this.남은시간.Name = "남은시간";
            this.남은시간.Size = new System.Drawing.Size(94, 23);
            this.남은시간.TabIndex = 5;
            this.남은시간.Text = "남은시간";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(30, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 32);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "STAGE 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(28, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 32);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0 ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SeaShell;
            this.textBox3.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(30, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 32);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0 ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SeaShell;
            this.textBox4.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(30, 479);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(132, 32);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0 : 00 ";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(745, 558);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.남은시간);
            this.Controls.Add(this.목표점수);
            this.Controls.Add(this.현재점수);
            this.Controls.Add(this.스테이지);
            this.Controls.Add(this.게임시작버튼);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 게임시작버튼;
        private System.Windows.Forms.Label 스테이지;
        private System.Windows.Forms.Label 현재점수;
        private System.Windows.Forms.Label 목표점수;
        private System.Windows.Forms.Label 남은시간;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
    }
}

