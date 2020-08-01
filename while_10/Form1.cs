using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1~45 6개의 번호
            int[] arr = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while (Array.IndexOf(arr,0)!=-1)
            {
                int number = rd.Next(1, 46);

                if (Array.IndexOf(arr, number) == -1)
                {
                    sb.Append(string.Format("{0}, ", number));
                    arr[iCount++] = number;
                }
            }
            

            lbl1.Text = sb.ToString();
            listBox.Items.Add(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int number = int.Parse(txtNumber.Text);

            int cnumber = 0;
            int icount = 0;
            do
            {
                cnumber = 0;
                icount = 0;
            } while (number != cnumber);
        }
    }
}
