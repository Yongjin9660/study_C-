using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Thread_1_
{
    public partial class Form1 : Form
    {
        int _locationX = 0;
        int _locationY = 0;

        private enum enumPlayer
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }

        List<Play> list = new List<Play>();

        public Form1()
        {
            InitializeComponent();
            _locationX = this.Location.X;
            _locationY = this.Location.Y;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Play p in list)
            {
                p.ThreadAbort();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY + pl.Height * i);
                pl.eventdelMessage += Pl_eventdelMessage;
                pl.Show();
                pl.fThreadStart();
                list.Add(pl);
            }
        }

        private int Pl_eventdelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired)        //요청 한 Thread가 현재 Main Thread 있는 Control을 엑세스할 수 있는지 확인
            {
                this.Invoke(new Action(delegate ()
                {
                    Play oPlayerForm = sender as Play;
                    lboxResult.Items.Add(string.Format("Player : {0},Text : {1}", oPlayerForm.StringPlayerName, strResult));
                }));
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
