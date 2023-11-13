using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HanoiTower
{
    public partial class frmMain : Form
    {
        TimeSpan time;
        PictureBox[] disks;
        int countStep;
        Stack<PictureBox> disksA, disksB, disksC, firstClick, secondClick;
        private int f1 = 473, hdisks = 20, range = 50;

        private void st1_Click(object sender, EventArgs e)
        {
            if (cbBxCountDisk.Enabled) return;
            PictureBox clickSt = (PictureBox)sender;
            Stack<PictureBox> disksOfClick = (Stack<PictureBox>)clickSt.Tag;
            if (firstClick == null)
            {
                if (disksOfClick.Count == 0) return;
                firstClick = disksOfClick;
                clickSt.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondClick == null)
            {
                if (disksOfClick == firstClick)
                {
                    firstClick = null;
                    clickSt.BorderStyle= BorderStyle.None;
                    return;
                }
                secondClick = disksOfClick;
                ProcessMovingDisk(clickSt);
            }

        }



        private void pb8_Click(object sender, EventArgs e)
        {
            PictureBox clickDisk = (PictureBox)sender;
            if (disksA.Contains(clickDisk))
                st1_Click(st1, new EventArgs());
            else if (disksB.Contains(clickDisk))
                st1_Click(st2, new EventArgs());
            else st1_Click(st3, new EventArgs());
        }


        private void ProcessMovingDisk(PictureBox clickSt)
        {
            if (secondClick.Count == 0)
                MoveDisk(new Point(clickSt.Location.X + range, f1));
            
            else
            {
                PictureBox firstTop = firstClick.Peek();
                PictureBox secondTop = secondClick.Peek();
                if (int.Parse(firstTop.Tag.ToString()) < int.Parse(secondTop.Tag.ToString()))
                    MoveDisk(new Point(secondTop.Location.X, secondTop.Location.Y - hdisks));
                else
                    secondClick = null;
            }
        }

        private void MoveDisk(Point point)
        {
            PictureBox firstTop = firstClick.Pop();
            firstTop.Location = point;
            secondClick.Push(firstTop);
            ++countStep;
            lblCount.Text = string.Format("Количество шагов: "+ countStep);
            firstClick = secondClick = null;
            st1.BorderStyle = st2.BorderStyle = st3.BorderStyle = BorderStyle.None;

            if (disksC.Count == int.Parse(cbBxCountDisk.Text))
            {
                btnGiveIn.PerformClick();
                MessageBox.Show("Вы завершили игру!","Победа!");
            }
        }

        public frmMain()
        {
            InitializeComponent();
            disks = new PictureBox[] {pb1,pb2,pb3,pb4,pb5,pb6,pb7,pb8};
            st1.Tag = disksA = new Stack<PictureBox>();
            st2.Tag = disksB = new Stack<PictureBox>();
            st3.Tag = disksC = new Stack<PictureBox>();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lblTime.Text = string.Format("Время: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds); 
        }

        private void btnGiveIn_Click(object sender, EventArgs e)
        {
            f1 = 473; hdisks = 20;  range = 30;
            timer1.Stop();
            cbBxCountDisk.Enabled = true;
            cbBxCountDisk.Visible = true;
            label1.Visible = true;
            btnGiveIn.Enabled = false;
            btnStartGame.Text = "Начать";
            btnGiveIn.Visible = false;
            btnGiveIn.Visible = false;      
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnGiveIn.Visible = true;
            cbBxCountDisk.Visible = false;
            label1.Visible = false;
            timer1.Stop();
            foreach (PictureBox disk in disks)
                disk.Visible = false;
            time = new TimeSpan(0);
            countStep = 0;
            lblTime.Visible = true;
            lblCount.Visible = true;
            lblTime.Text = "Время: 00:00:00";
            lblCount.Text = "Количество шагов: 0";
            disksA.Clear();
            disksB.Clear();
            disksC.Clear();

            st1.BorderStyle = st2.BorderStyle = st3.BorderStyle = BorderStyle.None;
            firstClick = secondClick = null;

            cbBxCountDisk.Enabled = false;
            btnGiveIn.Enabled = true;
            btnStartGame.Text = "Начать";
            int x = 80 + range, y = f1;
            for (int i = Convert.ToInt32(cbBxCountDisk.Text) - 1; i >= 0; --i, y -= hdisks)
            {
                disks[i].Location = new Point(x + range, y);
                range += 10;
                disks[i].Visible = true;
                disksA.Push(disks[i]);
            }
            timer1.Start();
        }
    }
}
