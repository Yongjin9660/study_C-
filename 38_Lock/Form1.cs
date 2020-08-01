using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38_Lock
{
    public partial class Form1 : Form
    {
        Thread _T1;
        Thread _T2;

        object RoomLock1 = new object();
        object RoomLock2 = new object();

        int _Room1Count = 1;
        int _Room2Count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoom1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(string.Format("Room 1 : {0} 예약", _Room1Count));

            _T1 = new Thread(new ParameterizedThreadStart(Run));
            _T1.Start(_Room1Count);

            _Room1Count++;
        }

        private void Run(object obj)
        {
            lock (RoomLock1)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(delegate ()
                    {
                        lblLockStatus.Text = string.Format("Room 1 : Player {0} 사용 중", obj);
                    }));
                }
                for (int i = 1; i <= 3; i++)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            lboxResult.Items.Add(string.Format("Room 1 : Player {0} 진행 중 . . . {1}", obj, i));
                            Refresh();
                        }));
                    }
                    Thread.Sleep(1000);
                }

                if (InvokeRequired)
                {
                    Invoke(new Action(delegate ()
                    {
                        lblLockStatus.Text = string.Format("Room 1 : Player {0} 사용 완료", obj);
                    }));
                }
                Thread.Sleep(1000);
            }
        }

        private void btnRoom2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(string.Format("Room 2 : {0} 예약", _Room2Count));

            _T2 = new Thread(new ParameterizedThreadStart(Run2));
            _T2.Start(_Room2Count);

            _Room2Count++;
        }

        private void Run2(object obj)
        {
            lock (RoomLock2)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(delegate ()
                    {
                        lblLockStatus.Text = string.Format("Room 2 : Player {0} 사용 중", obj);
                    }));
                }
                for (int i = 1; i <= 3; i++)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            lboxResult.Items.Add(string.Format("Room 2 : Player {0} 진행 중 . . . {1}", obj, i));
                            Refresh();
                        }));
                    }
                    Thread.Sleep(1000);
                }

                if (InvokeRequired)
                {
                    Invoke(new Action(delegate ()
                    {
                        lblLockStatus.Text = string.Format("Room 2 : Player {0} 사용 완료", obj);
                    }));
                }
                Thread.Sleep(1000);
            }
        }

    }
}
